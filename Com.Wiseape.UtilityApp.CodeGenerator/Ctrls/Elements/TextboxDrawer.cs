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
    public partial class TextboxDrawer : BaseDrawer, IElementDesignDrawer
    {
        public TextboxDrawer(PropertyPage page) : base(page)
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            if (properties.ContainsKey("Label"))
                this.lblLAbel.Text = properties["Label"].ToString();

            if (properties.ContainsKey("Placeholder"))
                this.textBox1.Text = properties["Placeholder"].ToString();

            if (properties.ContainsKey("IsHidden") && Convert.ToBoolean(properties["IsHidden"]) == true)
                this.textBox1.BackColor = Color.Gray;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextboxDrawer_Load(object sender, EventArgs e)
        {

        }

        private void TextboxDrawer_Resize(object sender, EventArgs e)
        {
            this.textBox1.Width = this.Width - 30;
            this.textBox1.Height = this.Height - 30;
        }
    }
}
