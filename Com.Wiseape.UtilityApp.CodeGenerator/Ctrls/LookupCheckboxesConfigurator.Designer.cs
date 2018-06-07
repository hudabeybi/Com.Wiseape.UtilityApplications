namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class LookupCheckboxesConfigurator
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
            this.txtDisplayMember = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValueMember = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataProvider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDefaultValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDisplayMember
            // 
            this.txtDisplayMember.Location = new System.Drawing.Point(10, 148);
            this.txtDisplayMember.Name = "txtDisplayMember";
            this.txtDisplayMember.Size = new System.Drawing.Size(430, 20);
            this.txtDisplayMember.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Display Member (separated by \',\' if multiple)";
            // 
            // txtValueMember
            // 
            this.txtValueMember.Location = new System.Drawing.Point(9, 105);
            this.txtValueMember.Name = "txtValueMember";
            this.txtValueMember.Size = new System.Drawing.Size(234, 20);
            this.txtValueMember.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Value Member";
            // 
            // txtDataProvider
            // 
            this.txtDataProvider.Location = new System.Drawing.Point(8, 21);
            this.txtDataProvider.Name = "txtDataProvider";
            this.txtDataProvider.Size = new System.Drawing.Size(432, 20);
            this.txtDataProvider.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Data Source (Table name, view, webservice, etc)";
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(11, 193);
            this.txtDefaultValue.Name = "txtDefaultValue";
            this.txtDefaultValue.Size = new System.Drawing.Size(273, 20);
            this.txtDefaultValue.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Default Value";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(8, 64);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(234, 20);
            this.txtModelName.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Data Provider Model Name";
            // 
            // LookupCheckboxesConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDefaultValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDisplayMember);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValueMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataProvider);
            this.Controls.Add(this.label1);
            this.Name = "LookupCheckboxesConfigurator";
            this.Size = new System.Drawing.Size(470, 233);
            this.Load += new System.EventHandler(this.LookupCheckboxesConfigurator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplayMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValueMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDefaultValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label6;
    }
}
