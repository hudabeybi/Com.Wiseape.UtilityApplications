using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    public partial class FormSavePath : Form
    {

        public string Path { get { return txtPath.Text; } set { txtPath.Text = value; } }
        public bool Canceled { get; set; }

        public bool GenerateAllModule {
            get {
                return this.chkGenerateAllModule.Checked;
            }
            set {
                this.chkGenerateAllModule.Checked = value;
            }
        }

        public FormSavePath()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Canceled = true;
            this.Close();
        }

        private void FormSavePath_Load(object sender, EventArgs e)
        {
            string filename = "lastpath.txt";
            filename = System.IO.Directory.GetCurrentDirectory() + "/" + filename;
            if(System.IO.File.Exists(filename))
            {
                string content = System.IO.File.ReadAllText(filename);
                Path = content;
            }
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.SelectedPath = txtPath.Text;
            DialogResult result = fd.ShowDialog();
            if(result == DialogResult.OK)
            {
                Path = fd.SelectedPath;
                SaveFile();
            }
        }

        void SaveFile()
        {
            string filename = "lastpath.txt";
            filename = System.IO.Directory.GetCurrentDirectory() + "/" + filename;
            System.IO.File.WriteAllText(filename, Path);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
