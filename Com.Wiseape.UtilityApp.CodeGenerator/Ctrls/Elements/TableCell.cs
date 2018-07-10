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
    public partial class TableCell : UserControl
    {
        public delegate void OnStateChangedDelegate(object sender);
        public event OnStateChangedDelegate OnStateChanged;

        public delegate void OnDblClickDelegate(object o);
        public event OnDblClickDelegate OnDblClick;

        public delegate void OnClickDelegate(object o);
        public event OnClickDelegate OnClick;

        public TableRow ParentRow { get; set; }

        public TableCell()
        {
            InitializeComponent();
        }

        private void TableCell_Load(object sender, EventArgs e)
        {

        }

        private void TableCell_DoubleClick(object sender, EventArgs e)
        {
            if (this.OnDblClick != null)
                this.OnDblClick(sender);
        }

        private void TableCell_Click(object sender, EventArgs e)
        {
            if (this.OnClick != null)
                this.OnClick(sender);

            //this.BackColor = Color.SeaShell;
        }

        public PropertyPage Element
        {
            get
            {
                if (this.Controls.Count > 0)
                {
                    BaseDrawer drawer = (BaseDrawer) this.Controls[0];
                    return (PropertyPage)drawer.PropertyPage;
                }
                else
                    return null;
            }
            set
            {
                if (value != null)
                {
                    value.Drawer.Draw(value.Properties);
                    UserControl cc = (UserControl)value.Drawer;
                    cc.Width = this.Width - 10;
                    cc.Height = this.Height - 10;
                    cc.Tag = value;
                    cc.DoubleClick += Cc_DoubleClick;
                    cc.Click += Cc_Click;
                    this.Controls.Clear();
                    this.Controls.Add(cc);

                    if (this.OnStateChanged != null)
                        this.OnStateChanged(this);
                }
            }

        }

        private void Cc_Click(object sender, EventArgs e)
        {
            if (this.OnClick != null)
                this.OnClick(this);
        }

        private void Cc_DoubleClick(object sender, EventArgs e)
        {
            PropertyPage propertyPage = (PropertyPage)((UserControl)sender).Tag;
            propertyPage.ShowConfigurationWindow();

            //commonPropertyControl.ShowConfigureProperties();

        }
    }
}
