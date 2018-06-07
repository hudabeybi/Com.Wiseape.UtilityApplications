namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class ValidationStringMinMaxLength
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinStringLength = new System.Windows.Forms.TextBox();
            this.txtMaxStringLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValidationMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min. String Length";
            // 
            // txtMinStringLength
            // 
            this.txtMinStringLength.Location = new System.Drawing.Point(23, 32);
            this.txtMinStringLength.Name = "txtMinStringLength";
            this.txtMinStringLength.Size = new System.Drawing.Size(100, 20);
            this.txtMinStringLength.TabIndex = 1;
            // 
            // txtMaxStringLength
            // 
            this.txtMaxStringLength.Location = new System.Drawing.Point(137, 32);
            this.txtMaxStringLength.Name = "txtMaxStringLength";
            this.txtMaxStringLength.Size = new System.Drawing.Size(100, 20);
            this.txtMaxStringLength.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max. String Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Invalidation Message";
            // 
            // txtValidationMessage
            // 
            this.txtValidationMessage.Location = new System.Drawing.Point(23, 86);
            this.txtValidationMessage.Name = "txtValidationMessage";
            this.txtValidationMessage.Size = new System.Drawing.Size(363, 20);
            this.txtValidationMessage.TabIndex = 4;
            // 
            // ValidationStringMinMaxLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValidationMessage);
            this.Controls.Add(this.txtMaxStringLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinStringLength);
            this.Controls.Add(this.label1);
            this.Name = "ValidationStringMinMaxLength";
            this.Size = new System.Drawing.Size(410, 127);
            this.Load += new System.EventHandler(this.ValidationStringMinMaxLength_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinStringLength;
        private System.Windows.Forms.TextBox txtMaxStringLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValidationMessage;
    }
}
