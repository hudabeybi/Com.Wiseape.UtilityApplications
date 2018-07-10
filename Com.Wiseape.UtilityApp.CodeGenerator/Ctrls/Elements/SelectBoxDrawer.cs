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
    public partial class SelectBoxDrawer : BaseDrawer, IElementDesignDrawer
    {
        public SelectBoxDrawer(PropertyPage page) : base(page)
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            label1.Text = properties["Label"].ToString();

            if (properties["Items"].GetType() == typeof(Dictionary<string, object>))
            {
                Dictionary<string, object> items = (Dictionary<string, object>)properties["Items"];
                comboBox1.Items.Clear();
                foreach (KeyValuePair<string, object> item in items)
                {
                    comboBox1.Items.Add(item.Value);
                }
            }

            if (properties["Items"].GetType() == typeof(Dictionary<string, string>))
            {
                Dictionary<string, string> items = (Dictionary<string, string>)properties["Items"];
                comboBox1.Items.Clear();
                foreach (KeyValuePair<string, string> item in items)
                {
                    comboBox1.Items.Add(item.Value);
                }
            }
        }

        private void SelectBoxDrawer_Load(object sender, EventArgs e)
        {

        }

        private void SelectBoxDrawer_Resize(object sender, EventArgs e)
        {
            comboBox1.Width = this.Width - comboBox1.Left - comboBox1.Left;
        }
    }
}
