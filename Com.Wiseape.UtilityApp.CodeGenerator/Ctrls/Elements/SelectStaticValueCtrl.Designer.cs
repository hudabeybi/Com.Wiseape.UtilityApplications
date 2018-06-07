namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    partial class SelectStaticValueCtrl
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
            this.gridValues = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridValues)).BeginInit();
            this.SuspendLayout();
            // 
            // gridValues
            // 
            this.gridValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColValue,
            this.ColDisplay});
            this.gridValues.Location = new System.Drawing.Point(3, 41);
            this.gridValues.Name = "gridValues";
            this.gridValues.Size = new System.Drawing.Size(627, 150);
            this.gridValues.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(79, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ColValue
            // 
            this.ColValue.HeaderText = "Value";
            this.ColValue.Name = "ColValue";
            this.ColValue.Width = 200;
            // 
            // ColDisplay
            // 
            this.ColDisplay.HeaderText = "Display";
            this.ColDisplay.Name = "ColDisplay";
            this.ColDisplay.Width = 200;
            // 
            // SelectStaticValueCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridValues);
            this.Name = "SelectStaticValueCtrl";
            this.Size = new System.Drawing.Size(633, 205);
            this.Load += new System.EventHandler(this.SelectStaticValueCtrl_Load);
            this.Resize += new System.EventHandler(this.SelectStaticValueCtrl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridValues;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDisplay;
    }
}
