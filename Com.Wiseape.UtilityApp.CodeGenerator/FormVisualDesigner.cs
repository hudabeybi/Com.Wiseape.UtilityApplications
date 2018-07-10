using Com.Wiseape.UtilityApp.CodeGenerator.Ctrls;
using Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;
using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    public partial class FormVisualDesigner : Form
    {
        Ctrls.Elements.PropertyPage ctrl = null;

        public GenerateUIType UIType { get; set; }

        DataSourceUITable uiTable = null;
        protected DataSourceUITable UITable {
            get
            {
                return uiTable;
            }
            set
            {
                uiTable = value;
                if (UIType == GenerateUIType.Form)
                    DisplayUITable(uiTable);
                else
                    DisplayGrid(uiTable);
                
            }
        }

        private CodeGeneratorModule currentModule = null;
        public CodeGeneratorModule CurrentModule {
            get
            {
                return currentModule;
            }
            set
            {
                currentModule = value;

                if (UIType == GenerateUIType.Form)
                {
                    if (currentModule.ElementLayoutDesigner == null)
                        currentModule.ElementLayoutDesigner = this.elementLayoutDesigner1;
                    if (currentModule.UIObjects == null || (currentModule.UIObjects != null && currentModule.UIObjects.Count == 0))
                        UITable = (DataSourceUITable)currentModule.ModelType.Datasource;
                    else
                    {
                        this.elementLayoutDesigner1.TableRows = currentModule.UIObjects;
                    }
                }
                else
                {
                    UITable = (DataSourceUITable)currentModule.ModelType.Datasource;
                }
            }
        }

        public CodeGeneratorProject CurrentProject { get; set; }

        public FormVisualDesigner()
        {
            InitializeComponent();
            //UIType = GenerateUIType.Form;
        }

        private void FormVisualDesigner_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void elementPadCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void elementPadCtrl1_Load_1(object sender, EventArgs e)
        {

        }


        private void elementLayoutDesigner1_Load(object sender, EventArgs e)
        {

        }

        private void elementLayoutDesigner1_OnTableCellClick(TableCell tableCell)
        {
            if (this.ctrl != null)
                this.elementLayoutDesigner1.AddElement(this.ctrl);
            this.ctrl = null;
        }

        private void elementPadCtrl1_OnClickEventHandler(PropertyPage ctrl)
        {
            this.ctrl = ctrl;
        }

        private void FormVisualDesigner_Resize(object sender, EventArgs e)
        {
            elementLayoutDesigner1.Width = this.Width - elementLayoutDesigner1.Left - 30;
            elementLayoutDesigner1.Height = this.Height - 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TableRowObject> tableRowObjects = this.elementLayoutDesigner1.TableRows;
            ElementLayoutObject layout = new ElementLayoutObject();
            layout.TableRows = tableRowObjects;
            string s = Newtonsoft.Json.JsonConvert.SerializeObject(layout);
            FormText frm = new FormText();
            frm.ShowDialog(s);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            FormText frm = new FormText();
            frm.ShowDialog("");
            string s = frm.GetText();

            ElementLayoutObject layout = Newtonsoft.Json.JsonConvert.DeserializeObject< ElementLayoutObject>(s);
            ElementLayoutDesigner layoutDesigner = new ElementLayoutDesigner();
            layoutDesigner.TableRows = layout.TableRows;

            this.elementLayoutDesigner1.TableRows = layout.TableRows;
            string tmp = "";
        }

        void DisplayGrid(DataSourceUITable uiTable)
        {
            TableRow row = this.elementLayoutDesigner1.AddRow();
            row.AddTableCells(1);
            this.elementLayoutDesigner1.SelectCell(0, 0);

            PropertyPage ctrl = CreateGridPropertyPage(uiTable);
            this.elementLayoutDesigner1.AddElement(ctrl);

        }

        PropertyPage CreateGridPropertyPage(DataSourceUITable uiTable)
        {

            PropertyPage ctrl = new GridPropertyPage();
            

            List<GridColumn> columns = new List<GridColumn>();
            foreach (UIColumn col in uiTable.DataColumns)
            {
                GridColumn column = CreateGridColumn(col);
                column.PropertyPage = new TextboxPropertyPage();
                columns.Add(column);
            }

            ctrl.Properties["GridColumns"] = columns;
            if(this.currentModule != null)
            {
                ctrl.Properties["ID"] = "grid" + this.currentModule.ModuleName;
                ctrl.Properties["Label"] = "List of " + this.currentModule.ModuleName;
            }
            return ctrl;
        }

        GridColumn CreateGridColumn(UIColumn col)
        {
            GridColumn column = new GridColumn();
            column.Field = col.ColumnName;
            column.ColumnName = col.ColumnName;
            column.ColumnText = col.ColumnText;
            return column;
        }

        void DisplayUITable(DataSourceUITable uitable)
        {
            int rowIdx = 0;
            int colIdx = 0;
            bool skipThisCol = false;
            foreach(UIColumn col in uitable.DataColumns)
            {
                if (skipThisCol)
                {
                    skipThisCol = false;
                    colIdx++;
                    continue;
                }

                TableRow row = this.elementLayoutDesigner1.AddRow();
                if( colIdx + 1 < uitable.DataColumns.Count - 1)
                {
                    UIColumn nextCol = (UIColumn)uiTable.DataColumns[colIdx + 1];
                    if (col.CtrlType != ControlType.Hidden && nextCol.CtrlType != ControlType.Hidden && col.CtrlType != ControlType.Textarea && nextCol.CtrlType != ControlType.Textarea)
                    {
                        row.AddTableCells(2);

                        this.elementLayoutDesigner1.SelectCell(rowIdx, 0);
                        PropertyPage ctrl = CreatePropertyPageFromUIColumn(col);
                        this.elementLayoutDesigner1.AddElement(ctrl);

                        this.elementLayoutDesigner1.SelectCell(rowIdx, 1);
                        PropertyPage nextCtrl = CreatePropertyPageFromUIColumn(nextCol);
                        this.elementLayoutDesigner1.AddElement(nextCtrl);

                        skipThisCol = true;
                    }
                    else
                    {

                        row.AddTableCells(1);
                        this.elementLayoutDesigner1.SelectCell(rowIdx, 0);
                        PropertyPage ctrl = CreatePropertyPageFromUIColumn(col);
                        this.elementLayoutDesigner1.AddElement(ctrl);
                    }
                }
                else
                {
                    row.AddTableCells(1);
                    this.elementLayoutDesigner1.SelectCell(rowIdx, 0);
                    PropertyPage ctrl = CreatePropertyPageFromUIColumn(col);
                    this.elementLayoutDesigner1.AddElement(ctrl);
                }
                colIdx++;
                rowIdx++;
            }
        }

        PropertyPage CreatePropertyPageFromUIColumn(UIColumn column)
        {
            string prefix = "";
            PropertyPage page = null;
            if (column.CtrlType == ControlType.Textbox || column.CtrlType == ControlType.Numericbox || column.CtrlType == ControlType.Hidden)
            {
                page = new TextboxPropertyPage();
                prefix = "txt";
                if (column.CtrlType == ControlType.Numericbox)
                {
                    page.Properties["IsNumeric"] = true;
                }

                if (column.CtrlType == ControlType.Hidden)
                {
                    page.Properties["IsHidden"] = true;
                }
            }
            else if (column.CtrlType == ControlType.Textarea || column.CtrlType == ControlType.HtmlEditor)
            {
                prefix = "txt";

                page = new TextareaPropertyPage();
                if (column.CtrlType == ControlType.HtmlEditor)
                    page.Properties["IsHtml"] = true;

            }
            else if (column.CtrlType == ControlType.Image || column.CtrlType == ControlType.File)
            {
                prefix = "file";
                if (column.CtrlType == ControlType.Image)
                    prefix = "image";

                page = new FileUploadPropertyPage();
            }
            else if (column.CtrlType == ControlType.Combobox || column.CtrlType == ControlType.LookupCombobox)
            {
                prefix = "cmb";
                page = new SelectBoxPropertyPage();

            }
            else if (column.CtrlType == ControlType.Checkboxes || column.CtrlType == ControlType.LookupCheckboxes)
            {
                prefix = "chk";
                page = new CheckboxPropertyPage();
            }
            else if (column.CtrlType == ControlType.Radiobuttons || column.CtrlType == ControlType.LookupRadiobuttons)
            {
                prefix = "rd";
                page = new RadioGroupPropertyPage();
            }
            else if (column.CtrlType == ControlType.Date || column.CtrlType == ControlType.Datetime || column.CtrlType == ControlType.Daterange)
            {
                prefix = "dt";
                page = new DateTimePropertyPage();
                if (column.CtrlType == ControlType.Datetime)
                    page.Properties["IncludeTime"] = true;
                if (column.CtrlType == ControlType.Daterange)
                    page.Properties["DateRange"] = true;
            }


            SetPageProperties(page, column, prefix);


            return page;
        }

        void SetPageProperties(PropertyPage page, UIColumn column, string prefix = "")
        {

            page.Properties["ID"] = prefix + column.ColumnName;
            page.Properties["Label"] = column.ColumnText;
            page.Properties["DataField"] = column.ColumnName;
            page.Properties["Placeholder"] = "Please, enter " + column.ColumnText;

            Dictionary<string, object> configs = column.ConfigContent.Configure();
            if (configs.ContainsKey("Options"))
            {
                List<ItemOption> options = (List<ItemOption>)configs["Options"];
                Dictionary<string, string> items = new Dictionary<string, string>();
                foreach (ItemOption opt in options)
                {
                    items.Add(opt.Value, opt.Text);
                }
                page.Properties["Items"] = items;
            }

            if (configs.ContainsKey("DataSource"))
            {
                page.Properties["QueryOrUrl"] = configs["DataSource"];
            }
            if (configs.ContainsKey("ValueMember"))
            {
                page.Properties["ValueMember"] = configs["ValueMember"];
            }
            if (configs.ContainsKey("DisplayMember"))
            {
                page.Properties["DisplayMember"] = configs["DisplayMember"];
            }
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            FormCodeTemplate frm = new FormCodeTemplate();
            frm.Project = CurrentProject;
            frm.Module = CurrentModule;
            frm.ShowDialog();
        }

        private void elementLayoutDesigner1_OnStateChanged(object sender)
        {
            if(CurrentModule != null)
            {
                CurrentModule.ElementLayoutDesigner = this.elementLayoutDesigner1;
                List<TableRowObject> rows = CurrentModule.ElementLayoutDesigner.TableRows;
            }
        }

        private void btnAddDefaultSaveClose_Click(object sender, EventArgs e)
        {
            AddDefaultSaveAndClose();
        }

        void AddDefaultSaveAndClose()
        {
            List<TableRowObject> rows = this.elementLayoutDesigner1.TableRows;

            TableRowObject newRow = new TableRowObject();

            List<TableCellObject> cells = new List<TableCellObject>();
            TableCellObject cell = new TableCellObject();
            cell.TableCellName = "cellBtnSave";

            PropertyPage btnPage = new ButtonPropertyPage();
            btnPage.Properties["ID"] = "btnSave";
            btnPage.Properties["CssClass"] = "btn-save";
            btnPage.Properties["OnClick"] = "btnSaveClick";
            btnPage.Properties["Label"] = "Save";
            cell.AddElementFromControl(btnPage);
            cells.Add(cell);

            cell = new TableCellObject();
            cell.TableCellName = "cellBtnClose";

            btnPage = new ButtonPropertyPage();
            btnPage.Properties["ID"] = "btnClose";
            btnPage.Properties["CssClass"] = "btn-close";
            btnPage.Properties["OnClick"] = "btnCloseClick";
            btnPage.Properties["Label"] = "Close";
            cell.AddElementFromControl(btnPage);
            cells.Add(cell);

            newRow.TableCells = cells;

            rows.Add(newRow);
            this.elementLayoutDesigner1.TableRows = rows;

        }
    }
}
