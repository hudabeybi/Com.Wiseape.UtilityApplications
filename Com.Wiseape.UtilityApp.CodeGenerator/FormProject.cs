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
    public partial class FormProject : Form
    {
        public bool IsCanceled { get; set; }

        CodeGeneratorProject currentProject;
        public CodeGeneratorProject CurrentProject {
            get
            {
                return currentProject;
            }
            set
            {
                currentProject = value;
                DisplayCurrentProject();
            }
        }
        public FormProject()
        {
            InitializeComponent();
            this.IsCanceled = true;
        }

        public CodeGenerator.Model.CodeGeneratorProject CodeGeneratorProject { get; set; }
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            this.IsCanceled = false;
            CodeGeneratorProject project = new Model.CodeGeneratorProject();
            project.ProjectName = txtProjectName.Text;
            project.ProjectDesc = txtProjectDesc.Text;
            this.CodeGeneratorProject = project;

            //CodeGenerator.Model.CodeGeneratorModule module = new Model.CodeGeneratorModule();
            //module.ModuleName = "New Module";

            //this.CodeGeneratorProject.Modules.Add(module);
            this.Close();
        }

        private void btnOpenProject_Click(object sender, EventArgs e)
        {
            this.IsCanceled = false;
            this.Close();
        }

        private void Dlg_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dlg = (OpenFileDialog)sender;
            string filename = dlg.FileName;
            string xml = System.IO.File.ReadAllText(filename);
            CodeGeneratorProject project = Utility.Serializer.XML.Deserialize<CodeGeneratorProject>(xml);
            CurrentProject = project;
            IsCanceled = true;
        }

        void DisplayCurrentProject()
        {
            txtProjectName.Text = CurrentProject.ProjectName;
            txtProjectDesc.Text = CurrentProject.ProjectDesc;
        }

        private void rdNewProject_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNewProject.Checked)
            {
                btnCreateProject.Visible = true;
                btnOpenProject.Visible = false;
            }
            else
            {
                btnCreateProject.Visible = false;
                btnOpenProject.Visible = true;
            }

        }

        private void rdOpenProject_CheckedChanged(object sender, EventArgs e)
        {
            if(rdOpenProject.Checked)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Wiseape Generator Project|*.Wisegenproj";
                dlg.FileOk += Dlg_FileOk;
                dlg.ShowDialog();
            }
        }

        private void FormProject_Load(object sender, EventArgs e)
        {
            btnCreateProject.Top = btnOpenProject.Top;
            btnCancel.Top = btnOpenProject.Top + btnOpenProject.Height + 10;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsCanceled = true;
            this.Close();
        }
    }
}
