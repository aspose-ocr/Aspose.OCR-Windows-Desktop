using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Aspose.OCR.Models.PreprocessingFilters;
using System.Diagnostics;

namespace Aspose.OCR.Example
{
    public partial class Form1 : Form
    {
        public RichTextBoxStreamType t;
        public string ext;
    //    public bool exist;

        string imageName = "";
        System.Drawing.Image originalImage = null;
        System.Drawing.Image withRectangles = null;

        string licenseFullName = null;

        DetectAreasMode mode = DetectAreasMode.DOCUMENT;
        Language language = Language.None;
        RecognitionResult result = null;
        PreprocessingFilter preprocessingFilters = new PreprocessingFilter();

        Dictionary<string, PreprocessingFilter> filters = new Dictionary<string, PreprocessingFilter>();
        Dictionary<string, Language> alphabets = null;

        Stream preprocessed = null;

        string allowedImages = "*.png;*.jpg;*.JPG;*.tif;*.tiff;*.bmp;*.ico";

        public Form1()
        {
            InitializeComponent();
            imageUploadDialog.Filter = "Image|"+allowedImages;
            uploadLicenseDialog1.Filter = "Text|*.txt;*.lic";
            uploadTxtDialog.Filter = "Text|*.txt";
            
            t = RichTextBoxStreamType.RichText;
            ext = "";

            imageToRecognize.AllowDrop = true;
            imageToRecognize.DragDrop += Form1_DragDrop_1;

            toolStripComboBox_detectAreasMode.Items.Add("Structured document");
            toolStripComboBox_detectAreasMode.Items.Add("Photo");
            toolStripComboBox_detectAreasMode.Items.Add("Combined");
            toolStripComboBox_detectAreasMode.Items.Add("Table");
            toolStripComboBox_detectAreasMode.Items.Add("Curved text");
            toolStripComboBox_detectAreasMode.Items.Add("Text-in-wild");
            toolStripComboBox_detectAreasMode.Items.Add("None");

            toolStripComboBox_detectAreasMode.SelectedIndex = 0;

            ActivateDisactivate(false);
            lblWait.Visible = false;

            filters = HelpService.AddFilters();
            checkedListBox1.Items.AddRange(filters.Select(x => x.Key).ToArray());

            richTextBox_Ethalon.Visible = false;
            btn_clearEthalon.Visible = false;
            panel_refText.Visible = false;

            alphabets = HelpService.AddAlphabet();
            cb_language.Items.AddRange(alphabets.Select(x => x.Key).ToArray());
            cb_language.SelectedIndex = 0;


            this.toolTip1.SetToolTip(this.btn_clearEthalon, "Remove");

            uploadTxtDialog.Title = "Load reference text";
        }


        private void tSB_open_Click(object sender, EventArgs e)
        {          
            DialogResult d = imageUploadDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                lbl_DragAndDrop.Hide();
                pB_uploadIco.Hide();
                ClearAll(sender, e);
                imageName = imageUploadDialog.FileName;
                var loaded = new Bitmap(imageName);

                if (originalImage != null)
                {
                    originalImage.Dispose();
                    originalImage = null;
                }
                originalImage = new Bitmap(loaded);
                Size newSize = CalculateImageSize();

                Image imageCopy = new Bitmap(originalImage, newSize);
                imageToRecognize.Image = imageCopy;

                this.Text = imageUploadDialog.FileName;

                loaded.Dispose();
                ActivateRecognize(true);
            }

            imageUploadDialog.Dispose();
        }

        private void Form1_DragDrop_1(object sender, DragEventArgs e)
        {

            object file = (string[])(e.Data.GetData(DataFormats.FileDrop));
            FileInfo f = new FileInfo(((string[])file)[0]);
            string ext = f.Extension;

            if (!allowedImages.Contains(ext))
            {
                MessageBox.Show("Not allowed image type");
            }

            ClearAll(sender, e);

            lbl_DragAndDrop.Hide();
            pB_uploadIco.Hide();

            imageName = f.FullName;
            var loaded = new Bitmap(imageName);

            if (originalImage != null)
            {
                originalImage.Dispose();
                originalImage = null;
            }
            originalImage = new Bitmap(loaded);

            Size newSize = CalculateImageSize();

            Image imageCopy = new Bitmap(originalImage, newSize);
            imageToRecognize.Image = imageCopy;

            this.Text = imageName;

            loaded.Dispose();
            ActivateRecognize(true);
        }

