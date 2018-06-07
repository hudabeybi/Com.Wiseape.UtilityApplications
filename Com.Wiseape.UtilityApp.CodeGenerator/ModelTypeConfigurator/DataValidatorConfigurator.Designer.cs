namespace Com.Wiseape.UtilityApp.CodeGenerator.ModelTypeConfigurator
{
    partial class DataValidatorConfigurator
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
            this.gridColumns = new System.Windows.Forms.DataGridView();
            this.ColChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValidationConfig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumns
            // 
            this.gridColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColChk,
            this.ColColumnName,
            this.ColDataType,
            this.ColValidationConfig});
            this.gridColumns.EnableHeadersVisualStyles = false;
            this.gridColumns.Location = new System.Drawing.Point(9, 3);
            this.gridColumns.Name = "gridColumns";
            this.gridColumns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridColumns.Size = new System.Drawing.Size(1086, 421);
            this.gridColumns.TabIndex = 0;
            this.gridColumns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColumns_CellContentClick);
            this.gridColumns.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColumns_CellDoubleClick);
            // 
            // ColChk
            // 
            this.ColChk.DataPropertyName = "Use";
            this.ColChk.HeaderText = "Used?";
            this.ColChk.Name = "ColChk";
            this.ColChk.Width = 42;
            // 
            // ColColumnName
            // 
            this.ColColumnName.DataPropertyName = "ColumnName";
            this.ColColumnName.HeaderText = "Column Name";
            this.ColColumnName.Name = "ColColumnName";
            this.ColColumnName.ReadOnly = true;
            this.ColColumnName.Width = 89;
            // 
            // ColDataType
            // 
            this.ColDataType.DataPropertyName = "DataType";
            this.ColDataType.HeaderText = "Data Type";
            this.ColDataType.Name = "ColDataType";
            this.ColDataType.ReadOnly = true;
            this.ColDataType.Width = 76;
            // 
            // ColValidationConfig
            // 
            this.ColValidationConfig.DataPropertyName = "ControlConfigurationsJson";
            this.ColValidationConfig.HeaderText = "Validation Configuration";
            this.ColValidationConfig.Name = "ColValidationConfig";
            this.ColValidationConfig.ReadOnly = true;
            this.ColValidationConfig.Width = 133;
            // 
            // DataValidatorConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridColumns);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "DataValidatorConfigurator";
            this.Size = new System.Drawing.Size(1109, 437);
            this.Load += new System.EventHandler(this.DataValidatorConfigurator_Load);
            this.Resize += new System.EventHandler(this.DataValidatorConfigurator_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridColumns;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValidationConfig;
    }
}
