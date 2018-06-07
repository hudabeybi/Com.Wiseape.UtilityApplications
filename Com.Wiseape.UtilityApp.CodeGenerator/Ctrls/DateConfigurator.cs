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
    public partial class DateConfigurator : UserControl, IConfigContent
    {
        public DateConfigurator()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("Placeholder", txtPlaceholder.Text);
            result.Add("DateFormat", txtDateFormat.Text);
            result.Add("IsWithTime", chkWithTime.Checked);
            return result;
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            txtDateFormat.Text = Convert.ToString(configs["DateFormat"]);
            txtPlaceholder.Text = Convert.ToString(configs["Placeholder"]);
            chkWithTime.Checked  = Convert.ToBoolean(configs["IsWithTime"]);
        }

        public string GetControlType()
        {
            return "Date";
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            txtPlaceholder.Text = "Please, select " + column.ColumnText;
        }

        private void DateConfigurator_Load(object sender, EventArgs e)
        {

        }
    }
}
