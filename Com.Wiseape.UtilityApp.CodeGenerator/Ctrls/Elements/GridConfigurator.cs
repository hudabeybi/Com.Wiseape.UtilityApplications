using Com.Wiseape.Utility.HttpUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class GridConfigurator : CommonPropertyConfigurator
    {
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.CheckBox chkShowSimpleSearch;
        private System.Windows.Forms.CheckBox chkShowAdvanceSearch;
        private System.Windows.Forms.CheckBox chkShowExport;
        private System.Windows.Forms.CheckBox chkShowSummary;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Button btnDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColumnText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colField;
        private System.Windows.Forms.DataGridViewButtonColumn colInputType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDatasourceInfo;
        private System.Windows.Forms.DataGridView gridAction;
        private System.Windows.Forms.Button btnAddActionButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionHandler;
        private System.Windows.Forms.Button btnTryRetrieve;
        private System.Windows.Forms.CheckBox chkSortable;
        private System.Windows.Forms.CheckBox chkShowCheckboxes;

        List<GridColumn> gridColumns = new List<GridColumn>();
        List<GridColumn> GridColumns
        {
            set
            {
                gridColumns = value;
                DisplayGridColumns(gridColumns);
            }
            get
            {
                gridColumns = GetGridColumns();
                return gridColumns;
            }
        }


        List<GridActionButton> gridActionButtons = new List<GridActionButton>();
        List<GridActionButton> ActionButtons
        {
            set
            {
                gridActionButtons = value;
                DisplayGridActions(gridActionButtons);
            }
            get
            {
                gridActionButtons = GetGridActions();
                return gridActionButtons;
            }
        }

        public GridConfigurator()
        {
            InitializeComponent();

        }

        public GridConfigurator(PropertyPage page) : base(page)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.colColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputType = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chkShowCheckboxes = new System.Windows.Forms.CheckBox();
            this.chkShowSimpleSearch = new System.Windows.Forms.CheckBox();
            this.chkShowAdvanceSearch = new System.Windows.Forms.CheckBox();
            this.chkShowExport = new System.Windows.Forms.CheckBox();
            this.chkShowSummary = new System.Windows.Forms.CheckBox();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnDeleteColumn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDatasourceInfo = new System.Windows.Forms.TextBox();
            this.gridAction = new System.Windows.Forms.DataGridView();
            this.colActionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionIcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionHandler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddActionButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTryRetrieve = new System.Windows.Forms.Button();
            this.chkSortable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAction)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.Location = new System.Drawing.Point(15, 133);
            // 
            // txtPlaceholder
            // 
            this.txtPlaceholder.Location = new System.Drawing.Point(18, 147);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColumnName,
            this.colColumnText,
            this.colField,
            this.colInputType});
            this.grid.Location = new System.Drawing.Point(11, 322);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(802, 116);
            this.grid.TabIndex = 12;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // colColumnName
            // 
            this.colColumnName.HeaderText = "Name";
            this.colColumnName.Name = "colColumnName";
            this.colColumnName.Width = 200;
            // 
            // colColumnText
            // 
            this.colColumnText.HeaderText = "Label";
            this.colColumnText.Name = "colColumnText";
            this.colColumnText.Width = 200;
            // 
            // colField
            // 
            this.colField.HeaderText = "Field";
            this.colField.Name = "colField";
            this.colField.Width = 200;
            // 
            // colInputType
            // 
            this.colInputType.HeaderText = "Input Type";
            this.colInputType.Name = "colInputType";
            this.colInputType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInputType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chkShowCheckboxes
            // 
            this.chkShowCheckboxes.AutoSize = true;
            this.chkShowCheckboxes.Location = new System.Drawing.Point(851, 322);
            this.chkShowCheckboxes.Name = "chkShowCheckboxes";
            this.chkShowCheckboxes.Size = new System.Drawing.Size(115, 17);
            this.chkShowCheckboxes.TabIndex = 13;
            this.chkShowCheckboxes.Text = "Show Checkboxes";
            this.chkShowCheckboxes.UseVisualStyleBackColor = true;
            // 
            // chkShowSimpleSearch
            // 
            this.chkShowSimpleSearch.AutoSize = true;
            this.chkShowSimpleSearch.Location = new System.Drawing.Point(851, 345);
            this.chkShowSimpleSearch.Name = "chkShowSimpleSearch";
            this.chkShowSimpleSearch.Size = new System.Drawing.Size(124, 17);
            this.chkShowSimpleSearch.TabIndex = 14;
            this.chkShowSimpleSearch.Text = "Show Simple Search";
            this.chkShowSimpleSearch.UseVisualStyleBackColor = true;
            // 
            // chkShowAdvanceSearch
            // 
            this.chkShowAdvanceSearch.AutoSize = true;
            this.chkShowAdvanceSearch.Location = new System.Drawing.Point(851, 368);
            this.chkShowAdvanceSearch.Name = "chkShowAdvanceSearch";
            this.chkShowAdvanceSearch.Size = new System.Drawing.Size(136, 17);
            this.chkShowAdvanceSearch.TabIndex = 15;
            this.chkShowAdvanceSearch.Text = "Show Advance Search";
            this.chkShowAdvanceSearch.UseVisualStyleBackColor = true;
            // 
            // chkShowExport
            // 
            this.chkShowExport.AutoSize = true;
            this.chkShowExport.Location = new System.Drawing.Point(851, 391);
            this.chkShowExport.Name = "chkShowExport";
            this.chkShowExport.Size = new System.Drawing.Size(86, 17);
            this.chkShowExport.TabIndex = 16;
            this.chkShowExport.Text = "Show Export";
            this.chkShowExport.UseVisualStyleBackColor = true;
            // 
            // chkShowSummary
            // 
            this.chkShowSummary.AutoSize = true;
            this.chkShowSummary.Location = new System.Drawing.Point(851, 414);
            this.chkShowSummary.Name = "chkShowSummary";
            this.chkShowSummary.Size = new System.Drawing.Size(99, 17);
            this.chkShowSummary.TabIndex = 17;
            this.chkShowSummary.Text = "Show Summary";
            this.chkShowSummary.UseVisualStyleBackColor = true;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(11, 293);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(87, 23);
            this.btnAddColumn.TabIndex = 18;
            this.btnAddColumn.Text = "Add Column +";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnDeleteColumn
            // 
            this.btnDeleteColumn.Location = new System.Drawing.Point(98, 293);
            this.btnDeleteColumn.Name = "btnDeleteColumn";
            this.btnDeleteColumn.Size = new System.Drawing.Size(101, 23);
            this.btnDeleteColumn.TabIndex = 20;
            this.btnDeleteColumn.Text = "Delete Column x";
            this.btnDeleteColumn.UseVisualStyleBackColor = true;
            this.btnDeleteColumn.Click += new System.EventHandler(this.btnDeleteColumn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Datasource Info";
            // 
            // txtDatasourceInfo
            // 
            this.txtDatasourceInfo.Location = new System.Drawing.Point(16, 258);
            this.txtDatasourceInfo.Name = "txtDatasourceInfo";
            this.txtDatasourceInfo.Size = new System.Drawing.Size(619, 20);
            this.txtDatasourceInfo.TabIndex = 22;
            // 
            // gridAction
            // 
            this.gridAction.AllowUserToAddRows = false;
            this.gridAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colActionName,
            this.colActionLabel,
            this.colActionIcon,
            this.colActionHandler});
            this.gridAction.Location = new System.Drawing.Point(11, 478);
            this.gridAction.Name = "gridAction";
            this.gridAction.Size = new System.Drawing.Size(802, 81);
            this.gridAction.TabIndex = 23;
            // 
            // colActionName
            // 
            this.colActionName.HeaderText = "Name";
            this.colActionName.Name = "colActionName";
            // 
            // colActionLabel
            // 
            this.colActionLabel.HeaderText = "Label";
            this.colActionLabel.Name = "colActionLabel";
            // 
            // colActionIcon
            // 
            this.colActionIcon.HeaderText = "Icon";
            this.colActionIcon.Name = "colActionIcon";
            this.colActionIcon.Width = 200;
            // 
            // colActionHandler
            // 
            this.colActionHandler.HeaderText = "Action Handler";
            this.colActionHandler.Name = "colActionHandler";
            this.colActionHandler.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colActionHandler.Width = 300;
            // 
            // btnAddActionButton
            // 
            this.btnAddActionButton.Location = new System.Drawing.Point(11, 449);
            this.btnAddActionButton.Name = "btnAddActionButton";
            this.btnAddActionButton.Size = new System.Drawing.Size(87, 23);
            this.btnAddActionButton.TabIndex = 24;
            this.btnAddActionButton.Text = "Add Action";
            this.btnAddActionButton.UseVisualStyleBackColor = true;
            this.btnAddActionButton.Click += new System.EventHandler(this.btnAddActionButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Delete Action";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTryRetrieve
            // 
            this.btnTryRetrieve.Location = new System.Drawing.Point(641, 258);
            this.btnTryRetrieve.Name = "btnTryRetrieve";
            this.btnTryRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnTryRetrieve.TabIndex = 27;
            this.btnTryRetrieve.Text = "Try Retrieve";
            this.btnTryRetrieve.UseVisualStyleBackColor = true;
            this.btnTryRetrieve.Click += new System.EventHandler(this.btnTryRetrieve_Click);
            // 
            // chkSortable
            // 
            this.chkSortable.AutoSize = true;
            this.chkSortable.Location = new System.Drawing.Point(851, 437);
            this.chkSortable.Name = "chkSortable";
            this.chkSortable.Size = new System.Drawing.Size(65, 17);
            this.chkSortable.TabIndex = 28;
            this.chkSortable.Text = "Sortable";
            this.chkSortable.UseVisualStyleBackColor = true;
            // 
            // GridConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.chkSortable);
            this.Controls.Add(this.btnTryRetrieve);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddActionButton);
            this.Controls.Add(this.gridAction);
            this.Controls.Add(this.txtDatasourceInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteColumn);
            this.Controls.Add(this.btnAddColumn);
            this.Controls.Add(this.chkShowSummary);
            this.Controls.Add(this.chkShowExport);
            this.Controls.Add(this.chkShowAdvanceSearch);
            this.Controls.Add(this.chkShowSimpleSearch);
            this.Controls.Add(this.chkShowCheckboxes);
            this.Controls.Add(this.grid);
            this.Name = "GridConfigurator";
            this.Size = new System.Drawing.Size(1000, 577);
            this.Load += new System.EventHandler(this.GridConfigurator_Load);
            this.Controls.SetChildIndex(this.txtPlaceholder, 0);
            this.Controls.SetChildIndex(this.lblPlaceholder, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtClass, 0);
            this.Controls.SetChildIndex(this.txtStyle, 0);
            this.Controls.SetChildIndex(this.txtDefaultValue, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtLabel, 0);
            this.Controls.SetChildIndex(this.txtDataField, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.chkShowCheckboxes, 0);
            this.Controls.SetChildIndex(this.chkShowSimpleSearch, 0);
            this.Controls.SetChildIndex(this.chkShowAdvanceSearch, 0);
            this.Controls.SetChildIndex(this.chkShowExport, 0);
            this.Controls.SetChildIndex(this.chkShowSummary, 0);
            this.Controls.SetChildIndex(this.btnAddColumn, 0);
            this.Controls.SetChildIndex(this.btnDeleteColumn, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtDatasourceInfo, 0);
            this.Controls.SetChildIndex(this.gridAction, 0);
            this.Controls.SetChildIndex(this.btnAddActionButton, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.btnTryRetrieve, 0);
            this.Controls.SetChildIndex(this.chkSortable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GridConfigurator_Load(object sender, EventArgs e)
        {

        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            int r = grid.Rows.Count;
            GridColumn col = new GridColumn();
            col.ColumnName = "col" + r;
            col.ColumnText = "col" + r;
            PropertyPage pg = new TextboxPropertyPage();
            pg.Properties["ID"] = "col" + r + "Txt";
            col.PropertyPage = pg;

            AddGridColumn(col);
        }

        private void btnAddActionButton_Click(object sender, EventArgs e)
        {
            int r = gridAction.Rows.Count;
            GridActionButton col = new GridActionButton();
            col.Name = "btnAction" + r;
            col.Text = "Action " + r;
            col.OnClick = "btnAction" + r + "OnClick";

            AddGridButton(col);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridAction.SelectedRows.Count > 0)
                gridAction.Rows.Remove(gridAction.SelectedRows[0]);
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
                this.grid.Rows.Remove(grid.SelectedRows[0]);
        }

        public override void Fill(Dictionary<string, object> properties)
        {
            base.Fill(properties);
            properties["DatasourceInfo"] = txtDatasourceInfo.Text;
            properties["Sortable"] = chkSortable.Checked;
            properties["ShowSimpleSearch"] = chkShowSimpleSearch.Checked;
            properties["ShowAdvanceSearch"] = chkShowAdvanceSearch.Checked;
            properties["ShowExport"] = chkShowExport.Checked;
            properties["ShowSummary"] = chkShowSummary.Checked;
            properties["ShowCheckboxes"] = chkShowCheckboxes.Checked;

            properties["GridColumns"] = this.GridColumns;
            properties["GridActionButtons"] = this.ActionButtons;
        }

        public override void Display(Dictionary<string, object> properties)
        {
            base.Display(properties);
            txtDatasourceInfo.Text = Convert.ToString( properties["DatasourceInfo"]);
            chkSortable.Checked = Convert.ToBoolean(properties["Sortable"]);
            chkShowSimpleSearch.Checked = Convert.ToBoolean(properties["ShowSimpleSearch"]);
            chkShowAdvanceSearch.Checked = Convert.ToBoolean(properties["ShowAdvanceSearch"]);
            chkShowExport.Checked = Convert.ToBoolean(properties["ShowExport"]);
            chkShowSummary.Checked = Convert.ToBoolean(properties["ShowSummary"]);
            chkShowCheckboxes.Checked = Convert.ToBoolean(properties["ShowCheckboxes"]);

            this.GridColumns = (List<GridColumn>)properties["GridColumns"];
            this.ActionButtons = (List<GridActionButton>)properties["GridActionButtons"];
        }

        private void grid_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                PropertyPage page = null;
                if (grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag != null)
                    page = (PropertyPage)grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                FormInputTypeConfigure frm = new FormInputTypeConfigure();
                frm.SelectedpropertyPage = page;
                frm.ShowDialog();
                if(frm.IsCanceled == false)
                {
                    grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = frm.SelectedpropertyPage;
                }
            }
        }

        private void btnTryRetrieve_Click(object sender, EventArgs e)
        {
            string json = Utility.HttpUtility.WebClient.Get(txtDatasourceInfo.Text, null);
            Dictionary<string, object> data = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            AddColumnsFromData(data);
        }

        void AddColumnsFromData(Dictionary<string, object> data)
        {
            foreach(string key in data.Keys)
            {
                GridColumn col = CreateColumn("col" + key, key, key);
                AddGridColumn(col);
            }
        }

        void DisplayGridColumns(List<GridColumn> columns)
        {
            this.grid.Rows.Clear();
            foreach(GridColumn col in columns)
            {
                AddGridColumn(col);
            }
        }

        void DisplayGridActions(List<GridActionButton> btns)
        {
            this.gridAction.Rows.Clear();
            foreach (GridActionButton btn in btns)
            {
                AddGridButton(btn);
            }
        }

        List<GridColumn> GetGridColumns()
        {
            List<GridColumn> cols = new List<GridColumn>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string fieldname = (row.Cells[2].Value == null) ? "" : row.Cells[2].Value.ToString();
                    GridColumn gridCol = CreateColumn(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), fieldname);
                    if (row.Cells[3].Tag != null)
                        gridCol.PropertyPage = (PropertyPage)row.Cells[3].Tag;
                    cols.Add(gridCol);
                }
            }
            return cols;
        }

        List<GridActionButton> GetGridActions()
        {
            List<GridActionButton> btns = new List<GridActionButton>();
            foreach (DataGridViewRow row in gridAction.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string name = GetCellValue(row, 0);
                    string text = GetCellValue(row, 1);
                    string icon = GetCellValue(row, 2);
                    string handler = GetCellValue(row, 3);
                    GridActionButton btn = CreateActionButton(name, text, icon, handler);
                    btns.Add(btn);
                }
            }
            return btns;
        }

        string GetCellValue(DataGridViewRow row, int colIdx)
        {
            if (row.Cells[colIdx].Value != null)
                return row.Cells[colIdx].Value.ToString();
            else
                return "";
        }

        GridActionButton CreateActionButton(string name, string text, string icon, string actionHandler)
        {
            GridActionButton btn = new GridActionButton();
            btn.Name = name;
            btn.Text = text;
            btn.Icon = icon;
            btn.OnClick = actionHandler;
            return btn;
        }

        GridColumn CreateColumn(string name, string label, string field)
        {
            GridColumn col = new GridColumn();
            col.ColumnName = name;
            col.ColumnText = label;
            col.Field = field;
            TextboxPropertyPage page = new TextboxPropertyPage();
            col.PropertyPage = page;
            return col;
        }

        void AddGridColumn(GridColumn col)
        {
            int idx = grid.Rows.Add();
            grid.Rows[idx].Cells[0].Value = col.ColumnName;
            grid.Rows[idx].Cells[1].Value = col.ColumnText;
            grid.Rows[idx].Cells[2].Value = col.Field;
            grid.Rows[idx].Cells[3].Tag = col.PropertyPage;
            grid.Rows[idx].Cells[3].Value = col.PropertyPage.GetElementID();
        }

        void AddGridButton(GridActionButton btn)
        {
            int idx = gridAction.Rows.Add();
            gridAction.Rows[idx].Cells[0].Value = btn.Name;
            gridAction.Rows[idx].Cells[1].Value = btn.Text;
            gridAction.Rows[idx].Cells[2].Value = btn.Icon;
            gridAction.Rows[idx].Cells[3].Value = btn.OnClick;

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
