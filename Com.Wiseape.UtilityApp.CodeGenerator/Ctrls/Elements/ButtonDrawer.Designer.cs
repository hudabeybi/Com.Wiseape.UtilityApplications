namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    partial class ButtonDrawer
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
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblLAbel
            // 
            this.lblLAbel.Location = new System.Drawing.Point(0, 0);
            this.lblLAbel.Name = "lblLAbel";
            this.lblLAbel.Size = new System.Drawing.Size(100, 23);
            this.lblLAbel.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(90, 44);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(119, 48);
            this.btn.TabIndex = 2;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ButtonDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblLAbel);
            this.Controls.Add(this.textBox1);
            this.Name = "ButtonDrawer";
            this.Size = new System.Drawing.Size(298, 138);
            this.Load += new System.EventHandler(this.ButtonDrawer_Load_1);
            this.Resize += new System.EventHandler(this.ButtonDrawer_Resize_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLAbel;
        private System.Windows.Forms.Button btn;
    }
}
