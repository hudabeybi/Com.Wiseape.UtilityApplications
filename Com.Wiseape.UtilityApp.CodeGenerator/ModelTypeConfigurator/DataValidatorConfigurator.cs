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
using Com.Wiseape.UtilityApp.CodeGenerator.Ctrls;
using System.Text.RegularExpressions;

namespace Com.Wiseape.UtilityApp.CodeGenerator.ModelTypeConfigurator
{
    public partial class DataValidatorConfigurator : UserControl, IAssemblyNameGenerator, IModelTypeConfigurator
    {
        public DataValidatorConfigurator()
        {
            InitializeComponent();
        }

        DataSourceTable CurrentTable = null;
        public void InitFromDatasource(DataSourceTable table)
        {
            gridColumns.AutoGenerateColumns = false;
            DataSourceValidationTable newTable = Copy(table);
            gridColumns.DataSource = newTable.DataColumns.ConvertAll(c => c as ValidatorColumn);
            CurrentTable = newTable;
        }

        protected DataSourceValidationTable Copy(DataSourceTable table)
        {
            DataSourceValidationTable newTable = new DataSourceValidationTable();
            newTable.TableName = table.TableName;
            newTable.TableSchema = table.TableSchema;

            foreach(Model.DataColumn col in table.DataColumns)
            {
                Model.ValidatorColumn validatorCol = new ValidatorColumn();
                validatorCol.ColumnName = col.ColumnName;

                string[] words = Regex.Matches(validatorCol.ColumnName, "(^[a-z]+|[A-Z]+(?![a-z])|[A-Z][a-z]+)")
                .OfType<Match>()
                .Select(m => m.Value)
                .ToArray();
                string result = string.Join(" ", words);

                validatorCol.ColumnText = result;
                validatorCol.DataType = col.DataType;
                validatorCol.Key = col.Key;
                validatorCol.Use = col.Use;
                validatorCol.Size = col.Size;
                validatorCol.ConfigContent = new ValidationIsEmpty();
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("InvalidMessage", "Please fill " + result);
                validatorCol.ConfigContent.DisplayConfiguration(dict);
                validatorCol.ValidationTypeList.Add(new ModelItemType(validatorCol.ConfigContent.GetControlType(), validatorCol.ConfigContent));
                newTable.DataColumns.Add(validatorCol);
            }

            return newTable;
        }

        public string GenerateClassName(string projectName, string moduleName, string tableName)
        {
            string name = "Com.Wiseape." + projectName + "." + moduleName + ".View.Service." + tableName;
            return name;
        }

        public string GenerateNamespace(string projectName, string moduleName, string tableName)
        {
            string name = "Com.Wiseape." + projectName + "." + moduleName + ".View.Service";
            return name;
        }

        private void DataValidatorConfigurator_Load(object sender, EventArgs e)
        {

        }

        private void gridColumns_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridColumns.Columns[e.ColumnIndex].Name == "ColValidationConfig")
            {
                ValidatorColumn validator = (ValidatorColumn)gridColumns.Rows[e.RowIndex].DataBoundItem;

                FormValidatorConfig frm = new FormValidatorConfig();
                frm.DataColumn = validator;
                frm.ConfigContent = validator.ConfigContent;
                frm.ShowDialog();
                if(frm.IsCanceled == false)
                {

                    validator.ConfigContent = frm.ConfigContent;
                }
            }
        }

        public void UpdateDatasource(object table)
        {
            //At first it will load from Json and Json will be serialized into DataColumns as DataColumn item, not UIColumn item as expected. That is why we need
            //DataColumns2, to store its UIColumn list, and copy it to DataColumns
            if (table.GetType() != typeof(DataSourceValidationTable))
            {
                string json = Utility.Serializer.Json.Serialize(table);
                json = json.Replace("DataColumns", "DataColumns2");
                //json = json.Replace("DataColumns22", "DataColumns2");
                DataSourceValidationTable tbl = Utility.Serializer.Json.Deserialize<DataSourceValidationTable>(json);
                foreach (ValidatorColumn col in tbl.DataColumns2)
                {
                    tbl.DataColumns.Add(col);
                }
                CurrentTable = tbl;
            }
            else
            {
                CurrentTable = (DataSourceValidationTable)table;
            }
            gridColumns.AutoGenerateColumns = false;
            gridColumns.DataSource = CurrentTable.DataColumns.ConvertAll(c => c as ValidatorColumn);
        }

        public DataSourceTable GetDatasource()
        {
            return CurrentTable;
        }

        private void gridColumns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataValidatorConfigurator_Resize(object sender, EventArgs e)
        {
            gridColumns.Width = this.Width - 10;
            gridColumns.Height = this.Height - 5;
        }
    }
}
