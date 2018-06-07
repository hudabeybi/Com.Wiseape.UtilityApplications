namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class ComboboxConfigurator
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
            this.txtPlaceholder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridOptions = new System.Windows.Forms.DataGridView();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDefaultValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlaceholder
            // 
            this.txtPlaceholder.Location = new System.Drawing.Point(14, 27);
            this.txtPlaceholder.Name = "txtPlaceholder";
            this.txtPlaceholder.Size = new System.Drawing.Size(273, 20);
            this.txtPlaceholder.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Placeholder";
            // 
            // gridOptions
            // 
            this.gridOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColValue,
            this.ColText});
            this.gridOptions.Location = new System.Drawing.Point(16, 76);
            this.gridOptions.Name = "gridOptions";
            this.gridOptions.Size = new System.Drawing.Size(453, 127);
            this.gridOptions.TabIndex = 10;
            // 
            // ColValue
            // 
            this.ColValue.HeaderText = "Value";
            this.ColValue.Name = "ColValue";
            this.ColValue.Width = 200;
            // 
            // ColText
            // 
            this.ColText.HeaderText = "Text";
            this.ColText.Name = "ColText";
            this.ColText.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Options";
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(17, 233);
            this.txtDefaultValue.Name = "txtDefaultValue";
            this.txtDefaultValue.Size = new System.Drawing.Size(273, 20);
            this.txtDefaultValue.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Default Value";
            // 
            // ComboboxConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDefaultValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridOptions);
            this.Controls.Add(this.txtPlaceholder);
            this.Controls.Add(this.label2);
            this.Name = "ComboboxConfigurator";
            this.Size = new System.Drawing.Size(485, 269);
            this.Load += new System.EventHandler(this.ComboboxConfigrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaceholder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDefaultValue;
        private System.Windows.Forms.Label label3;
    }
}