        private void btn_recognize_Click(object sender, EventArgs e)
        {
            lblWait.Visible = true;
            richTextBox1.Text = "";
            this.Update();
            if (licenseFullName != null)
            {
                License lic = new License();
                lic.SetLicense(licenseFullName);
                if (lic.IsLicensed)
                {
                    lbl_license.Text = "Licensed";
                }
            }

            imageToRecognize.Image.Dispose();

            AsposeOcr api = new AsposeOcr();
            OcrInput input = null;

            if (preprocessed != null)
            {
                input = new OcrInput(InputType.SingleImage);
                input.Add((MemoryStream)preprocessed);
            }
            else
            {
                if(originalImage != null)
                {
                    originalImage.Dispose();
                    originalImage = null;
                }

                input = new OcrInput(InputType.SingleImage);
                input.Add(imageName);
            }

            RecognitionSettings settings = new RecognitionSettings
            {
                DetectAreasMode = mode,
                Language = language
            };

            this.Update();
            ActivateDisactivateAllSafe(false);
            var t = new Thread(() => StartRecognize(api, input, settings));
            t.Start();
        }

        private void StartRecognize(AsposeOcr api, OcrInput input, RecognitionSettings settings)
        {
            UpdateLblLogsSafe(true);
            string logText = "";
            api.OcrProgress += (Aspose.OCR.Models.Events.OcrPageRecognizeEventsArgs e) =>
            {
                logText += (e.FileName + " Page " + e.CurrentPage + "   " + "image " + e.CurrentImage + "   " + e.Duration.TotalSeconds + "s  " + e.OperationName+"\n");
                UpdateLblLogsSafe(logText);
            };
        
            result = api.Recognize(input, settings)[0];
            UpdateLblLogsSafe("");
            UpdateLblLogsSafe(false);

            UpdateLblWaitSafe(false);
            UpdateResultSafe();

            if (preprocessed != null)
            {
                originalImage = Bitmap.FromStream(preprocessed);
            }
            else
            {
                originalImage = Bitmap.FromFile(imageName);
            }

            if (withRectangles != null)
            {
                withRectangles.Dispose();
            }

            withRectangles = HelpService.DrawRectangles(originalImage, System.Drawing.Color.Red, result.RecognitionLinesResult.Select(x => x.Line).ToList(), result.Skew);

            Size newSize = CalculateImageSize();

            Image imageCopy = new Bitmap(withRectangles, newSize);
            imageToRecognize.Image = imageCopy;
            UpdateEthalonSafe();
            ActivateDisactivateAllSafe(true);
        }

        private void btn_preprocess_Click(object sender, EventArgs e)
        {
            ActivateDisactivateAllSafe(false);
            lblWait.Visible = true;
            this.Update();          

            imageToRecognize.Image.Dispose();

            AsposeOcr api = new AsposeOcr();
            OcrInput input = new OcrInput(InputType.SingleImage, preprocessingFilters);

            ActivateDisactivateAllSafe(false);
            var t = new Thread(() => StartPreprocess(api, input));
            t.Start();
        }

        private void StartPreprocess(AsposeOcr api, OcrInput input)
        {
            if (preprocessed != null)
            {
                input.Add((MemoryStream)preprocessed);
            }
            else
            {
                if(originalImage != null)
                {
                    originalImage.Dispose();
                    originalImage = null;
                }

                input.Add(imageName);
            }
            OcrInput output = ImageProcessing.Render(input);

            UpdateLblWaitSafe(false);

            if (originalImage != null)
            {
                originalImage.Dispose();
            }
            originalImage = Bitmap.FromStream(output[0].Stream);


            Size newSize = CalculateImageSize();

            Image imageCopy = new Bitmap(originalImage, newSize);
            imageToRecognize.Image = imageCopy;

            if (preprocessed != null)
            {
                preprocessed.Dispose();
            }

            preprocessed = output[0].Stream;

            ActivateDisactivateAllSafe(true);
        }

      

        private void tSB_save_result_Click(object sender, EventArgs e)
        {
            SaveFormatForm saveFormat = new SaveFormatForm();
            saveFormat.StartPosition = FormStartPosition.CenterParent;

            saveFormat.ShowDialog();
            if(!SaveFormatForm.isNeedToSave)
            {
                return;
            }

            saveFileDialog1 = new SaveFileDialog();

            SaveFormat format = SaveFormatForm.saveFormat;
            string ext = format switch
            {
                SaveFormat.Docx => "docx",
                SaveFormat.EPUB => "epub",
                SaveFormat.HTML => "html",
                SaveFormat.Json => "json",
                SaveFormat.Pdf => "pdf",
                SaveFormat.PdfNoImg => "pdf",
                SaveFormat.RTF => "rtf",
                SaveFormat.Xlsx => "xlsx",
                SaveFormat.Xml => "xml",
                _ => "txt"
            };

            saveFileDialog1.DefaultExt = ext;
            saveFileDialog1.Title = "Save recognition result as";
            saveFileDialog1.Filter = "File|*."+ext;
            DialogResult d = saveFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                FileInfo file = new FileInfo(saveFileDialog1.FileName);
                string filename = file.FullName;
                if (file.Extension != "."+ext)
                {
                    filename = filename + "." + ext;
                }

                AsposeOcr.SaveMultipageDocument(filename, format, new List<RecognitionResult> { result });
                var messageBox = MessageBox.Show("Saved");
            }

