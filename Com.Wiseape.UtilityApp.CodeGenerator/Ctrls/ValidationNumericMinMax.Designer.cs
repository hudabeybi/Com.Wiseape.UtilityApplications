namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class ValidationNumericMinMax
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtValidationMessage = new System.Windows.Forms.TextBox();
            this.txtMaxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Invalidation Message";
            // 
            // txtValidationMessage
            // 
            this.txtValidationMessage.Location = new System.Drawing.Point(20, 83);
            this.txtValidationMessage.Name = "txtValidationMessage";
            this.txtValidationMessage.Size = new System.Drawing.Size(363, 20);
            this.txtValidationMessage.TabIndex = 10;
            // 
            // txtMaxNumber
            // 
            this.txtMaxNumber.Location = new System.Drawing.Point(134, 29);
            this.txtMaxNumber.Name = "txtMaxNumber";
            this.txtMaxNumber.Size = new System.Drawing.Size(100, 20);
            this.txtMaxNumber.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max. Number";
            // 
            // txtMinNumber
            // 
            this.txtMinNumber.Location = new System.Drawing.Point(20, 29);
            this.txtMinNumber.Name = "txtMinNumber";
            this.txtMinNumber.Size = new System.Drawing.Size(100, 20);
            this.txtMinNumber.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Min. Number";
            // 
            // ValidationNumericMinMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValidationMessage);
            this.Controls.Add(this.txtMaxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinNumber);
            this.Controls.Add(this.label1);
            this.Name = "ValidationNumericMinMax";
            this.Size = new System.Drawing.Size(395, 122);
            this.Load += new System.EventHandler(this.ValidationNumericMinMax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValidationMessage;
        private System.Windows.Forms.TextBox txtMaxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinNumber;
        private System.Windows.Forms.Label label1;
    }
}
