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
using System.Text.RegularExpressions;
using Com.Wiseape.UtilityApp.CodeGenerator.Ctrls;

namespace Com.Wiseape.UtilityApp.CodeGenerator.ModelTypeConfigurator
{
    public partial class LogicConfiguratorModelType : UserControl, IAssemblyNameGenerator, IModelTypeConfigurator
    {
        DataSourceTable CurrentTable;
        public LogicConfiguratorModelType()
        {
            InitializeComponent();
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

        public DataSourceTable GetDatasource()
        {
            return CurrentTable;
        }

        public void InitFromDatasource(DataSourceTable table)
        {
            gridColumns.AutoGenerateColumns = false;
            DataSourceLogicTable newTable = Copy(table);
            gridColumns.DataSource = newTable.DataColumns.ConvertAll(c => c as LogicColumn);
            CurrentTable = newTable;
        }

        public void UpdateDatasource(object table)
        {
            //At first it will load from Json and Json will be serialized into DataColumns as DataColumn item, not UIColumn item as expected. That is why we need
            //DataColumns2, to store its UIColumn list, and copy it to DataColumns
            if (table.GetType() != typeof(DataSourceLogicTable))
            {
                string json = Utility.Serializer.Json.Serialize(table);
                json = json.Replace("DataColumns", "DataColumns2");
                //json = json.Replace("DataColumns22", "DataColumns2");
                DataSourceLogicTable tbl = Utility.Serializer.Json.Deserialize<DataSourceLogicTable>(json);
                foreach (LogicColumn col in tbl.DataColumns2)
                {
                    //col.ControlConfigurations = 
                    tbl.DataColumns.Add(col);
                }
                CurrentTable = tbl;
            }
            else
            {
                CurrentTable = (DataSourceLogicTable)table;
            }

            gridColumns.AutoGenerateColumns = false;
            //gridColumns.DataSource = tbl.DataColumns;
            gridColumns.DataSource = CurrentTable.DataColumns.ConvertAll(c => c as LogicColumn);
        }

        private void gridColumns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected DataSourceLogicTable Copy(DataSourceTable table)
        {
            DataSourceLogicTable newTable = new DataSourceLogicTable();
            newTable.TableName = table.TableName;
            newTable.TableSchema = table.TableSchema;
            AddDefaultFunctions(table, newTable);
            //AddDefaultFunctionsAgain(table, newTable);
            return newTable;
        }

        void AddDefaultFunctions(DataSourceTable table, DataSourceLogicTable newTable)
        {
            foreach (Model.DataColumn col in table.DataColumns)
            {
                LogicColumn logicColumn = null;
                if (col.DataType.ToLower().Contains("int") == false)
                {
                    logicColumn = CreateDefaultFindAllLogicColumn(table, col, newTable);
                    newTable.DataColumns.Add(logicColumn);
                }
                if (col.DataType.ToLower().Contains("int") == false)
                {
                    logicColumn = CreateDefaultUpdateLogicColumn(table, col, newTable);
                    newTable.DataColumns.Add(logicColumn);
                }
                if (col.DataType.ToLower().Contains("int") == false)
                {
                    logicColumn = CreateDefaultDeleteLogicColumn(table, col, newTable);
                    newTable.DataColumns.Add(logicColumn);
                }
            }

            Test(table, newTable, null);
        }

        LogicColumn CreateDefaultFindAllLogicColumn(Model.DataSourceTable sourceTable, Model.DataColumn col, DataSourceLogicTable newTable)
        {
            Model.LogicColumn logicColumn = new Model.LogicColumn();
            logicColumn.ColumnName = col.ColumnName;
            logicColumn.ColumnText = col.ColumnText;
            logicColumn.ReturnType = "List<" + newTable.TableName + ">";

            logicColumn.Use = true;
            List<FunctionParameter> parameters = new List<FunctionParameter>();

            if (col.DataType.ToLower().Contains("date"))
            {
                logicColumn.Tag = "list-date";
                logicColumn.FunctionName = "FindBy" + logicColumn.ColumnName + "Between";
                string dtType = Helper.DatabaseMapper.MapType(col.DataType);
                string varName1 = Helper.StrUtil.LowFirst(col.ColumnName) + "1";
                string varName2 = Helper.StrUtil.LowFirst(col.ColumnName) + "2";
                parameters.Add(new FunctionParameter(varName1, dtType, col));
                parameters.Add(new FunctionParameter(varName2, dtType, col));
            }
            else
            {
                logicColumn.Tag = "list-string";
                logicColumn.FunctionName = "FindBy" + logicColumn.ColumnName;
                string dtType = Helper.DatabaseMapper.MapType(col.DataType);
                string varName = Helper.StrUtil.LowFirst(col.ColumnName);
                parameters.Add(new FunctionParameter(varName, dtType, col));
            }


            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Parameters", parameters);

            logicColumn.ConfigContent = new FunctionConfigurator();
            logicColumn.ConfigContent.DisplayConfiguration(dict);

            return logicColumn;
        }


        LogicColumn CreateDefaultUpdateLogicColumn(Model.DataSourceTable sourceTable, Model.DataColumn col, DataSourceLogicTable newTable)
        {
            Model.LogicColumn logicColumn = new Model.LogicColumn();
            logicColumn.ColumnName = col.ColumnName;
            logicColumn.ColumnText = col.ColumnText;
            logicColumn.ReturnType = "void";

            logicColumn.Use = true;
            List<FunctionParameter> parameters = new List<FunctionParameter>();
            
            logicColumn.Tag = "update-by-primarykey";
            logicColumn.FunctionName = "Update" + logicColumn.ColumnName;
            string dtType = Helper.DatabaseMapper.MapType(col.DataType);
            string varName = Helper.StrUtil.LowFirst(col.ColumnName);
            parameters.Add(new FunctionParameter(Helper.StrUtil.LowFirst(sourceTable.KeyColumn.ColumnName), Helper.DatabaseMapper.MapType(sourceTable.KeyColumn.DataType), sourceTable.KeyColumn));
            parameters.Add(new FunctionParameter(varName, dtType, col));

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Parameters", parameters);

            logicColumn.ConfigContent = new FunctionConfigurator();
            logicColumn.ConfigContent.DisplayConfiguration(dict);

            return logicColumn;
        }

        LogicColumn CreateDefaultDeleteLogicColumn(Model.DataSourceTable sourceTable, Model.DataColumn col, DataSourceLogicTable newTable)
        {
            Model.LogicColumn logicColumn = new Model.LogicColumn();
            logicColumn.ColumnName = col.ColumnName;
            logicColumn.ColumnText = col.ColumnText;
            logicColumn.ReturnType = "void";

            logicColumn.Use = true;
            List<FunctionParameter> parameters = new List<FunctionParameter>();

            logicColumn.Tag = "delete-by-column";
            logicColumn.FunctionName = "DeleteBy" + logicColumn.ColumnName;
            string dtType = Helper.DatabaseMapper.MapType(col.DataType);
            string varName = Helper.StrUtil.LowFirst(col.ColumnName);
            parameters.Add(new FunctionParameter(varName, dtType, col));

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Parameters", parameters);

            logicColumn.ConfigContent = new FunctionConfigurator();
            logicColumn.ConfigContent.DisplayConfiguration(dict);

            return logicColumn;
        }


        bool Exists(DataSourceLogicTable table, LogicColumn col)
        {
            foreach(LogicColumn col2 in table.DataColumns)
            {
                if (col.FunctionName == col2.ColumnName)
                    return true;
            }
            return false;
        }

        void Test(DataSourceTable tbl, DataSourceLogicTable newTable, List<Model.DataColumn> cols)
        {
            
            bool start = false;
            if (cols == null)
                cols = new List<Model.DataColumn>();

            foreach(Model.DataColumn col in tbl.DataColumns)
            {
                if (start && col.DataType.ToLower().Contains("int"))
                {
                    cols.Add(col);
                    LogicColumn newColumn = CreateNewFindLogicColumn(tbl, newTable, cols);
                    if(Exists(newTable, newColumn) == false)
                        newTable.DataColumns.Add(newColumn);
                    newColumn = CreateNewUpdateLogicColumn(tbl, newTable, cols);
                    if (Exists(newTable, newColumn) == false)
                        newTable.DataColumns.Add(newColumn);
                    newColumn = CreateNewDeleteLogicColumn(tbl, newTable, cols);
                    if (Exists(newTable, newColumn) == false)
                        newTable.DataColumns.Add(newColumn);

                    List<Model.DataColumn> tempCols = new List<Model.DataColumn>();
                    tempCols = tempCols.Concat(cols).ToList();

                    Test(tbl, newTable, tempCols);
                    cols.Remove(col);
                }
                if (cols.Count == 0)
                    start = true;
                if (cols.Count > 0 && col.ColumnName == cols[cols.Count - 1].ColumnName)
                    start = true;

            }
        }

        LogicColumn CreateNewFindLogicColumn(DataSourceTable table, DataSourceLogicTable newTable, List<Model.DataColumn> datacols)
        {
            Model.LogicColumn logicColumn = new Model.LogicColumn();
            logicColumn.ReturnType = "List<" + newTable.TableName + ">";
            logicColumn.Tag = "list-int-and-int";
            logicColumn.Use = true;
            logicColumn.FunctionName = "FindBy";

            List<FunctionParameter> parameters = new List<FunctionParameter>();
            foreach (Model.DataColumn col in datacols)
            {
                logicColumn.FunctionName += col.ColumnName + "And";
                string dtType = Helper.DatabaseMapper.MapType(col.DataType);
                string varName1 = Helper.StrUtil.LowFirst(col.ColumnName) + "";
                parameters.Add(new FunctionParameter(varName1, dtType, col));
            }

            if (logicColumn.FunctionName.Length > 0)
                logicColumn.FunctionName = logicColumn.FunctionName.Substring(0, logicColumn.FunctionName.Length - 3);


            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Parameters", parameters);

            logicColumn.ConfigContent = new FunctionConfigurator();
            logicColumn.ConfigContent.DisplayConfiguration(dict);

            return logicColumn;

        }

        LogicColumn CreateNewUpdateLogicColumn (DataSourceTable table, DataSourceLogicTable newTable, List<Model.DataColumn> datacols)
        {
            Model.LogicColumn logicColumn = new Model.LogicColumn();
            logicColumn.ReturnType = "void";
            logicColumn.Tag = "update-int-and-int";
            logicColumn.Use = true;
            logicColumn.FunctionName = "Update";

            List<FunctionParameter> parameters = new List<FunctionParameter>();
            string pkColName = table.KeyColumn.ColumnName;
            string keyVar = Helper.StrUtil.LowFirst(pkColName);
            string varType = Helper.DatabaseMapper.MapType(table.KeyColumn.DataType);
            parameters.Add(new FunctionParameter(keyVar, varType, table.KeyColumn));
            foreach (Model.DataColumn col in datacols)
            {
                logicColumn.FunctionName += col.ColumnName + "And";
                string dtType = Helper.DatabaseMapper.MapType(col.DataType);
                string varName1 = Helper.StrUtil.LowFirst(col.ColumnName) + "";
                parameters.Add(new FunctionParameter(varName1, dtType, col));
            }

            if (logicColumn.FunctionName.Length > 0)
                logicColumn.FunctionName = logicColumn.FunctionName.Substring(0, logicColumn.FunctionName.Length - 3);


            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Parameters", parameters);

            logicColumn.ConfigContent = new FunctionConfigurator();
            logicColumn.ConfigContent.DisplayConfiguration(dict);

            return logicColumn;

        }

        LogicColumn CreateNewDeleteLogicColumn( DataSourceTable table, DataSourceLogicTable newTable, List<Model.DataColumn> datacols)
        {
            Model.LogicColumn logicColumn = new Model.LogicColumn();
            logicColumn.ReturnType = "void";
            logicColumn.Tag = "delete-int-and-int";
            logicColumn.Use = true;
            logicColumn.FunctionName = "DeleteBy";

            List<FunctionParameter> parameters = new List<FunctionParameter>();
            foreach (Model.DataColumn col in datacols)
            {
                logicColumn.FunctionName += col.ColumnName + "And";
                string dtType = Helper.DatabaseMapper.MapType(col.DataType);
                string varName1 = Helper.StrUtil.LowFirst(col.ColumnName) + "";
                parameters.Add(new FunctionParameter(varName1, dtType, col));
            }

            if (logicColumn.FunctionName.Length > 0)
                logicColumn.FunctionName = logicColumn.FunctionName.Substring(0, logicColumn.FunctionName.Length - 3);


            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Parameters", parameters);

            logicColumn.ConfigContent = new FunctionConfigurator();
            logicColumn.ConfigContent.DisplayConfiguration(dict);

            return logicColumn;

        }



        void AddDefaultListFunctionsAgain(DataSourceTable table, DataSourceLogicTable newTable)
        {
            int colCounter = 0;
            foreach (Model.DataColumn col in table.DataColumns)
            {
                if (col.DataType.ToLower().Contains("int") && col.Key == false)
                {
                    AddDefaultListFunctionsAgainOnNewTable(table, newTable, colCounter, col);
                }
                colCounter++;
            }
        }

        void AddDefaultListFunctionsAgainOnNewTable(DataSourceTable table, DataSourceLogicTable newTable, int colCounter, Model.DataColumn col)
        {
            int colCounter2 = 0;
            foreach (Model.DataColumn col2 in table.DataColumns)
            {
                LogicColumn logicColumn = CreateDefaultListFunctionAgainLogicColumn(colCounter, colCounter2, col, col2, newTable);
                if (logicColumn != null)
                    newTable.DataColumns.Add(logicColumn);
                colCounter2++;
            }
        }

        LogicColumn CreateDefaultListFunctionAgainLogicColumn(int colCounter, int colCounter2, Model.DataColumn col, Model.DataColumn col2,  DataSourceLogicTable newTable)
        {
            if (colCounter2 >= colCounter && col2.DataType.ToLower().Contains("int") && col2.Key == false && col.ColumnName.Equals(col2.ColumnName) == false)
            {
                Model.LogicColumn logicColumn = new Model.LogicColumn();
                logicColumn.ColumnName = col.ColumnName;
                logicColumn.ColumnText = col.ColumnText;
                logicColumn.ReturnType = "List<" + newTable.TableName + ">";
                logicColumn.Tag = "list-int-and-int";
                logicColumn.Use = true;
                logicColumn.FunctionName = "FindBy" + col.ColumnName + "And" + col2.ColumnName;
                string dtType = Helper.DatabaseMapper.MapType(col.DataType);
                string varName1 = Helper.StrUtil.LowFirst(col.ColumnName) + "";
                string varName2 = Helper.StrUtil.LowFirst(col2.ColumnName) + "";
                List<FunctionParameter> parameters = new List<FunctionParameter>();
                parameters.Add(new FunctionParameter(varName1, dtType, col));
                parameters.Add(new FunctionParameter(varName2, dtType, col2));

                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("Parameters", parameters);

                logicColumn.ConfigContent = new FunctionConfigurator();
                logicColumn.ConfigContent.DisplayConfiguration(dict);

                return logicColumn;
            }
            else
                return null;
        }

        void AddDefaultFunctionsAgain(DataSourceTable table, DataSourceLogicTable newTable)
        {
            int colCounter = 0;
            foreach (Model.DataColumn col in table.DataColumns)
            {
                if (col.DataType.ToLower().Contains("int") && col.Key == false)
                {
                    int colCounter2 = 0;
                    foreach (Model.DataColumn col2 in table.DataColumns)
                    {
                        if(colCounter2 >= colCounter && col2.DataType.ToLower().Contains("int") && col2.Key == false && col.ColumnName.Equals(col2.ColumnName) == false)
                        {
                            Model.LogicColumn logicColumn = new Model.LogicColumn();
                            logicColumn.ColumnName = col.ColumnName;
                            logicColumn.ColumnText = col.ColumnText;
                            logicColumn.ReturnType = "List<" + newTable.TableName + ">";
                            logicColumn.Tag = "list-int-and-int";
                            logicColumn.Use = true;
                            logicColumn.FunctionName = "FindBy" + col.ColumnName + "And" + col2.ColumnName;
                            string dtType = Helper.DatabaseMapper.MapType(col.DataType);
                            string varName1 = Helper.StrUtil.LowFirst(col.ColumnName) + "";
                            string varName2 = Helper.StrUtil.LowFirst(col2.ColumnName) + "";
                            List<FunctionParameter> parameters = new List<FunctionParameter>();
                            parameters.Add(new FunctionParameter(varName1, dtType, col));
                            parameters.Add(new FunctionParameter(varName2, dtType, col2));

                            Dictionary<string, object> dict = new Dictionary<string, object>();
                            dict.Add("Parameters", parameters);

                            logicColumn.ConfigContent = new FunctionConfigurator();
                            logicColumn.ConfigContent.DisplayConfiguration(dict);

                            newTable.DataColumns.Add(logicColumn);
                        }
                        colCounter2++;
                    }
                }
                colCounter++;
            }
        }

        Model.LogicColumn SetDefaultConfigContent(Model.LogicColumn logicColumn)
        {
            string[] words = Regex.Matches(logicColumn.ColumnName, "(^[a-z]+|[A-Z]+(?![a-z])|[A-Z][a-z]+)")
            .OfType<Match>()
            .Select(m => m.Value)
            .ToArray();
            string result = string.Join(" ", words);
            logicColumn.ColumnText = result;
            logicColumn.ConfigContent = new FunctionConfigurator();
            logicColumn.ConfigContent.InitConfiguration(logicColumn);

            return logicColumn;
        }

        private void gridColumns_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && gridColumns.Columns[e.ColumnIndex].Name == "ColParameter" && e.RowIndex > -1)
            {
                LogicColumn col = (LogicColumn)gridColumns.Rows[e.RowIndex].DataBoundItem;
                FormLogicConfig frm = new FormLogicConfig();
                frm.ConfigContent = col.ConfigContent;
                frm.ShowDialog();
                if (frm.IsCanceled == false)
                {
                    col.ConfigContent = frm.ConfigContent;
                }
            }
        }

