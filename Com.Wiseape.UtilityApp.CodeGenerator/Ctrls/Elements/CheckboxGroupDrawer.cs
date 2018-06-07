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
    public partial class CheckboxGroupDrawer : UserControl, IElementDesignDrawer
    {
        public CheckboxGroupDrawer()
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            if (properties.ContainsKey("Items"))
            {
                int left = 10;
                Dictionary<string, string> items = (Dictionary<string, string>)properties["Items"];
                this.panel1.Controls.Clear();
                foreach (KeyValuePair<string, string> item in items)
                {
                    RadioButton btn = new RadioButton();
                    btn.Text = item.Value;
                    btn.Left = left;
                    btn.Width = 100;
                    left += btn.Width + 5;
                    btn.Top = 20;
                    this.panel1.Controls.Add(btn);
                }
            }

            if (properties.ContainsKey("Label"))
                label1.Text = properties["Label"].ToString();
        }

        private void CheckboxGroupDrawer_Load(object sender, EventArgs e)
        {

        }

        private void CheckboxGroupDrawer_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.Width - 20;
            panel1.Height = this.Height - 30;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }
    }
}
