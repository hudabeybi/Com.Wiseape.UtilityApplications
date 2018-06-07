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
                this.grpBox.Controls.Add(value);
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
    }
}
