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
    public partial class ValidationStringMinMaxLength : UserControl, IConfigContent
    {
        public ValidationStringMinMaxLength()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> configs = new Dictionary<string, object>();
            configs.Add("MinLength", txtMinStringLength.Text);
            configs.Add("MaxLength", txtMaxStringLength.Text);
            configs.Add("InvalidMessage", txtValidationMessage.Text);
            return configs;
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            txtMaxStringLength.Text = Convert.ToString(configs["MaxLength"]);
            txtMinStringLength.Text = Convert.ToString(configs["MinLength"]);
            txtValidationMessage.Text = Convert.ToString(configs["InvalidMessage"]);
        }

        public string GetControlType()
        {
            return "String Length Validation";
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            txtValidationMessage.Text = column.ColumnText + "must be between {MinLength} and {MaxLength} length";
        }

        private void ValidationStringMinMaxLength_Load(object sender, EventArgs e)
        {

        }
    }
}
