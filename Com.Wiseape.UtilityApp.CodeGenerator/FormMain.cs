using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator.ModelTypeConfigurator;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;
using System.Data.SqlClient;
using Com.Wiseape.UtilityApp.CodeGenerator.Business;

namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    public partial class FormMain : Form
    {
        public CodeGeneratorProject CurrentProject = null;
        public FormMain()
        {
            InitializeComponent();

        }

        void DisplayModules( List<CodeGeneratorModule> modules)
        {
            TreeNode root = tvProjectItems.Nodes[0];
            foreach(CodeGeneratorModule module in modules)
            {
                TreeNode newNode = root.Nodes.Add(module.ModuleName);
                newNode.Tag = module;
            }
            tvProjectItems.SelectedNode = root.Nodes[0];
        }

        private void btnDeleteConnection_Click(object sender, EventArgs e)
        {
            if(cmbSavedConnection.SelectedItem != null)
            {
                DeleteSavedConnection(((SavedConnection)cmbSavedConnection.SelectedItem).ConnectionName);
                List<SavedConnection> savedConnections = LoadSavedConnectionsFromFile();
                DisplaySavedConnections(savedConnections);
            }
        }

        string GetSavedConnectionFileContent(string filename)
        {
            if(System.IO.File.Exists(filename) == false)
            {
                SavedConnection con = new SavedConnection();
                con.ConnectionName = "Test";
                con.ConnectionString = "Test";
                List<SavedConnection> list = new List<SavedConnection>();
                list.Add(con);

                string xml = Utility.Serializer.XML.Serialize(list);
                System.IO.File.WriteAllText(filename, xml);
            }
            string content = System.IO.File.ReadAllText(filename);
            return content;
        }

        List<SavedConnection> LoadSavedConnectionsFromFile()
        {
            string xml = GetSavedConnectionFileContent("SavedConnections.DAT");
            List<SavedConnection> list = (List<SavedConnection>)Utility.Serializer.XML.Deserialize<List<SavedConnection>>(xml);
            return list;
        }

        void SaveSavedConnections(List<SavedConnection> list)
        {
            string xml = Utility.Serializer.XML.Serialize(list);
            System.IO.File.WriteAllText("SavedConnections.DAT", xml);
        }

        SavedConnection GetSavedConnectionByName(string name)
        {
            List<SavedConnection> savedConnections = LoadSavedConnectionsFromFile();
            foreach(SavedConnection conn in savedConnections)
            {
                if (conn.ConnectionName.ToLower() == name)
                    return conn;
            }
            return null;
        }


        void DeleteSavedConnection(string name)
        {
            SavedConnection con = null;
            List<SavedConnection> savedConnections = LoadSavedConnectionsFromFile();
            foreach (SavedConnection conn in savedConnections)
            {
                if (conn.ConnectionName.ToLower() == name.ToLower())
                    con = conn;
            }
            savedConnections.Remove(con);
            SaveSavedConnections(savedConnections);
        }

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            FormAddConnection frm = new FormAddConnection();
            frm.ShowDialog();
            if(frm.IsCanceled == false)
            {
                SavedConnection con = frm.SavedConnection;
                List<SavedConnection> conns = LoadSavedConnectionsFromFile();
                conns.Add(con);
                SaveSavedConnections(conns);
                DisplaySavedConnections(conns);
            }
        }

        void DisplaySavedConnections(List<SavedConnection> conns)
        {
            cmbSavedConnection.DataSource = conns;
            cmbSavedConnection.ValueMember = "ConnectionName";
            cmbSavedConnection.DisplayMember = "ConnectionName";
        }

        bool dontRun = false;
        private void FormMain_Load(object sender, EventArgs e)
        {

            List<SavedConnection> savedConnections = LoadSavedConnectionsFromFile();
            DisplaySavedConnections(savedConnections);

            InitCmbModelTypes();

            this.WindowState = FormWindowState.Maximized;
            if (CurrentProject == null)
            {
                createNewToolStripMenuItem1.Visible = false;
                this.groupSessionModule.Visible = false;
            }

        }

        void InitCmbModelTypes()
        {
            dontRun = true;
            cmbModelType.DataSource = null;
            List<ModelType> modelTypeList = GetModelTypeList();
            cmbModelType.DisplayMember = "ModelTypeName";
            cmbModelType.ValueMember = "ModelTypeName";
            cmbModelType.DataSource = GetModelTypeList();
            cmbModelType.SelectedIndex = -1;
            dontRun = false;
        }

        List<ModelType> GetModelTypeList()
        {
            List<ModelType> modelTypeList = new List<ModelType>();
            modelTypeList.Add(new ModelType("Data Validator", new Com.Wiseape.UtilityApp.CodeGenerator.ModelTypeConfigurator.DataValidatorConfigurator()));
            modelTypeList.Add(new ModelType("UI Definition", new Com.Wiseape.UtilityApp.CodeGenerator.ModelTypeConfigurator.UIConfiguratorModelType()));
            modelTypeList.Add(new ModelType("Logic/Functions Definition", new Com.Wiseape.UtilityApp.CodeGenerator.ModelTypeConfigurator.LogicConfiguratorModelType()));
            return modelTypeList;
        }

        int GetCmbSelectedTypeSelectedIndex(string modelTypeName)
        {
            int i = 0;
            foreach(ModelType type in cmbModelType.Items)
            {
                if (type.ModelTypeName == modelTypeName)
                    return i;
                i++;
            }
            return -1;
        }

        int GetCmbSelectedDatasourceSelectedIndex(string datasourceName)
        {
            int i = 0;
            foreach (DataSourceTable table in cmbDatasource.Items)
            {
                if (table.TableName == datasourceName)
                    return i;
                i++;
            }
            return -1;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void cmbModelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelType selectedItem = (ModelType)cmbModelType.SelectedItem;
            if (cmbModelType.SelectedIndex != -1 && dontRun == false)
            {
                formPanel.Controls.Clear();
                formPanel.Controls.Add((UserControl) selectedItem.ModelTypeConfigurator);
                this.formPanel.Controls[0].Width = this.formPanel.Width - 10;
                this.formPanel.Controls[0].Height = this.formPanel.Height - 10;

                if(selectedItem.ModelTypeConfigurator.GetType() == typeof(UIConfiguratorModelType))
                {
                    UIConfiguratorModelType configurator = (UIConfiguratorModelType)selectedItem.ModelTypeConfigurator;
                    configurator.OnVisualDesignerButtonClick += Configurator_OnVisualDesignerButtonClick;
                }
                FillCmbDatasource();
            }
        }

        private void Configurator_OnVisualDesignerButtonClick(DataSourceUITable uiTable)
        {
            OpenVisualDesigner(uiTable);
        }

        void OpenVisualDesigner(DataSourceUITable uiTable)
        {
            FormGenerateUIType frmType = new FormGenerateUIType();
            frmType.ShowDialog();

            GenerateUIType uiType = frmType.UIType;

            //DataSourceUITable newTable = (DataSourceUITable)gridColumns.DataSource;
            FormVisualDesigner frm = new FormVisualDesigner();
            frm.UIType = uiType;
            frm.CurrentProject = this.CurrentProject;
            frm.CurrentModule = this.CurrentModule;
            frm.ShowDialog();
        }


        public List<DataSourceTable> GetTables(string conString)
        {
            SqlServerSchema sqlserverSchema = new SqlServerSchema();
            return sqlserverSchema.GetTables(conString);
        }

        void FillCmbDatasource()
        {
            if(cmbSavedConnection.SelectedItem != null)
            {
                SavedConnection connection = (SavedConnection)cmbSavedConnection.SelectedItem;
                string connectionString = connection.ConnectionString;
                List<DataSourceTable> tables = GetTables(connectionString);
                
                cmbDatasource.ValueMember = "TableName";
                cmbDatasource.DisplayMember = "FullTableName";
                cmbDatasource.DataSource = tables;


            }
        }

        private void cmbDatasource_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelType selectedItem = (ModelType)cmbModelType.SelectedItem;
            DataSourceTable table = (DataSourceTable)cmbDatasource.SelectedItem;
            if (selectedItem != null)
            {
                IAssemblyNameGenerator generator = (IAssemblyNameGenerator)selectedItem.ModelTypeConfigurator;
                string name = generator.GenerateNamespace(txtProjectName.Text, txtModuleName.Text, table.TableName);
                txtNamespace.Text = name;
                name = generator.GenerateClassName(txtProjectName.Text, txtModuleName.Text, table.TableName);
                txtClassName.Text = name;

                InitItemsFromDataSource(selectedItem, table);

                //CurrentModule.Datasource = table;
            }
        }

        void InitItemsFromDataSource(ModelType selectedItem, DataSourceTable table)
        {
            IModelTypeConfigurator configurator = (IModelTypeConfigurator)selectedItem.ModelTypeConfigurator;
            configurator.InitFromDatasource(table);
        }

        private void btnSaveToProject_Click(object sender, EventArgs e)
        {
            if(this.CurrentProject == null)
            {
                CreateProject();
            }

            SaveToProject();
        }

        void CreateProject()
        {
            FormProject frmProject = new FormProject();
            frmProject.ShowDialog();
            if(frmProject.IsCanceled == false)
            {
                this.CurrentProject = frmProject.CodeGeneratorProject;
            }
        }

        void CreateProject2()
        {

        }

        void SaveToProject()
        {
            TreeNode node = tvProjectItems.SelectedNode;

            string moduleName = txtModuleName.Text;
            CodeGeneratorModule mod = null;
            int i = 0;
            foreach(CodeGeneratorModule module in CurrentProject.Modules)
            {
                if(module.ModuleName == moduleName)
                {
                    mod = module;
                    break;
                }
                i++;
            }

            if (mod == null)
            {
                mod = new CodeGeneratorModule();
                CurrentProject.Modules.Add(mod);
            }
            else
                CurrentProject.Modules[i] = mod;

            mod = PopulateModule(mod);
            SaveProjectToFile();
            DisplayProject();
        }

        void SaveProjectToFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = CurrentProject.ProjectName + ".Wisegenproj";
            dlg.FileOk += Dlg_FileOk;
            dlg.ShowDialog();
        }

        void DisplayProject()
        {
            tvProjectItems.Nodes.Clear();
            TreeNode projectNode = tvProjectItems.Nodes.Add(CurrentProject.ProjectName);
            projectNode.Tag = CurrentProject;
            foreach(CodeGeneratorModule module in CurrentProject.Modules)
            {
                TreeNode newNode = projectNode.Nodes.Add(module.SessionName);
                newNode.Tag = module;
            }

            createNewToolStripMenuItem1.Visible = true;
        }

        private void Dlg_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog dlg = (SaveFileDialog)sender;
            SaveProject(dlg.FileName);
            MessageBox.Show("Saved");
        }

        void SaveProject(string filename)
        {
            CurrentProject.Filename = filename;
            string xml = ProjectToJson();
            try
            {
                
                System.IO.File.WriteAllText(filename, xml);
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Saving failed: " + err.Message);
            }
        }

        string ProjectToXml()
        {
            string xml = Utility.Serializer.XML.Serialize(this.CurrentProject);
            return xml;
        }

        string ProjectToJson()
        {
            string json = Utility.Serializer.Json.Serialize(this.CurrentProject);
            return json;
        }

        CodeGeneratorModule PopulateModule(CodeGeneratorModule module)
        {
            module.ModuleName = txtModuleName.Text;
            module.Namespace = txtNamespace.Text;
            module.Classname = txtClassName.Text;
            module.Connection = (SavedConnection) cmbSavedConnection.SelectedItem;
            //if(module.Datasource == null)
            //module.Datasource = (DataSourceTable)cmbDatasource.SelectedItem;

            ModelType modelType = (ModelType)cmbModelType.SelectedItem;
            module.Datasource = (DataSourceTable)modelType.Datasource;

            module.ModelType = ((ModelType)cmbModelType.SelectedItem).Clone();
            return module;
        }

        public CodeGeneratorModule CurrentModule
        {
            get
            {
                if (tvProjectItems.SelectedNode != null)
                {
                    CodeGeneratorModule module = (CodeGeneratorModule)tvProjectItems.SelectedNode.Tag;
                    return module;
                }
                else
                    return null;
            }
        }

        private void tvProjectItems_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Tag != null && node.Tag.GetType() == typeof(CodeGeneratorModule))
            {
                
                DisplayModule((CodeGeneratorModule)node.Tag);
            }
        }

        void DisplayModule(CodeGeneratorModule module)
        {
            txtProjectName.Text = this.CurrentProject.ProjectName;
            txtModuleName.Text = module.ModuleName;
            groupSessionModule.Visible = true;
            if(module.Connection != null)
                cmbSavedConnection.SelectedValue = module.Connection.ConnectionName;
            
            
            txtClassName.Text = module.Classname;
            txtNamespace.Text = module.Namespace;


            if (module.ModelType != null)
            {
                cmbModelType.SelectedIndex = GetCmbSelectedTypeSelectedIndex(module.ModelType.ModelTypeName);
            }

            if (module.ModelType != null)
            {
                //formPanel.Controls.Clear();
                //formPanel.Controls.Add((UserControl)module.ModelType.ModelTypeConfigurator);
                //module.ModelType.ModelTypeConfigurator.UpdateDatasource(module.ModelType.ModelTypeConfigurator.GetDatasource());
            }

            if (module != null)
            {
                if (module.Datasource != null)
                    cmbDatasource.SelectedIndex = GetCmbSelectedDatasourceSelectedIndex(module.Datasource.TableName);

                ModelType modelType = (ModelType)cmbModelType.SelectedItem;
                //modelType.Datasource = module.ModelType.Datasource;
                //if(module.ModelType != null)
                if(modelType != null)
                        modelType.Datasource = module.Datasource;
            }
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
           
        }

        private void formPanel_Resize(object sender, EventArgs e)
        {
            if(this.formPanel.Controls.Count > 0)
            {
                this.formPanel.Controls[0].Width = this.formPanel.Width;
                this.formPanel.Controls[0].Height = this.formPanel.Height;
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            this.groupSessionModule.Width = this.Width - 20 - tvProjectItems.Width;
            this.groupSessionModule.Height = this.Height - 10;
            this.formPanel.Width = this.Width - this.groupSessionModule.Left - 20;
            this.formPanel.Height = this.Height - this.formPanel.Top - 60;
            tvProjectItems.Top = 15;
            tvProjectItems.Height = this.Height - 60;
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateProject frm = new FormCreateProject();
            frm.ShowDialog();
            if (frm.Project != null)
            {
                CurrentProject = frm.Project;
                SaveProjectToFile();
                DisplayProject();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openProjectDialog = new OpenFileDialog();
            openProjectDialog.FileOk += OpenProjectDialog_FileOk;
            openProjectDialog.ShowDialog();
        }

        private void OpenProjectDialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dlg = (OpenFileDialog)sender;
            string filename = dlg.FileName;
            string json = System.IO.File.ReadAllText(filename);

            CodeGeneratorProject project = Utility.Serializer.Json.Deserialize<CodeGeneratorProject>(json);
            CurrentProject = project;
            CurrentProject.Filename = filename;
            DisplayProject();
        }

        private void createNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateNewModule();
        }

        void CreateNewModule()
        {
            FormCreateModule frm = new FormCreateModule();
            frm.ShowDialog();
            if (frm.Module != null)
            {
                InitCmbModelTypes();
                CodeGeneratorModule module = frm.Module;
                CurrentProject.Modules.Add(module);
                DisplayProject();
                SelectModuleNode(module.SessionName);
            }
        }

        void EditNewModule()
        {
            FormCreateModule frm = new FormCreateModule();
            frm.Module = CurrentModule;
            frm.ShowDialog();
            if (frm.Module != null)
            {
                InitCmbModelTypes();
                CodeGeneratorModule module = frm.Module;
                SaveProject(CurrentProject.Filename);
                DisplayProject();
                tvProjectItems.ExpandAll();
                SelectModuleNode(module.SessionName);
            }
        }

        void DeleteModule()
        {
            DialogResult result = MessageBox.Show("Confirm deletion", "Are you sure you want to delete it?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CodeGeneratorModule module = (CodeGeneratorModule)this.tvProjectItems.SelectedNode.Tag;
                CurrentProject.Modules.Remove(module);
                SaveProject(CurrentProject.Filename);
                DisplayProject();
                tvProjectItems.ExpandAll();
            }
        }

        void SelectModuleNode(string moduleName)
        {
            TreeNode rootNode = tvProjectItems.Nodes[0];
            foreach(TreeNode node in rootNode.Nodes)
            {
                if(node.Tag.GetType() == typeof(CodeGeneratorModule) && ((CodeGeneratorModule)node.Tag).SessionName == moduleName)
                {
                    tvProjectItems.SelectedNode = node;
                    break;
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateModule(CurrentModule);
            if (CurrentProject != null)
            {
                SaveProject(CurrentProject.Filename);
                MessageBox.Show("Saved");
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PopulateModule(CurrentModule);
            SaveProjectToFile();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = tvProjectItems.SelectedNode;
            if(node.Tag.GetType() == typeof(CodeGeneratorModule))
            {
                CurrentProject.Modules.Remove((CodeGeneratorModule)node.Tag);
                if (CurrentProject != null)
                    SaveProject(CurrentProject.Filename);
                DisplayProject();
            }
        }

        private void generateCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCodeTemplate frm = new FormCodeTemplate();
            frm.Project = CurrentProject;
            frm.Module = CurrentModule;
            frm.ShowDialog();
            /*
             * 
            if(frm.IsGenerated)
            {
                CodeTemplate selectedCodeTemplate = frm.SelectedCodeTemplate;
                string result = CodeCompiler.GenerateCodeForModule(CurrentProject, CurrentModule, selectedCodeTemplate.TemplateCodePlain);
                FormCodeResult frmREsult = new FormCodeResult();
                frmREsult.Result = result;
                frmREsult.Show();
            }
            
             */
        }

        private void formPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            this.formPanel.Controls[0].Width = this.formPanel.Width;
            this.formPanel.Controls[0].Height = this.formPanel.Height;
        }

        private void cmbSavedConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModelType.SelectedIndex = -1;
            
        }

        private void editProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateProject project = new FormCreateProject();
            project.Project = CurrentProject;
            project.ShowDialog();

            CurrentProject.ProjectName = project.Project.ProjectName;
            CurrentProject.Company = project.Project.Company;
            CurrentProject.ProjectDesc = project.Project.ProjectDesc;

            SaveProject(CurrentProject.Filename);

            DisplayProject();
            

        }

        private void createNewModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewModule();
        }

        private void editModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNewModule();
        }

        private void deleteModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteModule();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ModelType selectedItem = (ModelType)cmbModelType.SelectedItem;
            DataSourceTable table = (DataSourceTable)cmbDatasource.SelectedItem;
            InitItemsFromDataSource(selectedItem, table);
        }
    }
}
