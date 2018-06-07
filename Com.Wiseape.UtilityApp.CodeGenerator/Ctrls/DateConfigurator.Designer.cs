namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class DateConfigurator
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
            this.chkWithTime = new System.Windows.Forms.CheckBox();
            this.txtDateFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlaceholder
            // 
            this.txtPlaceholder.Location = new System.Drawing.Point(16, 27);
            this.txtPlaceholder.Name = "txtPlaceholder";
            this.txtPlaceholder.Size = new System.Drawing.Size(273, 20);
            this.txtPlaceholder.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Placeholder";
            // 
            // chkWithTime
            // 
            this.chkWithTime.AutoSize = true;
            this.chkWithTime.Location = new System.Drawing.Point(18, 57);
            this.chkWithTime.Name = "chkWithTime";
            this.chkWithTime.Size = new System.Drawing.Size(70, 17);
            this.chkWithTime.TabIndex = 8;
            this.chkWithTime.Text = "With time";
            this.chkWithTime.UseVisualStyleBackColor = true;
            // 
            // txtDateFormat
            // 
            this.txtDateFormat.Location = new System.Drawing.Point(18, 97);
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Size = new System.Drawing.Size(273, 20);
            this.txtDateFormat.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date Format";
            // 
            // DateConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDateFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkWithTime);
            this.Controls.Add(this.txtPlaceholder);
            this.Controls.Add(this.label2);
            this.Name = "DateConfigurator";
            this.Size = new System.Drawing.Size(309, 141);
            this.Load += new System.EventHandler(this.DateConfigurator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaceholder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkWithTime;
        private System.Windows.Forms.TextBox txtDateFormat;
        private System.Windows.Forms.Label label1;
    }
}
