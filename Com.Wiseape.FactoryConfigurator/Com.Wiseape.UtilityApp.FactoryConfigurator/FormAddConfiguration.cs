using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.FactoryConfigurator.Model;

namespace Com.Wiseape.UtilityApp.FactoryConfigurator
{
    public partial class FormAddConfiguration : Form
    {
        public FormAddConfiguration()
        {
            InitializeComponent();
        }


        public FactoryConfigurationItem item { get; set; }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.item = null;
            this.Close();
        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            item = new FactoryConfigurationItem();
            item.ClassInfo = txtInfo.Text;
            item.ClassName = txtClassName.Text;
            item.DllName = txtDll.Text;
            item.Key = txtKey.Text;

            this.Close();
        }
    }
}
