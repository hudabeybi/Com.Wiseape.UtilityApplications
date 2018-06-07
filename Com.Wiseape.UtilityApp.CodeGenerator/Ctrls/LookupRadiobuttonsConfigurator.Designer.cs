namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    partial class LookupRadiobuttonsConfigurator
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDisplayMember
            // 
            this.txtDisplayMember.Location = new System.Drawing.Point(14, 157);
            this.txtDisplayMember.Name = "txtDisplayMember";
            this.txtDisplayMember.Size = new System.Drawing.Size(430, 20);
            this.txtDisplayMember.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Display Member (separated by \',\' if multiple)";
            // 
            // txtValueMember
            // 
            this.txtValueMember.Location = new System.Drawing.Point(13, 112);
            this.txtValueMember.Name = "txtValueMember";
            this.txtValueMember.Size = new System.Drawing.Size(234, 20);
            this.txtValueMember.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Value Member";
            // 
            // txtDataProvider
            // 
            this.txtDataProvider.Location = new System.Drawing.Point(12, 21);
            this.txtDataProvider.Name = "txtDataProvider";
            this.txtDataProvider.Size = new System.Drawing.Size(432, 20);
            this.txtDataProvider.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Provider (Table name, view, webservice, etc)";
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(15, 205);
            this.txtDefaultValue.Name = "txtDefaultValue";
            this.txtDefaultValue.Size = new System.Drawing.Size(273, 20);
            this.txtDefaultValue.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Default Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Provider Data Model";
            // 
            // txtDataModel
            // 
            this.txtDataModel.Location = new System.Drawing.Point(12, 66);
            this.txtDataModel.Name = "txtDataModel";
            this.txtDataModel.Size = new System.Drawing.Size(234, 20);
            this.txtDataModel.TabIndex = 23;
            // 
            // LookupRadiobuttonsConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDataModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDefaultValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDisplayMember);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValueMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataProvider);
            this.Controls.Add(this.label1);
            this.Name = "LookupRadiobuttonsConfigurator";
            this.Size = new System.Drawing.Size(472, 238);
            this.Load += new System.EventHandler(this.LookupRadiobuttonsConfigurator_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataModel;
    }
}
