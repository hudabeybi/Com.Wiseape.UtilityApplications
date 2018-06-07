namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    partial class FormAddCodeTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCodeTemplate));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOke = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.txtDefaultFilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Template name";
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.Location = new System.Drawing.Point(9, 30);
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Size = new System.Drawing.Size(476, 21);
            this.txtTemplateName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code";
            // 
            // btnOke
            // 
            this.btnOke.Location = new System.Drawing.Point(987, 13);
            this.btnOke.Name = "btnOke";
            this.btnOke.Size = new System.Drawing.Size(106, 24);
            this.btnOke.TabIndex = 4;
            this.btnOke.Text = "Save";
            this.btnOke.UseVisualStyleBackColor = true;
            this.btnOke.Click += new System.EventHandler(this.btnOke_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(987, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCode
            // 
            this.txtCode.IsReadOnly = false;
            this.txtCode.Location = new System.Drawing.Point(15, 81);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(1078, 450);
            this.txtCode.TabIndex = 6;
            // 
            // txtDefaultFilename
            // 
            this.txtDefaultFilename.Location = new System.Drawing.Point(491, 30);
            this.txtDefaultFilename.Name = "txtDefaultFilename";
            this.txtDefaultFilename.Size = new System.Drawing.Size(476, 21);
            this.txtDefaultFilename.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Default Filename";
            // 
            // FormAddCodeTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDefaultFilename);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTemplateName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCodeTemplate";
            this.Text = "FormAddCodeTemplate";
            this.Load += new System.EventHandler(this.FormAddCodeTemplate_Load);
            this.Resize += new System.EventHandler(this.FormAddCodeTemplate_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOke;
        private System.Windows.Forms.Button btnCancel;
        private ICSharpCode.TextEditor.TextEditorControl txtCode;
        private System.Windows.Forms.TextBox txtDefaultFilename;
        private System.Windows.Forms.Label label3;
    }
}