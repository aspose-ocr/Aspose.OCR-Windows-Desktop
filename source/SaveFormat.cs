using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspose.OCR.Example
{
    public partial class SaveFormatForm : Form
    {
        public static SaveFormat saveFormat = SaveFormat.Text;
        public static bool isNeedToSave = false;
        public SaveFormatForm()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            string format = (((RadioButton)sender).Text);
            if(format == "Plain PDF")
            {
                format = "PdfNoImg";
            }
            saveFormat =  (SaveFormat)Enum.Parse(typeof(Aspose.OCR.SaveFormat), format);
        }

        private void btnSaveFormat_Click(object sender, EventArgs e)
        {
            isNeedToSave = true;
            this.Close();
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            isNeedToSave = false;
            this.Close();
        }
    }
}
