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
    public partial class RadioGroupDrawer : UserControl, IElementDesignDrawer
    {
        public RadioGroupDrawer()
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            if(properties.ContainsKey("Items"))
            {
                int left = 10;
                Dictionary<string, string> items = (Dictionary<string, string>)properties["Items"];
                this.panel1.Controls.Clear();
                foreach(KeyValuePair<string, string> item in items)
                {
                    RadioButton btn = new RadioButton();
                    btn.Text = item.Value;
                    btn.Left = left;
                    btn.Width = 100;
                    left += btn.Width + 5; 
                    this.panel1.Controls.Add(btn);
                }
            }

            if (properties.ContainsKey("Label"))
                label1.Text = properties["Label"].ToString();
            
        }

        private void RadioGroupDrawer_Load(object sender, EventArgs e)
        {

        }

        private void RadioGroupDrawer_Resize(object sender, EventArgs e)
        {
            this.panel1.Width = this.Width - 20;
            this.panel1.Height = this.Height - 40;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }
    }
}
