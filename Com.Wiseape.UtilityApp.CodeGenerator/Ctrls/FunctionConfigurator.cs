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
    public partial class FunctionConfigurator : UserControl, IConfigContent
    {
        public FunctionConfigurator()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> configs = new Dictionary<string, object>();
            configs.Add("Parameters", GetParameters());
            return configs;
        }

        List<FunctionParameter> GetParameters()
        {
            List<FunctionParameter> parameters = new List<FunctionParameter>();
            foreach (DataGridViewRow row in gridParameters.Rows)
            {
                if(row.Cells["ColParameterType"].Value != null)
                {
                    FunctionParameter parameter = new FunctionParameter();
                    parameter.ParameterName = Convert.ToString(row.Cells["ColVariableName"].Value);
                    parameter.ParameterType = Convert.ToString(row.Cells["ColParameterType"].Value);
                    if(row.Tag != null)
                        parameter.DataColumn = (Model.DataColumn)row.Tag;
                    parameters.Add(parameter);
                }
            }
            return parameters;
        }

        void SetParameters(List<FunctionParameter> parameters)
        {
            gridParameters.Rows.Clear();
            foreach(FunctionParameter param in parameters)
            {
                int rowIdx = gridParameters.Rows.Add(new object[] { param.ParameterType, param.ParameterName });
                gridParameters.Rows[rowIdx].Tag = param.DataColumn;
            }
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            try
            {
                SetParameters((List<FunctionParameter>)configs["Parameters"]);
            }
            catch
            {
                //The effin json does not converted to List<FunctionParameter>, so we need to handle this shit.
                string json = Utility.Serializer.Json.Serialize(configs["Parameters"]);
                List<FunctionParameter> parameters = Utility.Serializer.Json.Deserialize<List<FunctionParameter>>(json);
                SetParameters(parameters);
            }
        }

        public string GetControlType()
        {
            return "FunctionConfigurator";
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            
        }

        private void FunctionConfigurator_Load(object sender, EventArgs e)
        {

        }

        private void gridParameters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
