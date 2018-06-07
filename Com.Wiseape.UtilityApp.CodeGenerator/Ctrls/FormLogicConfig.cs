using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    public partial class FormLogicConfig : Form
    {

        public bool IsCanceled { get; set; }

        public IConfigContent ConfigContent
        {
            set
            {
                this.panelFunctionConfig.Controls.Add((UserControl)value);
                this.ConfigContent.DisplayConfiguration(this.ConfigContent.Configure());
            }
            get
            {
                return (IConfigContent)this.panelFunctionConfig.Controls[0];
            }
        }

        public FormLogicConfig()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.IsCanceled = false;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.IsCanceled = true;
            this.Close();
        }

        private void FormLogicConfig_Load(object sender, EventArgs e)
        {
           
        }
    }
}
