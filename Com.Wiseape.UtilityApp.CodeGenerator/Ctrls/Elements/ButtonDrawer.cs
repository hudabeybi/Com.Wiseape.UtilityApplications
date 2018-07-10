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
    public partial class ButtonDrawer : BaseDrawer, IElementDesignDrawer
    {
        public ButtonDrawer(PropertyPage page) : base(page)
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            btn.Text = properties["Label"].ToString();

        }

        private void Button1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDrawer_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDrawer_Resize(object sender, EventArgs e)
        {

        }

        private void ButtonDrawer_Load_1(object sender, EventArgs e)
        {

        }

        private void ButtonDrawer_Resize_1(object sender, EventArgs e)
        {
            btn.Left = this.Width / 2 - btn.Width / 2;
            btn.Top = this.Height / 2 - btn.Height / 2;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }
    }
}
