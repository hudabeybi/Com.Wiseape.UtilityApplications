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
    public partial class ValidationIsEmpty : UserControl, IConfigContent
    {
        public ValidationIsEmpty()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> configs = new Dictionary<string, object>();
            configs.Add("InvalidMessage", txtValidationMessage.Text);
            return configs;
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            txtValidationMessage.Text = Convert.ToString(configs["InvalidMessage"]);
        }

        public string GetControlType()
        {
            return "Is Empty Validator";
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            txtValidationMessage.Text = column.ColumnText + "can not be empty";
        }

        private void ValidationIsEmpty_Load(object sender, EventArgs e)
        {

        }
    }
}
