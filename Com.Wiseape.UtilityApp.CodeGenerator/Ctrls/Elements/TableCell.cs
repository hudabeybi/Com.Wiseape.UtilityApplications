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

            this.BackColor = Color.SeaShell;
        }

        public CommonPropertyConfigurator Element
        {
            get
            {
                if (this.Controls.Count > 0)
                    return (CommonPropertyConfigurator)this.Controls[0];
                else
                    return null;
            }
        }
    }
}
