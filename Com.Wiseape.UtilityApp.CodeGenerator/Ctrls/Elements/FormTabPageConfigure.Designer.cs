namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    partial class FormTabPageConfigure
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTabName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTabLabel = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elementLayoutDesigner1 = new Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements.ElementLayoutDesigner();
            this.elementPadCtrl1 = new Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.ElementPadCtrl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tab Name";
            // 
            // txtTabName
            // 
            this.txtTabName.Location = new System.Drawing.Point(16, 25);
            this.txtTabName.Name = "txtTabName";
            this.txtTabName.Size = new System.Drawing.Size(333, 20);
            this.txtTabName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tab Label";
            // 
            // txtTabLabel
            // 
            this.txtTabLabel.Location = new System.Drawing.Point(379, 25);
            this.txtTabLabel.Name = "txtTabLabel";
            this.txtTabLabel.Size = new System.Drawing.Size(333, 20);
            this.txtTabLabel.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(950, 542);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1024, 542);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elementLayoutDesigner1);
            this.groupBox1.Controls.Add(this.elementPadCtrl1);
            this.groupBox1.Location = new System.Drawing.Point(13, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 484);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content";
            // 
            // elementLayoutDesigner1
            // 
            this.elementLayoutDesigner1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementLayoutDesigner1.Location = new System.Drawing.Point(162, 17);
            this.elementLayoutDesigner1.Name = "elementLayoutDesigner1";
            this.elementLayoutDesigner1.ShowButtons = true;
            this.elementLayoutDesigner1.Size = new System.Drawing.Size(918, 459);
            this.elementLayoutDesigner1.TabIndex = 3;
            this.elementLayoutDesigner1.OnTableCellClick += new Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements.ElementLayoutDesigner.OnTableCellClickDelegate(this.elementLayoutDesigner1_OnTableCellClick);
            this.elementLayoutDesigner1.Load += new System.EventHandler(this.elementLayoutDesigner1_Load);
            // 
            // elementPadCtrl1
            // 
            this.elementPadCtrl1.IndexesToShow = "0,1,2,3,4,5,6,7,8";
            this.elementPadCtrl1.Location = new System.Drawing.Point(6, 17);
            this.elementPadCtrl1.Name = "elementPadCtrl1";
            this.elementPadCtrl1.Size = new System.Drawing.Size(150, 459);
            this.elementPadCtrl1.TabIndex = 2;
            this.elementPadCtrl1.OnClickEventHandler += new Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.ElementPadCtrl.OnClickDelegate(this.elementPadCtrl1_OnClickEventHandler);
            // 
            // FormTabPageConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTabLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTabName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTabPageConfigure";
            this.Text = "FormTabPageConfigure";
            this.Load += new System.EventHandler(this.FormTabPageConfigure_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTabName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTabLabel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private ElementLayoutDesigner elementLayoutDesigner1;
        private ElementPadCtrl elementPadCtrl1;
    }
}