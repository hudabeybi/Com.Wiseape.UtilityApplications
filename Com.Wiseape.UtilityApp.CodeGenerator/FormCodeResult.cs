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
    public partial class FormCodeResult : Form
    {

        public string Result
        {
            get
            {
                return txtResult.Text;
            }
            set {

                string filename = System.IO.Directory.GetCurrentDirectory() + "/temp.cs";
                System.IO.File.WriteAllText(filename, value);
                txtResult.LoadFile(filename);

            }
        }
        public FormCodeResult()
        {
            InitializeComponent();
        }

        private void FormCodeResult_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCodeResult_Resize(object sender, EventArgs e)
        {
            btnClose.Left = this.Width - btnClose.Width - 10;
            txtResult.Width = this.Width - btnClose.Left - 10;
            txtResult.Height = this.Height - txtResult.Top - 20;
        } 
    }
}
