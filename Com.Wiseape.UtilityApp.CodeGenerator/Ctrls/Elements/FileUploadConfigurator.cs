using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class FileUploadConfigurator : CommonPropertyConfigurator
    {
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUploadUrl;
        private System.Windows.Forms.CheckBox chkHtml;


        public FileUploadConfigurator(PropertyPage propertyPage) : base(propertyPage)
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.txtUploadUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Upload URL";
            // 
            // txtUploadUrl
            // 
            this.txtUploadUrl.Location = new System.Drawing.Point(20, 208);
            this.txtUploadUrl.Name = "txtUploadUrl";
            this.txtUploadUrl.Size = new System.Drawing.Size(773, 20);
            this.txtUploadUrl.TabIndex = 15;
            // 
            // FileUploadConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.txtUploadUrl);
            this.Controls.Add(this.label7);
            this.Name = "FileUploadConfigurator";
            this.Size = new System.Drawing.Size(827, 256);
            this.Load += new System.EventHandler(this.FileUploadConfigurator_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtClass, 0);
            this.Controls.SetChildIndex(this.txtStyle, 0);
            this.Controls.SetChildIndex(this.txtDefaultValue, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtLabel, 0);
            this.Controls.SetChildIndex(this.txtDataField, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtPlaceholder, 0);
            this.Controls.SetChildIndex(this.lblPlaceholder, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtUploadUrl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextboxDesigner_Load(object sender, EventArgs e)
        {

        }

        public override void Fill(Dictionary<string, object> properties)
        {
            base.Fill(properties);
            properties["UploadUrl"] = txtUploadUrl.Text;
            
        }

        public override void Display(Dictionary<string, object> properties)
        {
            base.Display(properties);
            txtUploadUrl.Text = Convert.ToString(properties["UploadUrl"]);
        }

        private void FileUploadConfigurator_Load(object sender, EventArgs e)
        {

        }
    }
}
