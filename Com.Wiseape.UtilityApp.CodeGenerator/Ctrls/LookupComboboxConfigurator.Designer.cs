namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class LookupComboboxConfigurator
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
            this.txtDataProvider = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValueMember = new System.Windows.Forms.TextBox();
            this.txtDisplayMember = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDefaultValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaceholder = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Provider (Table name, view, webservice, etc)";
            // 
            // txtDataProvider
            // 
            this.txtDataProvider.Location = new System.Drawing.Point(12, 65);
            this.txtDataProvider.Name = "txtDataProvider";
            this.txtDataProvider.Size = new System.Drawing.Size(432, 20);
            this.txtDataProvider.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Value Member";
            // 
            // txtValueMember
            // 
            this.txtValueMember.Location = new System.Drawing.Point(13, 148);
            this.txtValueMember.Name = "txtValueMember";
            this.txtValueMember.Size = new System.Drawing.Size(234, 20);
            this.txtValueMember.TabIndex = 9;
            // 
            // txtDisplayMember
            // 
            this.txtDisplayMember.Location = new System.Drawing.Point(14, 192);
            this.txtDisplayMember.Name = "txtDisplayMember";
            this.txtDisplayMember.Size = new System.Drawing.Size(430, 20);
            this.txtDisplayMember.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Display Member (separated by \',\' if multiple)";
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(15, 233);
            this.txtDefaultValue.Name = "txtDefaultValue";
            this.txtDefaultValue.Size = new System.Drawing.Size(273, 20);
            this.txtDefaultValue.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Default Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Placeholder";
            // 
            // txtPlaceholder
            // 
            this.txtPlaceholder.Location = new System.Drawing.Point(12, 22);
            this.txtPlaceholder.Name = "txtPlaceholder";
            this.txtPlaceholder.Size = new System.Drawing.Size(273, 20);
            this.txtPlaceholder.TabIndex = 5;
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(14, 107);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(234, 20);
            this.txtModelName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Provider Model Name";
            // 
            // LookupComboboxConfigurator
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
            this.Controls.Add(this.txtPlaceholder);
            this.Controls.Add(this.label2);
            this.Name = "LookupComboboxConfigurator";
            this.Size = new System.Drawing.Size(467, 266);
            this.Load += new System.EventHandler(this.LookupComboboxConfigurator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValueMember;
        private System.Windows.Forms.TextBox txtDisplayMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDefaultValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaceholder;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label6;
    }
}
