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
    public partial class SelectDynamicValueCtrl : UserControl
    {
        public string QueryOrUrl { get { return txtQuery.Text; } set { txtQuery.Text = value; } }
        public string ValueMember { get { return txtValueMember.Text; } set { txtValueMember.Text = value; } }
        public string DisplayMember { get { return txtDisplayMember.Text; } set { txtDisplayMember.Text = value; } }

        public SelectDynamicValueCtrl()
        {
            InitializeComponent();
        }

        private void SelectDynamicValueCtrl_Resize(object sender, EventArgs e)
        {
            txtQuery.Width = this.Width - txtQuery.Left - txtQuery.Left;
            txtQuery.Height = this.Height - txtQuery.Top - 10;
        }

        private void SelectDynamicValueCtrl_Load(object sender, EventArgs e)
        {

        }
    }
}
