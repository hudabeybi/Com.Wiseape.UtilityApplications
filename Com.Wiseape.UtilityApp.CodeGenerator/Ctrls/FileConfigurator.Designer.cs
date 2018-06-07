namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class FileConfigurator
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
            this.txtAllowedExtentions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaceholder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSavedFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkGenerateFilename = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtAllowedExtentions
            // 
            this.txtAllowedExtentions.Location = new System.Drawing.Point(15, 85);
            this.txtAllowedExtentions.Name = "txtAllowedExtentions";
            this.txtAllowedExtentions.Size = new System.Drawing.Size(273, 20);
            this.txtAllowedExtentions.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Allowed Extentions";
            // 
            // txtPlaceholder
            // 
            this.txtPlaceholder.Location = new System.Drawing.Point(13, 32);
            this.txtPlaceholder.Name = "txtPlaceholder";
            this.txtPlaceholder.Size = new System.Drawing.Size(273, 20);
            this.txtPlaceholder.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Placeholder";
            // 
            // txtSavedFolder
            // 
            this.txtSavedFolder.Location = new System.Drawing.Point(17, 138);
            this.txtSavedFolder.Name = "txtSavedFolder";
            this.txtSavedFolder.Size = new System.Drawing.Size(273, 20);
            this.txtSavedFolder.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Saved Folder";
            // 
            // chkGenerateFilename
            // 
            this.chkGenerateFilename.AutoSize = true;
            this.chkGenerateFilename.Checked = true;
            this.chkGenerateFilename.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenerateFilename.Location = new System.Drawing.Point(19, 174);
            this.chkGenerateFilename.Name = "chkGenerateFilename";
            this.chkGenerateFilename.Size = new System.Drawing.Size(115, 17);
            this.chkGenerateFilename.TabIndex = 12;
            this.chkGenerateFilename.Text = "Generate Filename";
            this.chkGenerateFilename.UseVisualStyleBackColor = true;
            // 
            // FileConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkGenerateFilename);
            this.Controls.Add(this.txtSavedFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAllowedExtentions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaceholder);
            this.Controls.Add(this.label2);
            this.Name = "FileConfigurator";
            this.Size = new System.Drawing.Size(306, 213);
            this.Load += new System.EventHandler(this.FileConfigurator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAllowedExtentions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaceholder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSavedFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkGenerateFilename;
    }
}
