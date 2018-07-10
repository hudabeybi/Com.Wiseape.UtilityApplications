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
    public partial class NumericboxConfiguration : UserControl, IConfigContent
    {
        public NumericboxConfiguration()
        {
            InitializeComponent();
        }
        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("Placeholder", txtPlaceholder.Text);
            result.Add("DefaultValue", txtDefaultValue.Text);
            result.Add("IsDigitGrouping", chkDigitGrouping.Checked);
            return result;
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            txtDefaultValue.Text = Convert.ToString(configs["DefaultValue"]);
            txtPlaceholder.Text = Convert.ToString(configs["Placeholder"]);
            chkDigitGrouping.Checked = Convert.ToBoolean(configs["IsDigitGrouping"]);
        }

        public string GetControlType()
        {
            return ControlType.Numericbox.ToString();
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            txtPlaceholder.Text = "Please, fill " + column.ColumnText;
        }

        private void NumericboxConfiguration_Load(object sender, EventArgs e)
        {

        }
    }
}
