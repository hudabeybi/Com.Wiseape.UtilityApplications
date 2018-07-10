namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    partial class FormTemp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.elementLayoutDesigner1 = new Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements.ElementLayoutDesigner();
            this.SuspendLayout();
            // 
            // elementLayoutDesigner1
            // 
            this.elementLayoutDesigner1.Location = new System.Drawing.Point(33, 12);
            this.elementLayoutDesigner1.Name = "elementLayoutDesigner1";
            this.elementLayoutDesigner1.ShowButtons = true;
            this.elementLayoutDesigner1.Size = new System.Drawing.Size(930, 479);
            this.elementLayoutDesigner1.TabIndex = 0;
            // 
            // FormTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 548);
            this.Controls.Add(this.elementLayoutDesigner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTemp";
            this.Text = "FormTemp";
            this.Load += new System.EventHandler(this.FormTemp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ElementLayoutDesigner elementLayoutDesigner1;
    }
}