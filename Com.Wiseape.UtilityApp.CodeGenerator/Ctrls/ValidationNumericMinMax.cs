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
    public partial class ValidationNumericMinMax : UserControl, IConfigContent
    {
        public ValidationNumericMinMax()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> configs = new Dictionary<string, object>();
            configs.Add("MinNumber", txtMinNumber.Text);
            configs.Add("MaxNumber", txtMaxNumber.Text);
            configs.Add("InvalidMessage", txtValidationMessage.Text);
            return configs;
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            txtMaxNumber.Text = Convert.ToString( configs["MaxNumber"]);
            txtMinNumber.Text = Convert.ToString(configs["MinNumber"]);
            txtValidationMessage.Text = Convert.ToString(configs["InvalidMessage"]);
        }

        public string GetControlType()
        {
            return "Numeric Validator";
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            txtValidationMessage.Text = "Please, fill number between {MinNumber} and {MaxNumber}";
        }

        private void ValidationNumericMinMax_Load(object sender, EventArgs e)
        {

        }
    }
}
