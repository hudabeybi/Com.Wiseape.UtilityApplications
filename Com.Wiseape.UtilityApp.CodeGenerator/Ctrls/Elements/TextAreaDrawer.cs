using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    [Serializable]
    public partial class TextAreaDrawer : UserControl, IElementDesignDrawer
    {
        private Label lblLAbel;
        private TextBox textBox1;

        public TextAreaDrawer()
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            if (properties.ContainsKey("Label"))
                this.lblLAbel.Text = properties["Label"].ToString();
            if (properties.ContainsKey("DefaultValue"))
                this.textBox1.Text = properties["DefaultValue"].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextboxDrawer_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLAbel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(398, 74);
            this.textBox1.TabIndex = 0;
            // 
            // lblLAbel
            // 
            this.lblLAbel.AutoSize = true;
            this.lblLAbel.Location = new System.Drawing.Point(16, 9);
            this.lblLAbel.Name = "lblLAbel";
            this.lblLAbel.Size = new System.Drawing.Size(40, 13);
            this.lblLAbel.TabIndex = 1;
            this.lblLAbel.Text = "LABEL";
            // 
            // TextAreaDrawer
            // 
            this.Controls.Add(this.lblLAbel);
            this.Controls.Add(this.textBox1);
            this.Name = "TextAreaDrawer";
            this.Size = new System.Drawing.Size(438, 114);
            this.Load += new System.EventHandler(this.TextboxDrawer_Load_1);
            this.Resize += new System.EventHandler(this.TextAreaDrawer_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextboxDrawer_Load_1(object sender, EventArgs e)
        {
            
        }

        private void TextAreaDrawer_Resize(object sender, EventArgs e)
        {
            this.textBox1.Width = this.Width - 30;
            this.textBox1.Height = this.Height - 30;
        }
    }
}
