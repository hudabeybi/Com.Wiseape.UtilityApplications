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
    public class TextboxConfigurator : CommonPropertyConfigurator
    {
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaxLength;
        private System.Windows.Forms.CheckBox chkNumeric;
        private System.Windows.Forms.TextBox txtPasswordMask;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMinLength;

  
        public TextboxConfigurator()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxLength = new System.Windows.Forms.TextBox();
            this.txtMinLength = new System.Windows.Forms.TextBox();
            this.chkNumeric = new System.Windows.Forms.CheckBox();
            this.txtPasswordMask = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Max. Length";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Min. Length";
            // 
            // txtMaxLength
            // 
            this.txtMaxLength.Location = new System.Drawing.Point(14, 155);
            this.txtMaxLength.Name = "txtMaxLength";
            this.txtMaxLength.Size = new System.Drawing.Size(137, 20);
            this.txtMaxLength.TabIndex = 14;
            // 
            // txtMinLength
            // 
            this.txtMinLength.Location = new System.Drawing.Point(171, 154);
            this.txtMinLength.Name = "txtMinLength";
            this.txtMinLength.Size = new System.Drawing.Size(137, 20);
            this.txtMinLength.TabIndex = 15;
            // 
            // chkNumeric
            // 
            this.chkNumeric.AutoSize = true;
            this.chkNumeric.Location = new System.Drawing.Point(16, 187);
            this.chkNumeric.Name = "chkNumeric";
            this.chkNumeric.Size = new System.Drawing.Size(76, 17);
            this.chkNumeric.TabIndex = 16;
            this.chkNumeric.Text = "Is Numeric";
            this.chkNumeric.UseVisualStyleBackColor = true;
            // 
            // txtPasswordMask
            // 
            this.txtPasswordMask.Location = new System.Drawing.Point(17, 230);
            this.txtPasswordMask.Name = "txtPasswordMask";
            this.txtPasswordMask.Size = new System.Drawing.Size(137, 20);
            this.txtPasswordMask.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Password Mask";
            // 
            // TextboxConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.txtPasswordMask);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkNumeric);
            this.Controls.Add(this.txtMinLength);
            this.Controls.Add(this.txtMaxLength);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "TextboxConfigurator";
            this.Size = new System.Drawing.Size(827, 270);
            this.Load += new System.EventHandler(this.TextboxDesigner_Load);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtMaxLength, 0);
            this.Controls.SetChildIndex(this.txtMinLength, 0);
            this.Controls.SetChildIndex(this.chkNumeric, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtPasswordMask, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextboxDesigner_Load(object sender, EventArgs e)
        {

        }

        public override void Fill(Dictionary<string, object> config)
        {
            base.Fill(config);
            config["MaxLength"] = txtMaxLength.Text;
            config["MinLength"] = txtMinLength.Text;
            config["IsNumeric"] = chkNumeric.Checked;
            config["PasswordMask"] = txtPasswordMask.Text;
        }

        public override void Display(Dictionary<string, object> properties)
        {
            base.Display(properties);
            if(properties.ContainsKey("MaxLength"))
                txtMaxLength.Text = "" + properties["MaxLength"];
            txtMinLength.Text = "" + properties["MinLength"];
            chkNumeric.Checked = Convert.ToBoolean(properties["IsNumeric"]);
            txtPasswordMask.Text = "" + properties["PasswordMask"];
        }


    }
}