            saveFileDialog1.Dispose();
        }
    
        private void tSB_save_image_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            if (withRectangles == null)
            {
                MessageBox.Show("Nothing to save");
                return;
            }

            saveFileDialog1.Title = "Save image preview";
            saveFileDialog1.Filter = "Image|*.png";
            DialogResult d = saveFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                FileInfo file = new FileInfo(saveFileDialog1.FileName);


                withRectangles.Save(file.FullName);
                var messageBox = MessageBox.Show("Saved");
            }

            saveFileDialog1.Dispose();
        }

        private void tSB_clear_Click(object sender, EventArgs e)
        {
            ClearAll(sender, e);
            ResetAllFilters();
            lbl_DragAndDrop.Show();
            pB_uploadIco.Show();

            ActivateDisactivate(false);

            richTextBox_Ethalon.Text = "";
            richTextBox_Ethalon.Visible = false;
            panel_refText.Visible = false;
            btn_clearEthalon.Visible = false;
        }


     

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }   

        private void cb_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string languageSelected = cb_language.SelectedItem.ToString();
                language = alphabets[languageSelected];
            }
            catch
            {
            }
        } 


        private void btn_uploadLicense_Click(object sender, EventArgs e)
        {
            DialogResult d = uploadLicenseDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                licenseFullName = uploadLicenseDialog1.FileName;
            }

            if (licenseFullName != null)
            {
                License lic = new License();
                try
                {
                    lic.SetLicense(licenseFullName);
                    if (lic.IsLicensed)
                    {
                        lbl_license.Text = "Licensed";
                        this.toolTip1.SetToolTip(this.lbl_license, "");
                    }
                    else
                    {
                        lbl_license.Text = "Unlicensed";
                        this.toolTip1.SetToolTip(this.lbl_license, "");
                    }
                }
                catch(Exception ex)
                {
                    lbl_license.Text = "Unlicensed";
                    this.toolTip1.SetToolTip(this.lbl_license, ex.Message);
                }
            }
        }

        private void toolStripComboBox_detectAreasMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string modeSelected = toolStripComboBox_detectAreasMode.SelectedItem.ToString();
                mode = modeSelected switch
                {
                    "Structured document" => DetectAreasMode.DOCUMENT,
                    "Photo" => DetectAreasMode.PHOTO,
                    "Combined" => DetectAreasMode.COMBINE,
                    "Curved text" => DetectAreasMode.CURVED_TEXT,
                    "Table" => DetectAreasMode.TABLE,
                    "Text-in-wild" => DetectAreasMode.TEXT_IN_WILD,
                    "None" => DetectAreasMode.NONE,
                    _ => DetectAreasMode.DOCUMENT
                };

                if(modeSelected == "Text-in-wild")
                {
                    cb_language.SelectedIndex = 0;
                    cb_language.Enabled = false;
                }
                else
                {
                    cb_language.Enabled = true;
                }
            }
            catch
            {
            }
        }

        private void checkedLb_filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection filters = ((CheckedListBox)sender).CheckedItems;
            preprocessingFilters = new PreprocessingFilter();
            foreach (string item in filters)
            {
                    preprocessingFilters.Add(this.filters[item]);
            }
        }

        private void ClearAll(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                originalImage.Dispose();
                originalImage = null;
            }

            if (imageToRecognize.Image != null)
            {
                imageToRecognize.Image.Dispose();
                imageToRecognize.Image = null;
            }

            richTextBox1.Clear();

            if (preprocessed != null)
            {
                preprocessed.Dispose();
                preprocessed = null;
            }

            if (withRectangles != null)
            {
                withRectangles.Dispose();
                withRectangles = null;
            }

            lbl_levenshtain.Text = "0";

            this.Update();
        }

        void ResetAllFilters()
        {
            preprocessingFilters = new PreprocessingFilter();


            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, false);
            checkedListBox1.SetItemChecked(3, false);
            checkedListBox1.SetItemChecked(4, false);
            checkedListBox1.SetItemChecked(5, false);
            checkedListBox1.SetItemChecked(6, false);
            checkedListBox1.SetItemChecked(7, false);
            checkedListBox1.SetItemChecked(8, false);

            cb_language.SelectedIndex = 0;
            toolStripComboBox_detectAreasMode.SelectedIndex = 0;
        }

        private Size CalculateImageSize()
        {
            SizeF size = originalImage.PhysicalDimension;
            float imgWidth = size.Width;
            float imgHeight = size.Height;

            float boxWidth = imageToRecognize.Size.Width;
            float boxHeight = imageToRecognize.Size.Height;

            float ratioW = imgWidth / boxWidth;
            float ratioH = imgHeight / boxHeight;

            float ratio = ratioH > ratioW ? ratioH : ratioW;
            Size newSize = new Size((int)(imgWidth / ratio), (int)(imgHeight / ratio));

            return newSize;
        }


        private void btn_resetToOriginal_Click(object sender, EventArgs e)
        {
            originalImage = Bitmap.FromFile(imageName);

            Size newSize = CalculateImageSize();

            Image imageCopy = new Bitmap(originalImage, newSize);
            imageToRecognize.Image = imageCopy;
            if (originalImage != null)
            {
                originalImage.Dispose();
                originalImage = null;
            }

            if (preprocessed != null)
            {
                preprocessed.Dispose();
                preprocessed = null;
            }

            ResetAllFilters();
        }


        private void btn_uploadEthalon_Click(object sender, EventArgs e)
        {          
            DialogResult d = uploadTxtDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                var ethalonName = uploadTxtDialog.FileName;
                string text = File.ReadAllText(ethalonName);
                richTextBox_Ethalon.Text = text;
                richTextBox_Ethalon.Visible = true;
                panel_refText.Show();
                panel_refText.Visible = true;

                uploadTxtDialog.Dispose();

                btn_clearEthalon.Visible = true;

                if (result != null)
                {
                    lbl_levenshtain.Text = HelpService.LevenshteinDistance(text, result.RecognitionText).ToString();
                    DialogResult md = MessageBox.Show($"Levenshtein: {lbl_levenshtain.Text}");
                }
            }
        }

        private void btn_difference_Click(object sender, EventArgs e)
        {

        }

        private void btn_clearEthalon_Click(object sender, EventArgs e)
        {
            richTextBox_Ethalon.Text = "";
            richTextBox_Ethalon.Visible = false;
            btn_clearEthalon.Visible = false;
            panel_refText.Hide();
        }

    

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearAll(sender, e);
        }

        private void toolStripBtnHelp_Click(object sender, EventArgs e)
        {

            Process myProcess = new Process();

            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://docs.aspose.com/ocr/net/developer-reference/";
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ActivateDisactivate(bool status)
        {
            this.ts_btn_SaveImage.Enabled = status;
            this.btn_preprocess.Enabled = status;
            this.btn_resetToOriginal.Enabled = status;
            this.toolStripBtnRecognize.Enabled = status;

            if (result != null || status == false)
            {
                this.tSB_save_result.Enabled = status;
            }
        }

        private void ActivateRecognize(bool status)
        {
            this.btn_preprocess.Enabled = status;
            this.btn_resetToOriginal.Enabled = status;
            this.toolStripBtnRecognize.Enabled = status;
        }

        private void ActivateDisactivateAllSafe(bool status)
        {
            if (this.toolStrip1.InvokeRequired)
            {
                this.toolStrip1.Invoke(new Action(() => ActivateDisactivateAllSafe(status)));
            }
            else
            {
                this.toolStrip1.Enabled = status;
                this.checkedListBox1.Enabled = status;
                ActivateDisactivate(status);
            }     
        }

        private void UpdateLblWaitSafe(bool isVis)
        {
            if (lblWait.InvokeRequired)
            {
                lblWait.Invoke(new Action(() => UpdateLblWaitSafe(isVis)));
            }
            else
            {
                lblWait.Visible = isVis;
            }
        }

        private void UpdateLblLogsSafe(bool status)
        {
            if (lblLogs.InvokeRequired)
            {
                lblLogs.Invoke(new Action(() => UpdateLblLogsSafe(status)));
            }
            else
            {
                lblLogs.Visible = status;
            }
        }

        private void UpdateLblLogsSafe(string text)
        {
            if (lblLogs.InvokeRequired)
            {
                lblLogs.Invoke(new Action(() => UpdateLblLogsSafe(text)));
            }
            else
            {
                lblLogs.Text = text;
            }
        }

        private void UpdateResultSafe()
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action(() => UpdateResultSafe()));
            }
            else
            {
                richTextBox1.Text = result.RecognitionText;
                lblResultSkew.Text = result.Skew.ToString("0.00");
            }          
        }

        private void UpdateEthalonSafe()
        {
            if (richTextBox_Ethalon.InvokeRequired)
            {
                richTextBox_Ethalon.Invoke(new Action(() => UpdateEthalonSafe()));
            }
            else
            {
                string text = richTextBox_Ethalon.Text;
                if (result != null && !String.IsNullOrEmpty(text))
                {
                    lbl_levenshtain.Text = HelpService.LevenshteinDistance(text, result.RecognitionText).ToString();
                    DialogResult md = MessageBox.Show($"Levenshtein: {lbl_levenshtain.Text}");
                }
            }
        }
    }
}
