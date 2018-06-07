namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class TextboxConfiguration
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaceholder = new System.Windows.Forms.TextBox();
            this.txtDefaultValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordChar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placeholder";
            // 
            // txtPlaceholder
            // 
            this.txtPlaceholder.Location = new System.Drawing.Point(19, 34);
            this.txtPlaceholder.Name = "txtPlaceholder";
            this.txtPlaceholder.Size = new System.Drawing.Size(273, 20);
            this.txtPlaceholder.TabIndex = 3;
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(18, 81);
            this.txtDefaultValue.Name = "txtDefaultValue";
            this.txtDefaultValue.Size = new System.Drawing.Size(273, 20);
            this.txtDefaultValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Default Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password Char";
            // 
            // txtPasswordChar
            // 
            this.txtPasswordChar.Location = new System.Drawing.Point(18, 129);
            this.txtPasswordChar.Name = "txtPasswordChar";
            this.txtPasswordChar.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordChar.TabIndex = 7;
            // 
            // TextboxConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPasswordChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDefaultValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaceholder);
            this.Controls.Add(this.label2);
            this.Name = "TextboxConfiguration";
            this.Size = new System.Drawing.Size(312, 168);
            this.Load += new System.EventHandler(this.TextboxConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaceholder;
        private System.Windows.Forms.TextBox txtDefaultValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasswordChar;
    }
}
