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


        public TextAreaConfigurator()
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
            this.chkHtml.Location = new System.Drawing.Point(15, 142);
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
            this.Size = new System.Drawing.Size(827, 177);
            this.Load += new System.EventHandler(this.TextboxDesigner_Load);
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
