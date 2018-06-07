using Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    public partial class FormVisualDesigner : Form
    {
        Ctrls.Elements.PropertyPage ctrl = null;

        

        public FormVisualDesigner()
        {
            InitializeComponent();
        }

        private void FormVisualDesigner_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void elementPadCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void elementPadCtrl1_Load_1(object sender, EventArgs e)
        {

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

        private void elementPadCtrl1_OnClickEventHandler(PropertyPage ctrl)
        {
            this.ctrl = ctrl;
        }

        private void FormVisualDesigner_Resize(object sender, EventArgs e)
        {
            elementLayoutDesigner1.Width = this.Width - elementLayoutDesigner1.Left - 30;
            elementLayoutDesigner1.Height = this.Height - 60;
        }
    }
}
