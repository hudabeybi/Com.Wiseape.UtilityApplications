using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator;
using Com.Wiseape.UtilityApp.FactoryConfigurator;

namespace Com.Wiseape.UtilityApp.MainApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void factoryConfiguratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FactoryConfigurator.FormMain frm = new FactoryConfigurator.FormMain();
            frm.MdiParent = this;
            frm.Show();
        }

        private void codeGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeGenerator.FormMain frm = new CodeGenerator.FormMain();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void uIDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisualDesigner frm = new FormVisualDesigner();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