        private void LogicConfiguratorModelType_Load(object sender, EventArgs e)
        {

        }

        private void LogicConfiguratorModelType_Resize(object sender, EventArgs e)
        {
            this.gridColumns.Width = this.Width - 20;
            this.gridColumns.Height = this.Height - 40;
        }

        private void btnAddFunction_Click(object sender, EventArgs e)
        {
            LogicColumn newcol = CreateDefaultLogicColumn();
            DataSourceTable tbl = CurrentTable;
            tbl.DataColumns.Add(newcol);
            gridColumns.DataSource = CurrentTable.DataColumns.ConvertAll(c => c as LogicColumn);
        }

        private void btnDeleteFunction_Click(object sender, EventArgs e)
        {
            if(this.gridColumns.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.gridColumns.SelectedRows[0];
                gridColumns.Rows.Remove(selectedRow);
            }
        }

        LogicColumn CreateDefaultLogicColumn()
        {
            Model.LogicColumn logicColumn = new Model.LogicColumn();
            logicColumn.ColumnName = "NewColumn";
            logicColumn.ColumnText = "New Column";
            logicColumn.ReturnType = "List<" + CurrentTable.TableName + ">";
            logicColumn.Tag = "list";
            logicColumn.Use = true;
            logicColumn.FunctionName = "NewFunction";
            List<FunctionParameter> parameters = new List<FunctionParameter>();
            parameters.Add(new FunctionParameter("newParam", "string"));

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Parameters", parameters);

            logicColumn.ConfigContent = new FunctionConfigurator();
            logicColumn.ConfigContent.DisplayConfiguration(dict);

            return logicColumn;
        }
    }
}
