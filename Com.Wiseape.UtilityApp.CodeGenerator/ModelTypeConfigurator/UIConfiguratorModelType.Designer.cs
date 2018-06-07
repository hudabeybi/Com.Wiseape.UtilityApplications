namespace Com.Wiseape.UtilityApp.CodeGenerator.ModelTypeConfigurator
{
    partial class UIConfiguratorModelType
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridColumns = new System.Windows.Forms.DataGridView();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInputType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColDetail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridColumns
            // 
            this.gridColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColChk,
            this.ColKey,
            this.ColColumnName,
            this.ColLabel,
            this.ColDataType,
            this.ColInputType,
            this.ColView,
            this.ColDetail,
            this.ColAdd,
            this.ColEdit,
            this.ColDelete,
            this.ColGroup});
            this.gridColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridColumns.EnableHeadersVisualStyles = false;
            this.gridColumns.Location = new System.Drawing.Point(0, 0);
            this.gridColumns.Name = "gridColumns";
            this.gridColumns.Size = new System.Drawing.Size(1098, 439);
            this.gridColumns.TabIndex = 1;
            this.gridColumns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColumns_CellContentClick);
            this.gridColumns.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColumns_CellDoubleClick);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(12, 2);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(39, 23);
            this.btnAddRow.TabIndex = 2;
            this.btnAddRow.Text = "+";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(50, 2);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(39, 23);
            this.btnDeleteRow.TabIndex = 3;
            this.btnDeleteRow.Text = "-";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridColumns);
            this.panel1.Location = new System.Drawing.Point(4, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 439);
            this.panel1.TabIndex = 4;
            // 
            // ColChk
            // 
            this.ColChk.DataPropertyName = "Use";
            this.ColChk.HeaderText = "Used?";
            this.ColChk.Name = "ColChk";
            this.ColChk.Width = 42;
            // 
            // ColKey
            // 
            this.ColKey.DataPropertyName = "Key";
            this.ColKey.HeaderText = "Key";
            this.ColKey.Name = "ColKey";
            this.ColKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColKey.Width = 50;
            // 
            // ColColumnName
            // 
            this.ColColumnName.DataPropertyName = "ColumnName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColColumnName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColColumnName.HeaderText = "Column Name";
            this.ColColumnName.Name = "ColColumnName";
            this.ColColumnName.Width = 97;
            // 
            // ColLabel
            // 
            this.ColLabel.DataPropertyName = "Label";
            this.ColLabel.HeaderText = "Label";
            this.ColLabel.Name = "ColLabel";
            this.ColLabel.Width = 57;
            // 
            // ColDataType
            // 
            this.ColDataType.DataPropertyName = "DataType";
            this.ColDataType.HeaderText = "Data Type";
            this.ColDataType.Name = "ColDataType";
            this.ColDataType.Width = 82;
            // 
            // ColInputType
            // 
            this.ColInputType.DataPropertyName = "ControlConfigurationsJson";
            this.ColInputType.HeaderText = "Input Type Configuration";
            this.ColInputType.Name = "ColInputType";
            this.ColInputType.ReadOnly = true;
            this.ColInputType.Width = 140;
            // 
            // ColView
            // 
            this.ColView.DataPropertyName = "View";
            this.ColView.HeaderText = "View";
            this.ColView.Name = "ColView";
            this.ColView.Width = 35;
            // 
            // ColDetail
            // 
            this.ColDetail.DataPropertyName = "Detail";
            this.ColDetail.HeaderText = "Detail";
            this.ColDetail.Name = "ColDetail";
            this.ColDetail.Width = 40;
            // 
            // ColAdd
            // 
            this.ColAdd.DataPropertyName = "Add";
            this.ColAdd.HeaderText = "Add";
            this.ColAdd.Name = "ColAdd";
            this.ColAdd.Width = 32;
            // 
            // ColEdit
            // 
            this.ColEdit.DataPropertyName = "Edit";
            this.ColEdit.HeaderText = "Edit";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.Width = 31;
            // 
            // ColDelete
            // 
            this.ColDelete.DataPropertyName = "Delete";
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.Width = 44;
            // 
            // ColGroup
            // 
            this.ColGroup.DataPropertyName = "InputGroup";
            this.ColGroup.HeaderText = "Input Group";
            this.ColGroup.Name = "ColGroup";
            this.ColGroup.Width = 83;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(111, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(58, 23);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(168, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(57, 23);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // UIConfiguratorModelType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnAddRow);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "UIConfiguratorModelType";
            this.Size = new System.Drawing.Size(1105, 474);
            this.Load += new System.EventHandler(this.UIConfiguratorModelType_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.UIConfiguratorModelType_ControlAdded);
            this.Resize += new System.EventHandler(this.UIConfiguratorModelType_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridColumns;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChk;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInputType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColDetail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGroup;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
    }
}
