namespace Com.Wiseape.UtilityApp.CodeGenerator.ModelTypeConfigurator
{
    partial class LogicConfiguratorModelType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridColumns = new System.Windows.Forms.DataGridView();
            this.btnAddFunction = new System.Windows.Forms.Button();
            this.btnDeleteFunction = new System.Windows.Forms.Button();
            this.ColKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumns
            // 
            this.gridColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKey,
            this.ColColumnName,
            this.ColDataType,
            this.ColParameter,
            this.ColTag});
            this.gridColumns.EnableHeadersVisualStyles = false;
            this.gridColumns.Location = new System.Drawing.Point(13, 33);
            this.gridColumns.Name = "gridColumns";
            this.gridColumns.Size = new System.Drawing.Size(905, 381);
            this.gridColumns.TabIndex = 2;
            this.gridColumns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColumns_CellContentClick);
            this.gridColumns.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColumns_CellDoubleClick);
            // 
            // btnAddFunction
            // 
            this.btnAddFunction.Location = new System.Drawing.Point(13, 4);
            this.btnAddFunction.Name = "btnAddFunction";
            this.btnAddFunction.Size = new System.Drawing.Size(32, 23);
            this.btnAddFunction.TabIndex = 3;
            this.btnAddFunction.Text = "+";
            this.btnAddFunction.UseVisualStyleBackColor = true;
            this.btnAddFunction.Click += new System.EventHandler(this.btnAddFunction_Click);
            // 
            // btnDeleteFunction
            // 
            this.btnDeleteFunction.Location = new System.Drawing.Point(44, 4);
            this.btnDeleteFunction.Name = "btnDeleteFunction";
            this.btnDeleteFunction.Size = new System.Drawing.Size(32, 23);
            this.btnDeleteFunction.TabIndex = 4;
            this.btnDeleteFunction.Text = "-";
            this.btnDeleteFunction.UseVisualStyleBackColor = true;
            this.btnDeleteFunction.Click += new System.EventHandler(this.btnDeleteFunction_Click);
            // 
            // ColKey
            // 
            this.ColKey.DataPropertyName = "Use";
            this.ColKey.HeaderText = "Used";
            this.ColKey.Name = "ColKey";
            this.ColKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColKey.Width = 57;
            // 
            // ColColumnName
            // 
            this.ColColumnName.DataPropertyName = "FunctionName";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColColumnName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColColumnName.HeaderText = "Function Name";
            this.ColColumnName.Name = "ColColumnName";
            this.ColColumnName.Width = 300;
            // 
            // ColDataType
            // 
            this.ColDataType.DataPropertyName = "ReturnType";
            this.ColDataType.HeaderText = "Return Type";
            this.ColDataType.Name = "ColDataType";
            this.ColDataType.Width = 200;
            // 
            // ColParameter
            // 
            this.ColParameter.DataPropertyName = "ControlConfigurationsJson";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ColParameter.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColParameter.HeaderText = "Parameters";
            this.ColParameter.Name = "ColParameter";
            this.ColParameter.ReadOnly = true;
            this.ColParameter.Width = 600;
            // 
            // ColTag
            // 
            this.ColTag.DataPropertyName = "Tag";
            this.ColTag.HeaderText = "Tag";
            this.ColTag.Name = "ColTag";
            // 
            // LogicConfiguratorModelType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnDeleteFunction);
            this.Controls.Add(this.btnAddFunction);
            this.Controls.Add(this.gridColumns);
            this.Name = "LogicConfiguratorModelType";
            this.Size = new System.Drawing.Size(940, 429);
            this.Load += new System.EventHandler(this.LogicConfiguratorModelType_Load);
            this.Resize += new System.EventHandler(this.LogicConfiguratorModelType_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridColumns;
        private System.Windows.Forms.Button btnAddFunction;
        private System.Windows.Forms.Button btnDeleteFunction;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTag;
    }
}
