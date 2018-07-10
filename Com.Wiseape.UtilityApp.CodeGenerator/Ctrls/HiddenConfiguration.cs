using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    public partial class HiddenConfiguration : TextboxConfiguration, IConfigContent
    {
        public HiddenConfiguration()
        {
            InitializeComponent();
        }

        private void HiddenConfiguration_Load(object sender, EventArgs e)
        {

        }

        public override string GetControlType()
        {
            return ControlType.Hidden.ToString();
        }
    }
}
