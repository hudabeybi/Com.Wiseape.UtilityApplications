using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class TextAreaConfigurator : CommonPropertyConfigurator
    {
        private System.Windows.Forms.CheckBox chkHtml;


        public TextAreaConfigurator(PropertyPage propertyPage) : base(propertyPage)
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.chkHtml = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkHtml
            // 
            this.chkHtml.AutoSize = true;
            this.chkHtml.Location = new System.Drawing.Point(17, 250);
            this.chkHtml.Name = "chkHtml";
            this.chkHtml.Size = new System.Drawing.Size(67, 17);
            this.chkHtml.TabIndex = 16;
            this.chkHtml.Text = "Is HTML";
            this.chkHtml.UseVisualStyleBackColor = true;
            // 
            // TextAreaConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.chkHtml);
            this.Name = "TextAreaConfigurator";
            this.Size = new System.Drawing.Size(827, 287);
            this.Load += new System.EventHandler(this.TextboxDesigner_Load);
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
            this.Controls.SetChildIndex(this.chkHtml, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextboxDesigner_Load(object sender, EventArgs e)
        {

        }

        public override void Fill(Dictionary<string, object> properties)
        {
            base.Fill(properties);
            properties["IsHtml"] = chkHtml.Checked;
            
        }

        public override void Display(Dictionary<string, object> properties)
        {
            base.Display(properties);
            chkHtml.Checked = Convert.ToBoolean(properties["IsHtml"]);
        }
    }
}
