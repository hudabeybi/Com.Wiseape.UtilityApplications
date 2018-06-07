namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class FunctionConfigurator
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
            this.gridParameters = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ColParameterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVariableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // gridParameters
            // 
            this.gridParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColParameterType,
            this.ColVariableName});
            this.gridParameters.Location = new System.Drawing.Point(6, 21);
            this.gridParameters.Name = "gridParameters";
            this.gridParameters.Size = new System.Drawing.Size(464, 150);
            this.gridParameters.TabIndex = 4;
            this.gridParameters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridParameters_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parameters";
            // 
            // ColParameterType
            // 
            this.ColParameterType.HeaderText = "Parameter Type";
            this.ColParameterType.Name = "ColParameterType";
            this.ColParameterType.Width = 200;
            // 
            // ColVariableName
            // 
            this.ColVariableName.HeaderText = "VariableName";
            this.ColVariableName.Name = "ColVariableName";
            this.ColVariableName.Width = 200;
            // 
            // FunctionConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridParameters);
            this.Name = "FunctionConfigurator";
            this.Size = new System.Drawing.Size(478, 180);
            this.Load += new System.EventHandler(this.FunctionConfigurator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridParameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridParameters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParameterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVariableName;
    }
}
