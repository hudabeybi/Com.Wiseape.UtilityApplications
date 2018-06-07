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
    public partial class LookupRadiobuttonsConfigurator : UserControl, IConfigContent
    {
        public LookupRadiobuttonsConfigurator()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("DefaultValue", txtDefaultValue.Text);
            result.Add("DataSource", txtDataProvider.Text);
            result.Add("ValueMember", txtValueMember.Text);
            result.Add("DisplayMember", txtDisplayMember.Text);
            result.Add("DataModel", txtDataModel.Text);
            return result;
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            txtDefaultValue.Text = Convert.ToString(configs["DefaultValue"]);
            txtDataProvider.Text = Convert.ToString(configs["DataSource"]);
            txtValueMember.Text = Convert.ToString(configs["ValueMember"]);
            txtDisplayMember.Text = Convert.ToString(configs["DisplayMember"]);
            txtDataModel.Text = Convert.ToString(configs["DataModel"]);
        }

        public string GetControlType()
        {
            return "LookupRadiobuttons";
        }

        public void InitConfiguration(Model.DataColumn column)
        {
        }

        private void LookupRadiobuttonsConfigurator_Load(object sender, EventArgs e)
        {

        }
    }
}
