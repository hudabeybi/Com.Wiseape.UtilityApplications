namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class NumericboxConfiguration
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
            this.txtDefaultValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaceholder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDigitGrouping = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(23, 82);
            this.txtDefaultValue.Name = "txtDefaultValue";
            this.txtDefaultValue.Size = new System.Drawing.Size(273, 20);
            this.txtDefaultValue.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Default Value";
            // 
            // txtPlaceholder
            // 
            this.txtPlaceholder.Location = new System.Drawing.Point(21, 35);
            this.txtPlaceholder.Name = "txtPlaceholder";
            this.txtPlaceholder.Size = new System.Drawing.Size(273, 20);
            this.txtPlaceholder.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Placeholder";
            // 
            // chkDigitGrouping
            // 
            this.chkDigitGrouping.AutoSize = true;
            this.chkDigitGrouping.Location = new System.Drawing.Point(23, 115);
            this.chkDigitGrouping.Name = "chkDigitGrouping";
            this.chkDigitGrouping.Size = new System.Drawing.Size(93, 17);
            this.chkDigitGrouping.TabIndex = 10;
            this.chkDigitGrouping.Text = "Digit Grouping";
            this.chkDigitGrouping.UseVisualStyleBackColor = true;
            // 
            // NumericboxConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkDigitGrouping);
            this.Controls.Add(this.txtDefaultValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaceholder);
            this.Controls.Add(this.label2);
            this.Name = "NumericboxConfiguration";
            this.Size = new System.Drawing.Size(345, 145);
            this.Load += new System.EventHandler(this.NumericboxConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDefaultValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaceholder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDigitGrouping;
    }
}
