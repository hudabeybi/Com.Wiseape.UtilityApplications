namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    partial class FormVisualDesigner
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.elementLayoutDesigner1 = new Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements.ElementLayoutDesigner();
            this.elementPadCtrl1 = new Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.ElementPadCtrl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "TO Json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "From JSON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Location = new System.Drawing.Point(14, 321);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(147, 23);
            this.btnGenerateCode.TabIndex = 4;
            this.btnGenerateCode.Text = "Generate Code";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // elementLayoutDesigner1
            // 
            this.elementLayoutDesigner1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementLayoutDesigner1.Location = new System.Drawing.Point(170, 13);
            this.elementLayoutDesigner1.Name = "elementLayoutDesigner1";
            this.elementLayoutDesigner1.ShowButtons = true;
            this.elementLayoutDesigner1.Size = new System.Drawing.Size(1037, 579);
            this.elementLayoutDesigner1.TabIndex = 1;
            this.elementLayoutDesigner1.OnTableCellClick += new Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements.ElementLayoutDesigner.OnTableCellClickDelegate(this.elementLayoutDesigner1_OnTableCellClick);
            this.elementLayoutDesigner1.OnStateChanged += new Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements.ElementLayoutDesigner.OnStateChangedDelegate(this.elementLayoutDesigner1_OnStateChanged);
            this.elementLayoutDesigner1.Load += new System.EventHandler(this.elementLayoutDesigner1_Load);
            // 
            // elementPadCtrl1
            // 
            this.elementPadCtrl1.IndexesToShow = "0,1,2,3,4,5,6,7,8";
            this.elementPadCtrl1.Location = new System.Drawing.Point(14, 13);
            this.elementPadCtrl1.Name = "elementPadCtrl1";
            this.elementPadCtrl1.Size = new System.Drawing.Size(150, 278);
            this.elementPadCtrl1.TabIndex = 0;
            this.elementPadCtrl1.OnClickEventHandler += new Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.ElementPadCtrl.OnClickDelegate(this.elementPadCtrl1_OnClickEventHandler);
            this.elementPadCtrl1.Load += new System.EventHandler(this.elementPadCtrl1_Load_1);
            // 
            // FormVisualDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 604);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elementLayoutDesigner1);
            this.Controls.Add(this.elementPadCtrl1);
            this.Name = "FormVisualDesigner";
            this.Text = "Form Visual Designer";
            this.Load += new System.EventHandler(this.FormVisualDesigner_Load);
            this.Resize += new System.EventHandler(this.FormVisualDesigner_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Ctrls.ElementPadCtrl elementPadCtrl1;
        private Ctrls.Elements.ElementLayoutDesigner elementLayoutDesigner1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGenerateCode;
    }
}