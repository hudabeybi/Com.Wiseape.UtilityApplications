namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    partial class TextboxDrawer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLAbel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblLAbel
            // 
            this.lblLAbel.AutoSize = true;
            this.lblLAbel.Location = new System.Drawing.Point(25, 16);
            this.lblLAbel.Name = "lblLAbel";
            this.lblLAbel.Size = new System.Drawing.Size(40, 13);
            this.lblLAbel.TabIndex = 1;
            this.lblLAbel.Text = "LABEL";
            // 
            // TextboxDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLAbel);
            this.Controls.Add(this.textBox1);
            this.Name = "TextboxDrawer";
            this.Size = new System.Drawing.Size(518, 68);
            this.Load += new System.EventHandler(this.TextboxDrawer_Load);
            this.Resize += new System.EventHandler(this.TextboxDrawer_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLAbel;
    }
}
