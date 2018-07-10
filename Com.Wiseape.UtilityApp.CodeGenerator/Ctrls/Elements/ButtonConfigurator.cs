using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    [Serializable]
    public class ButtonConfigurator : CommonPropertyConfigurator
    {
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button txtMaxLength;
        private System.Windows.Forms.CheckBox chkNumeric;
        private System.Windows.Forms.Button txtPasswordMask;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.Button txtMinLength;

  
        public ButtonConfigurator(PropertyPage propertyPage) : base(propertyPage)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(899, 19);
            this.txtDefaultValue.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(894, 5);
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1299, 5);
            this.label6.Visible = false;
            // 
            // txtDataField
            // 
            this.txtDataField.Location = new System.Drawing.Point(1304, 19);
            this.txtDataField.Visible = false;
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.Location = new System.Drawing.Point(894, 47);
            this.lblPlaceholder.Visible = false;
            // 
            // txtPlaceholder
            // 
            this.txtPlaceholder.Location = new System.Drawing.Point(899, 61);
            this.txtPlaceholder.Visible = false;
            // 
            // ButtonConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "ButtonConfigurator";
            this.Size = new System.Drawing.Size(822, 261);
            this.Load += new System.EventHandler(this.ButtonConfigurator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonDesigner_Load(object sender, EventArgs e)
        {

        }

        public override void Fill(Dictionary<string, object> config)
        {
            base.Fill(config);
        }

        public override void Display(Dictionary<string, object> properties)
        {
            base.Display(properties);
        }

        private void ButtonConfigurator_Load(object sender, EventArgs e)
        {

        }
    }
}
