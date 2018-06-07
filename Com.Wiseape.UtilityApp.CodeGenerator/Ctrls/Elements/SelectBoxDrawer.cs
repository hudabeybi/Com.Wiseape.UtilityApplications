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
    public partial class SelectBoxDrawer : UserControl, IElementDesignDrawer
    {
        public SelectBoxDrawer()
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            label1.Text = properties["Label"].ToString();
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
