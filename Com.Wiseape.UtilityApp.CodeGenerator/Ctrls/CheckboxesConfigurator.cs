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
    public partial class CheckboxesConfigurator : UserControl, IConfigContent
    {
        public CheckboxesConfigurator()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("DefaultValue", txtDefaultValue.Text);
            List<ItemOption> options = new List<ItemOption>();
            foreach (DataGridViewRow row in gridOptions.Rows)
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
            txtDefaultValue.Text = Convert.ToString(configs["DefaultValue"]);
            List<ItemOption> options = new List<ItemOption>();

            if (configs["Options"].GetType() == typeof(ArrayList))
            {
                ArrayList list = (ArrayList)configs["Options"];
                foreach (Dictionary<string, object> item in list)
                {
                    ItemOption newItem = new ItemOption(item["Value"].ToString(), item["Text"].ToString());
                    options.Add(newItem);
                }
            }
            else
            {
                options = (List<ItemOption>)configs["Options"];
            }

            DisplayOptions(options);
             //gridOptions.DataSource = options;
        }

        void DisplayOptions(List<ItemOption> options)
        {
            gridOptions.Rows.Clear();
            foreach(ItemOption item in options)
            {
                gridOptions.Rows.Add(new object[] { item.Value, item.Text });
            }
        }

        public string GetControlType()
        {
            return ControlType.Checkboxes.ToString();
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            
        }

        private void CheckboxesConfigurator_Load(object sender, EventArgs e)
        {

        }
    }
}
