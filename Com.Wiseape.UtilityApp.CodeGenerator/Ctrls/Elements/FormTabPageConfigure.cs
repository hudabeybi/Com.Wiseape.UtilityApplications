using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public partial class FormTabPageConfigure : Form
    {
        public bool Iscanceled { get; set; }
        public TabItem TabItem
        {
            set
            {
                this.txtTabLabel.Text = value.TabLabel;
                this.txtTabName.Text = value.TabName;
                if(value.ElementLayoutDesigner != null)
                    this.elementLayoutDesigner1 = value.ElementLayoutDesigner;
                if(value.TableRowObjects != null)
                {
                    this.elementLayoutDesigner1.TableRows = value.TableRowObjects;
                }
            }
            get
            {
                TabItem item = new TabItem(txtTabName.Text, txtTabLabel.Text);
                item.TableRowObjects = this.elementLayoutDesigner1.TableRows;
                item.ElementLayoutDesigner = this.elementLayoutDesigner1;
                return item;
            }
        }

        public string TabName
        {
            set
            {
                txtTabName.Text = value;
            }
            get
            {
                return txtTabName.Text;
            }
        }

        public string TabLabel
        {
            set
            {
                txtTabLabel.Text = value;
            }
            get
            {
                return txtTabLabel.Text;
            }
        }

        public FormTabPageConfigure()
        {
            InitializeComponent();
        }

        private void FormTabPageConfigure_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Iscanceled = true;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Iscanceled = false;
            this.Close();
        }


        Ctrls.Elements.PropertyPage ctrl = null;
        private void elementPadCtrl1_OnClickEventHandler(PropertyPage ctrl)
        {
            this.ctrl = ctrl;
        }

        private void elementLayoutDesigner1_Load(object sender, EventArgs e)
        {

        }

        private void elementLayoutDesigner1_OnTableCellClick(TableCell tableCell)
        {
            if (this.ctrl != null)
                this.elementLayoutDesigner1.AddElement(this.ctrl);
            this.ctrl = null;
        }
    }
}
