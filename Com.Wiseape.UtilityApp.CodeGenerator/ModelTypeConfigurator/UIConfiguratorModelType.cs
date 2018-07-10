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
    public partial class UIConfiguratorModelType : UserControl, IAssemblyNameGenerator, IModelTypeConfigurator
    {
        public UIConfiguratorModelType()
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

        DataSourceTable CurrentTable;
        public void InitFromDatasource(DataSourceTable table)
        {
            gridColumns.AutoGenerateColumns = false;
            DataSourceUITable newTable = Copy(table);
            gridColumns.DataSource = newTable.DataColumns.ConvertAll(c => c as UIColumn); 
            CurrentTable = newTable;
        }

        public void UpdateDatasource(object table)
        {
            //At first it will load from Json and Json will be serialized into DataColumns as DataColumn item, not UIColumn item as expected. That is why we need
            //DataColumns2, to store its UIColumn list, and copy it to DataColumns
            if (table.GetType() != typeof(DataSourceUITable))
            {
                string json = Utility.Serializer.Json.Serialize(table);
                json = json.Replace("DataColumns", "DataColumns2");
                json = json.Replace("DataColumns22", "DataColumns2");
                DataSourceUITable tbl = Utility.Serializer.Json.Deserialize<DataSourceUITable>(json);
                foreach (UIColumn col in tbl.DataColumns2)
                {
                    if(col.ConfigContent == null)
                        SetDefaultConfigContent(col);
                    
                    tbl.DataColumns.Add(col);
                }
                CurrentTable = tbl;
            }
            else
            {
                CurrentTable = (DataSourceUITable)table;
            }
           
            gridColumns.AutoGenerateColumns = false;
            //gridColumns.DataSource = tbl.DataColumns;
            gridColumns.DataSource = CurrentTable.DataColumns.ConvertAll(c => c as UIColumn);
        }


        protected DataSourceUITable Copy(DataSourceTable table)
        {
            DataSourceUITable newTable = new DataSourceUITable();
            newTable.TableName = table.TableName;
            newTable.TableSchema = table.TableSchema;

            foreach (Model.DataColumn col in table.DataColumns)
            {
                Model.UIColumn uiColumn = new Model.UIColumn();
                uiColumn.DataType = col.DataType;
                uiColumn.ColumnName = col.ColumnName;
                uiColumn.ColumnText = col.ColumnText;
                uiColumn.Key = col.Key;
                uiColumn.Use = true;
                uiColumn.Size = col.Size;
                uiColumn.View = true;
                uiColumn.Detail = true;
                uiColumn.Add = true;
                uiColumn.Edit = true;
                uiColumn.Delete = true;
                uiColumn.Label = col.ColumnText;
                if (col.ConfigContent == null)
                    uiColumn = SetDefaultConfigContent(uiColumn);
                else
                {
                    uiColumn.ConfigContent = col.ConfigContent;
                    uiColumn.ConfigContent.InitConfiguration(uiColumn);
                }
                newTable.DataColumns.Add(uiColumn);
            }

            return newTable;
        }

        Model.UIColumn SetDefaultConfigContent(Model.UIColumn uiColumn)
        {
            string[] words = Regex.Matches(uiColumn.ColumnName, "(^[a-z]+|[A-Z]+(?![a-z])|[A-Z][a-z]+)")
            .OfType<Match>()
            .Select(m => m.Value)
            .ToArray();
            string result = string.Join(" ", words);
            uiColumn.Label = result;
            uiColumn.ColumnText = result;

            if (uiColumn.Key)
            {
                uiColumn.ConfigContent = new HiddenConfiguration();
            }
            else if (uiColumn.DataType.ToLower().Contains("int") || uiColumn.DataType.ToLower().Contains("long") || uiColumn.DataType.ToLower().Contains("double") || uiColumn.DataType.ToLower().Contains("float"))
            {
                uiColumn.ConfigContent = new NumericboxConfiguration();
            }
            else if(uiColumn.DataType.ToLower().Contains("date"))
            {
                uiColumn.ConfigContent = new DateConfigurator();
            }
            else if (uiColumn.DataType.ToLower().Contains("text"))
            {
                uiColumn.ConfigContent = new TextareaConfiguration();
            }
            else
            {
                uiColumn.ConfigContent = new TextboxConfiguration();
            }
            uiColumn.ConfigContent.InitConfiguration(uiColumn);
            return uiColumn;
        }

        private void gridColumns_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridColumns.Columns[e.ColumnIndex].Name == "ColInputType")
            {
                UIColumn col = (UIColumn)gridColumns.Rows[e.RowIndex].DataBoundItem;
                FormUIConfig frm = new FormUIConfig();
                frm.DataColumn = col;
                frm.ConfigContent = col.ConfigContent;
                frm.ShowDialog();
                if(frm.IsCanceled == false)
                {
                    col.ConfigContent = frm.ConfigContent;
                }
            }
        }

        private void gridColumns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            UIColumn column = CreateNewUIColumn();
            CurrentTable.DataColumns.Add(column);
            this.gridColumns.DataSource = null;
            this.gridColumns.DataSource = CurrentTable.DataColumns;
            
        }

        UIColumn CreateNewUIColumn()
        {
            UIColumn column = new UIColumn();
            column.ColumnName = "NewColumn";
            column.Label = "New Column";
            column.Use = true;
            column.View = true;
            column.Add = true;
            column.Detail = true;
            column.Delete = true;
            column.Edit = true;
            column.DataType = "varchar";
            column.ConfigContent = new TextboxConfiguration();
            return column;
        }

        private void UIConfiguratorModelType_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void UIConfiguratorModelType_Load(object sender, EventArgs e)
        {

        }

        private void UIConfiguratorModelType_Resize(object sender, EventArgs e)
        {
            this.panel1.Width = this.Width - 10;
            this.panel1.Height = this.Height - 40;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (gridColumns.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.gridColumns.SelectedRows[0];
                UIColumn column = (UIColumn)row.DataBoundItem;
                List<UIColumn> columns = (List<UIColumn>)gridColumns.DataSource;
                columns.Remove(column);
                gridColumns.DataSource = null;
                gridColumns.DataSource = columns;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if(gridColumns.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridColumns.SelectedRows[0];
                int idx = row.Index;
                idx--;
                if(idx > -1)
                {
                    UIColumn column = (UIColumn)row.DataBoundItem;
                    List<UIColumn> columns = (List<UIColumn>)gridColumns.DataSource;
                    UIColumn prevColumn = (UIColumn)columns[idx];
                    columns.Remove(column);
                    columns.Insert(idx, column);
                    gridColumns.DataSource = columns;
                    gridColumns.Refresh();
                    gridColumns.ClearSelection();
                    gridColumns.Rows[idx].Selected = true;
                    
                }
            }
        }

        public delegate void VisualDesignerClickDelegate(DataSourceUITable uiTable);
        public event VisualDesignerClickDelegate OnVisualDesignerButtonClick;

        private void btnOpenVisualDesigner_Click(object sender, EventArgs e)
        {
            if (this.OnVisualDesignerButtonClick != null)
                this.OnVisualDesignerButtonClick((DataSourceUITable)this.GetDatasource());
        }

    }
}
