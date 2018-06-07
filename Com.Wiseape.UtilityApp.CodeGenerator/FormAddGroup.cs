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
    public partial class FormAddGroup : Form
    {

        public delegate void AddTemplateGroupHandler(string templateName, object sender);
        public event AddTemplateGroupHandler OnAddTemplateGroup;

        public bool IsEdit { get; set; }

        public string TemplateGroupName
        {
            set
            {
                this.textBox1.Text = value;
            }
        }

        public FormAddGroup()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(this.OnAddTemplateGroup != null)
            {
                this.OnAddTemplateGroup(this.textBox1.Text, this);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
