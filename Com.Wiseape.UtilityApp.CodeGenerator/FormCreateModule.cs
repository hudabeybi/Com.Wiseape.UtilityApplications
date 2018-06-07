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
    public partial class FormCreateModule : Form
    {
        Model.CodeGeneratorModule module = null;
        public CodeGenerator.Model.CodeGeneratorModule Module {
            get
            {
                module = GetModule();
                return module;
            }
            set
            {
                module = value;
                DisplayModule(value);
            }
        }
        public FormCreateModule()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCreateModule_Load(object sender, EventArgs e)
        {

        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        Model.CodeGeneratorModule GetModule()
        {
            if (module == null)
                this.module = new Model.CodeGeneratorModule();
            module.ModuleName = txtModuleName.Text;
            module.ModuleDesc = txtModuleDesc.Text;
            module.SessionName = txtModuleSession.Text;
            return module;
        }

        void DisplayModule(Model.CodeGeneratorModule module)
        {
            txtModuleName.Text = module.ModuleName;
            txtModuleSession.Text = module.SessionName;
            txtModuleDesc.Text = module.ModuleDesc;
        }
    }
}
