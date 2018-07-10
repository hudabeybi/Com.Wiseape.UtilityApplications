using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public partial class FormElementConfiguration : Form
    {
        public bool IsCancel { get; set; }
        public UserControl PropertyConfigurator
        {
            set
            {
                this.grpBox.Controls.Clear();
                value.Top = 10;
                value.Left = 10;
                this.grpBox.Controls.Add(value);
                this.grpBox.Width = value.Width + 20;
                this.grpBox.Height = value.Height + 20;
                this.Width = this.grpBox.Width + 40;
                this.Height = this.grpBox.Height + 120;
                btnOk.Top = this.Height - 90;
                

                btnCancel.Top = this.Height - 90;
                btnCancel.Left = this.Width - btnCancel.Width - 60;
                btnOk.Left = btnCancel.Left - btnOk.Width;

                this.Text = "Element Configuration - " + ((CommonPropertyConfigurator)value).PropertyPage.GetElementName();
            }
            get
            {
                return (UserControl)this.grpBox.Controls[0];
            }
        }
        public FormElementConfiguration()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IsCancel = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsCancel = true;
            this.Close();
        }

        private void FormElementConfiguration_Load(object sender, EventArgs e)
        {

        }
    }
}
