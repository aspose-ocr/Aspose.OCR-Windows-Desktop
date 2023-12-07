namespace Aspose.OCR.Example
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB_open = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUploadLic = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUploadEthalon = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRecognize = new System.Windows.Forms.ToolStripButton();
            this.tSB_save_result = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_SaveImage = new System.Windows.Forms.ToolStripButton();
            this.tSB_clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cb_language = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_detectAreasMode = new System.Windows.Forms.ToolStripComboBox();
            this.imageUploadDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.imageToRecognize = new System.Windows.Forms.PictureBox();
            this.lblWait = new System.Windows.Forms.Label();
            this.uploadLicenseDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_DragAndDrop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_resetToOriginal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultSkew = new System.Windows.Forms.Label();
            this.richTextBox_Ethalon = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_levenshtain = new System.Windows.Forms.Label();
            this.btn_clearEthalon = new System.Windows.Forms.Button();
            this.lblLicense = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_preprocess = new System.Windows.Forms.Button();
            this.pB_uploadIco = new System.Windows.Forms.PictureBox();
            this.lbl_license = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uploadTxtDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblLogs = new System.Windows.Forms.Label();
            this.panel_refText = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageToRecognize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_uploadIco)).BeginInit();
            this.panel_refText.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(536, 122);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(541, 344);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_open,
            this.toolStripBtnUploadLic,
            this.toolStripBtnUploadEthalon,
            this.toolStripBtnRecognize,
            this.tSB_save_result,
            this.ts_btn_SaveImage,
            this.tSB_clear,
            this.toolStripBtnHelp,
            this.toolStripLabel1,
            this.cb_language,
            this.toolStripLabel2,
            this.toolStripComboBox_detectAreasMode});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1077, 70);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            // 
            // tSB_open
            // 
            this.tSB_open.Image = ((System.Drawing.Image)(resources.GetObject("tSB_open.Image")));
            this.tSB_open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSB_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_open.Name = "tSB_open";
            this.tSB_open.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tSB_open.Size = new System.Drawing.Size(90, 21);
            this.tSB_open.Text = "Load image";
            this.tSB_open.ToolTipText = "Load image";
            this.tSB_open.Click += new System.EventHandler(this.tSB_open_Click);
            // 
            // toolStripBtnUploadLic
            // 
            this.toolStripBtnUploadLic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnUploadLic.Image")));
            this.toolStripBtnUploadLic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnUploadLic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUploadLic.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.toolStripBtnUploadLic.Name = "toolStripBtnUploadLic";
            this.toolStripBtnUploadLic.Size = new System.Drawing.Size(91, 19);
            this.toolStripBtnUploadLic.Text = "Load license";
            this.toolStripBtnUploadLic.ToolTipText = "Load license";
            this.toolStripBtnUploadLic.Click += new System.EventHandler(this.btn_uploadLicense_Click);
            // 
            // toolStripBtnUploadEthalon
            // 
            this.toolStripBtnUploadEthalon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnUploadEthalon.Image")));
            this.toolStripBtnUploadEthalon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnUploadEthalon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUploadEthalon.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.toolStripBtnUploadEthalon.Name = "toolStripBtnUploadEthalon";
            this.toolStripBtnUploadEthalon.Size = new System.Drawing.Size(130, 19);
            this.toolStripBtnUploadEthalon.Text = "Load reference text ";
            this.toolStripBtnUploadEthalon.ToolTipText = "Load reference text ";
            this.toolStripBtnUploadEthalon.Click += new System.EventHandler(this.btn_uploadEthalon_Click);
            // 
            // toolStripBtnRecognize
            // 
            this.toolStripBtnRecognize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRecognize.Image")));
            this.toolStripBtnRecognize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnRecognize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRecognize.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.toolStripBtnRecognize.Name = "toolStripBtnRecognize";
            this.toolStripBtnRecognize.Size = new System.Drawing.Size(81, 20);
            this.toolStripBtnRecognize.Text = "Recognize";
            this.toolStripBtnRecognize.Click += new System.EventHandler(this.btn_recognize_Click);
            // 
            // tSB_save_result
            // 
            this.tSB_save_result.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSB_save_result.Image = ((System.Drawing.Image)(resources.GetObject("tSB_save_result.Image")));
            this.tSB_save_result.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSB_save_result.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_save_result.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.tSB_save_result.Name = "tSB_save_result";
            this.tSB_save_result.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tSB_save_result.Size = new System.Drawing.Size(88, 23);
            this.tSB_save_result.Text = "Save result";
            this.tSB_save_result.ToolTipText = "Save recognition result";
            this.tSB_save_result.Click += new System.EventHandler(this.tSB_save_result_Click);
            // 
            // ts_btn_SaveImage
            // 
            this.ts_btn_SaveImage.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_SaveImage.Image")));
            this.ts_btn_SaveImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_btn_SaveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_SaveImage.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.ts_btn_SaveImage.Name = "ts_btn_SaveImage";
            this.ts_btn_SaveImage.Size = new System.Drawing.Size(87, 20);
            this.ts_btn_SaveImage.Text = "Save image";
            this.ts_btn_SaveImage.ToolTipText = "Save image preview";
            this.ts_btn_SaveImage.Click += new System.EventHandler(this.tSB_save_image_Click);
            // 
            // tSB_clear
            // 
            this.tSB_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tSB_clear.Image = ((System.Drawing.Image)(resources.GetObject("tSB_clear.Image")));
            this.tSB_clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSB_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_clear.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.tSB_clear.Name = "tSB_clear";
            this.tSB_clear.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tSB_clear.Size = new System.Drawing.Size(120, 21);
            this.tSB_clear.Text = "Reset to defaults";
            this.tSB_clear.ToolTipText = "Reset to defaults";
            this.tSB_clear.Click += new System.EventHandler(this.tSB_clear_Click);
            // 
            // toolStripBtnHelp
            // 
            this.toolStripBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnHelp.Image")));
            this.toolStripBtnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnHelp.Margin = new System.Windows.Forms.Padding(200, 1, 0, 2);
            this.toolStripBtnHelp.Name = "toolStripBtnHelp";
            this.toolStripBtnHelp.Size = new System.Drawing.Size(54, 19);
            this.toolStripBtnHelp.Text = "Help";
            this.toolStripBtnHelp.ToolTipText = "Help";
            this.toolStripBtnHelp.Click += new System.EventHandler(this.toolStripBtnHelp_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(123, 15);
            this.toolStripLabel1.Text = "Recognition language";
            // 
            // cb_language
            // 
            this.cb_language.DropDownWidth = 300;
            this.cb_language.Margin = new System.Windows.Forms.Padding(0);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(140, 23);
            this.cb_language.Text = "None";
            this.cb_language.ToolTipText = "Language";
            this.cb_language.SelectedIndexChanged += new System.EventHandler(this.cb_language_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(163, 15);
            this.toolStripLabel2.Text = "Structure detection algorithm";
            // 
            // toolStripComboBox_detectAreasMode
            // 
            this.toolStripComboBox_detectAreasMode.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripComboBox_detectAreasMode.Name = "toolStripComboBox_detectAreasMode";
            this.toolStripComboBox_detectAreasMode.Size = new System.Drawing.Size(140, 23);
            this.toolStripComboBox_detectAreasMode.ToolTipText = "DETECT AREAS MODE";
            this.toolStripComboBox_detectAreasMode.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_detectAreasMode_SelectedIndexChanged);
            // 
            // imageUploadDialog
            // 
            this.imageUploadDialog.FileName = "openFileDialog1";
            // 
            // imageToRecognize
            // 
            this.imageToRecognize.BackColor = System.Drawing.Color.White;
            this.imageToRecognize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageToRecognize.ImageLocation = "";
            this.imageToRecognize.Location = new System.Drawing.Point(5, 120);
            this.imageToRecognize.Margin = new System.Windows.Forms.Padding(3, 50, 3, 10);
            this.imageToRecognize.Name = "imageToRecognize";
            this.imageToRecognize.Size = new System.Drawing.Size(529, 665);
            this.imageToRecognize.TabIndex = 3;
            this.imageToRecognize.TabStop = false;
            this.imageToRecognize.Click += new System.EventHandler(this.tSB_open_Click);
            this.imageToRecognize.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop_1);
            this.imageToRecognize.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.BackColor = System.Drawing.SystemColors.Control;
            this.lblWait.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWait.Location = new System.Drawing.Point(678, 137);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(208, 45);
            this.lblWait.TabIndex = 5;
            this.lblWait.Text = "please wait ...";
            // 
            // uploadLicenseDialog1
            // 
            this.uploadLicenseDialog1.FileName = "openFileDialog1";
            // 
            // lbl_DragAndDrop
            // 
            this.lbl_DragAndDrop.AutoSize = true;
            this.lbl_DragAndDrop.BackColor = System.Drawing.Color.White;
            this.lbl_DragAndDrop.Location = new System.Drawing.Point(114, 252);
            this.lbl_DragAndDrop.MinimumSize = new System.Drawing.Size(100, 100);
            this.lbl_DragAndDrop.Name = "lbl_DragAndDrop";
            this.lbl_DragAndDrop.Size = new System.Drawing.Size(313, 100);
            this.lbl_DragAndDrop.TabIndex = 7;
            this.lbl_DragAndDrop.Text = "Drag image here or click Load image button in the toolbar";
            this.lbl_DragAndDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop_1);
            this.lbl_DragAndDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.lbl_DragAndDrop.DoubleClick += new System.EventHandler(this.tSB_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Preprocessing filters";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 100;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 91);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(952, 18);
            this.checkedListBox1.TabIndex = 10;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedLb_filters_SelectedIndexChanged);
            // 
            // btn_resetToOriginal
            // 
            this.btn_resetToOriginal.BackColor = System.Drawing.SystemColors.Control;
            this.btn_resetToOriginal.Location = new System.Drawing.Point(1029, 86);
            this.btn_resetToOriginal.Name = "btn_resetToOriginal";
            this.btn_resetToOriginal.Size = new System.Drawing.Size(47, 28);
            this.btn_resetToOriginal.TabIndex = 12;
            this.btn_resetToOriginal.Text = "Reset";
            this.btn_resetToOriginal.UseVisualStyleBackColor = false;
            this.btn_resetToOriginal.Click += new System.EventHandler(this.btn_resetToOriginal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(935, 770);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Skew angle";
            // 
            // lblResultSkew
            // 
            this.lblResultSkew.AutoSize = true;
            this.lblResultSkew.Location = new System.Drawing.Point(1042, 770);
            this.lblResultSkew.Name = "lblResultSkew";
            this.lblResultSkew.Size = new System.Drawing.Size(13, 15);
            this.lblResultSkew.TabIndex = 16;
            this.lblResultSkew.Text = "0";
            // 
            // richTextBox_Ethalon
            // 
            this.richTextBox_Ethalon.Location = new System.Drawing.Point(536, 490);
            this.richTextBox_Ethalon.Name = "richTextBox_Ethalon";
            this.richTextBox_Ethalon.ReadOnly = true;
            this.richTextBox_Ethalon.Size = new System.Drawing.Size(541, 277);
            this.richTextBox_Ethalon.TabIndex = 18;
            this.richTextBox_Ethalon.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 770);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Levenshtein distance to reference";
            // 
            // lbl_levenshtain
            // 
            this.lbl_levenshtain.AutoSize = true;
            this.lbl_levenshtain.Location = new System.Drawing.Point(861, 770);
            this.lbl_levenshtain.Name = "lbl_levenshtain";
            this.lbl_levenshtain.Size = new System.Drawing.Size(13, 15);
            this.lbl_levenshtain.TabIndex = 20;
            this.lbl_levenshtain.Text = "0";
            // 
            // btn_clearEthalon
            // 
            this.btn_clearEthalon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clearEthalon.BackgroundImage")));
            this.btn_clearEthalon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_clearEthalon.Location = new System.Drawing.Point(1, 1);
            this.btn_clearEthalon.Margin = new System.Windows.Forms.Padding(1);
            this.btn_clearEthalon.Name = "btn_clearEthalon";
            this.btn_clearEthalon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_clearEthalon.Size = new System.Drawing.Size(30, 20);
            this.btn_clearEthalon.TabIndex = 22;
            this.btn_clearEthalon.UseVisualStyleBackColor = true;
            this.btn_clearEthalon.Click += new System.EventHandler(this.btn_clearEthalon_Click);
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(722, 2);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(0, 15);
            this.lblLicense.TabIndex = 23;
            // 
            // btn_preprocess
            // 
            this.btn_preprocess.BackColor = System.Drawing.SystemColors.Control;
            this.btn_preprocess.Location = new System.Drawing.Point(952, 86);
            this.btn_preprocess.Name = "btn_preprocess";
            this.btn_preprocess.Size = new System.Drawing.Size(75, 26);
            this.btn_preprocess.TabIndex = 24;
            this.btn_preprocess.Text = "Preprocess";
            this.btn_preprocess.UseVisualStyleBackColor = false;
            this.btn_preprocess.Click += new System.EventHandler(this.btn_preprocess_Click);
            // 
            // pB_uploadIco
            // 
            this.pB_uploadIco.BackColor = System.Drawing.Color.White;
            this.pB_uploadIco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pB_uploadIco.BackgroundImage")));
            this.pB_uploadIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_uploadIco.Location = new System.Drawing.Point(221, 286);
            this.pB_uploadIco.Name = "pB_uploadIco";
            this.pB_uploadIco.Size = new System.Drawing.Size(65, 50);
            this.pB_uploadIco.TabIndex = 25;
            this.pB_uploadIco.TabStop = false;
            this.pB_uploadIco.DoubleClick += new System.EventHandler(this.tSB_open_Click);
            // 
            // lbl_license
            // 
            this.lbl_license.Location = new System.Drawing.Point(550, 770);
            this.lbl_license.MaximumSize = new System.Drawing.Size(300, 20);
            this.lbl_license.Name = "lbl_license";
            this.lbl_license.Size = new System.Drawing.Size(73, 15);
            this.lbl_license.TabIndex = 26;
            this.lbl_license.Text = "Unlicensed";
            // 
            // uploadTxtDialog
            // 
            this.uploadTxtDialog.FileName = "openFileDialog1";
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(550, 194);
            this.lblLogs.MaximumSize = new System.Drawing.Size(400, 250);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(0, 15);
            this.lblLogs.TabIndex = 28;
            // 
            // panel_refText
            // 
            this.panel_refText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_refText.Controls.Add(this.btn_clearEthalon);
            this.panel_refText.Controls.Add(this.label4);
            this.panel_refText.Location = new System.Drawing.Point(536, 469);
            this.panel_refText.Name = "panel_refText";
            this.panel_refText.Size = new System.Drawing.Size(541, 22);
            this.panel_refText.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Reference text";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1077, 794);
            this.Controls.Add(this.panel_refText);
            this.Controls.Add(this.lblLogs);
            this.Controls.Add(this.lbl_license);
            this.Controls.Add(this.pB_uploadIco);
            this.Controls.Add(this.btn_preprocess);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lbl_levenshtain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_Ethalon);
            this.Controls.Add(this.lblResultSkew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_resetToOriginal);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DragAndDrop);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.imageToRecognize);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Aspose.OCR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageToRecognize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_uploadIco)).EndInit();
            this.panel_refText.ResumeLayout(false);
            this.panel_refText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_open;
        private System.Windows.Forms.ToolStripButton tSB_clear;
        private System.Windows.Forms.OpenFileDialog imageUploadDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton tSB_save_result;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripComboBox cb_language;
        private System.Windows.Forms.PictureBox imageToRecognize;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.OpenFileDialog uploadLicenseDialog1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_detectAreasMode;
        private System.Windows.Forms.Label lbl_DragAndDrop;
        private System.Windows.Forms.ToolStripButton ts_btn_SaveImage;
    //    private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_resetToOriginal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultSkew;
        private System.Windows.Forms.RichTextBox richTextBox_Ethalon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_levenshtain;
        private System.Windows.Forms.Button btn_clearEthalon;
        private System.Windows.Forms.ToolStripButton toolStripBtnUploadLic;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.ToolStripButton toolStripBtnUploadEthalon;
        private System.Windows.Forms.ToolStripButton toolStripBtnHelp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_preprocess;
        private System.Windows.Forms.PictureBox pB_uploadIco;
        private System.Windows.Forms.Label lbl_license;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog uploadTxtDialog;
        private System.Windows.Forms.ToolStripButton toolStripBtnRecognize;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.FlowLayoutPanel panel_refText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

