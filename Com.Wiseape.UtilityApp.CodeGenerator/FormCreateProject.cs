using Com.Wiseape.UtilityApp.CodeGenerator.Model;
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
    public partial class FormCreateProject : Form
    {
        public CodeGeneratorProject Project
        {
            set
            {
                if (value != null)
                {
                    txtCompany.Text = value.Company;
                    txtProjectName.Text = value.ProjectName;
                    txtProjectDesc.Text = value.ProjectDesc;
                    this.Text = "Edit Project";
                    this.btnCreate.Text = "Save";
                }
            }
            get
            {
                CodeGenerator.Model.CodeGeneratorProject project = new Model.CodeGeneratorProject();
                project.ProjectDesc = txtProjectDesc.Text;
                project.ProjectName = txtProjectName.Text;
                project.Company = txtCompany.Text;
                return project;
            }
        }
        public FormCreateProject()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Project = null;
            this.Close();
        }

        private void FormCreateProject_Load(object sender, EventArgs e)
        {

        }
    }
}
