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
using System.Collections;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    public partial class ComboboxConfigurator : UserControl, IConfigContent
    {
        public ComboboxConfigurator()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("Placeholder", txtPlaceholder.Text);
            result.Add("DefaultValue", txtDefaultValue.Text);
            List<ItemOption> options = new List<ItemOption>();
            foreach(DataGridViewRow row in gridOptions.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string value = Convert.ToString(row.Cells[0].Value);
                    string text = Convert.ToString(row.Cells[1].Value);
                    ItemOption item = new ItemOption(value, text);
                    options.Add(item);
                }

            }
            result.Add("Options", options);
            return result;
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            txtPlaceholder.Text = Convert.ToString(configs["Placeholder"]);
            txtDefaultValue.Text = Convert.ToString(configs["DefaultValue"]);
            List<ItemOption> options = null;

            if(configs["Options"].GetType() == typeof(ArrayList))
            {
                ArrayList list = (ArrayList)configs["Options"];
                options = new List<ItemOption>();
                foreach(Dictionary<string, object> opt in list)
                {
                    options.Add(new ItemOption(opt["Value"].ToString(), opt["Text"].ToString() ));
                }
            }
            else
                options = (List<ItemOption>)configs["Options"];

            gridOptions.DataSource = options;
        }

        public string GetControlType()
        {
            return ControlType.Combobox.ToString();
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            txtPlaceholder.Text = "Please, select " + column.ColumnText;
        }

        private void ComboboxConfigrator_Load(object sender, EventArgs e)
        {

        }
    }
}
