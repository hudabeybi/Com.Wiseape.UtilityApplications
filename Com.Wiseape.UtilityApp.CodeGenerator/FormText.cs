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
    public partial class FormText : Form
    {
        public FormText()
        {
            InitializeComponent();
        }

        private void FormText_Load(object sender, EventArgs e)
        {

        }

        public void ShowDialog(string text)
        {
            this.txtDisplay.Text = text;
            this.ShowDialog();
        }

        public string GetText()
        {
            return txtDisplay.Text;
        }
    }
}
