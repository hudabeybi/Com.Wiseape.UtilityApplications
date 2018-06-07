using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;

namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    public partial class FormAddCodeTemplate : Form
    {

        public bool IsCanceled { get; set; }
        public CodeTemplate CodeTemplate {
            set;
            get;
        }
        public FormAddCodeTemplate()
        {
            InitializeComponent();
        }

        private void FormAddCodeTemplate_Load(object sender, EventArgs e)
        {
            IsCanceled = true;
            if(this.CodeTemplate != null)
            {
                txtTemplateName.Text = this.CodeTemplate.TemplateName;
                txtDefaultFilename.Text = this.CodeTemplate.DefaultFilename;
                string code = CodeTemplate.TemplateCodePlain;
                string filename = SaveTemporaryCode(code);
                txtCode.LoadFile(filename);
            }
        }

        string SaveTemporaryCode(string code)
        {
            string filename = System.IO.Directory.GetCurrentDirectory() + "/temp.aspx";
            System.IO.File.WriteAllText(filename, code);
            return filename;
        }

        private void btnOke_Click(object sender, EventArgs e)
        {
           
            this.CodeTemplate = new CodeTemplate(txtTemplateName.Text, Utility.StringUtility.Base64Encode(txtCode.Text));
            this.CodeTemplate.DefaultFilename = txtDefaultFilename.Text;
            this.IsCanceled = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CodeTemplate = null;
            this.IsCanceled = true;
            this.Close();
        }

        private void FormAddCodeTemplate_Resize(object sender, EventArgs e)
        {
            txtCode.Width = this.Width - 100;
            txtCode.Height = this.Height - this.Top - 100;
        }
    }
}
