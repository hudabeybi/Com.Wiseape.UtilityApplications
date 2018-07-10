using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;
using System.IO;
using Com.Wiseape.UtilityApp.CodeGenerator.Business;

namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    public partial class FormCodeTemplate : Form
    {
        public bool IsGenerated { get; set; }
        public CodeTemplate SelectedCodeTemplate { get; set; }

        public CodeGeneratorProject Project { get; set; }
        public CodeGeneratorModule Module { get; set; }

        public FormCodeTemplate()
        {
            InitializeComponent();
        }

        private void FormCodeTemplate_Load(object sender, EventArgs e)
        {
            LoadCmbTemplateGroups();
        }

        void LoadCmbTemplateGroups()
        {
            List<CodeTemplateGroup> templateGroups = GetAllCodeTemplateGroups();
            cmbTemplateGroup.DataSource = templateGroups;
            cmbTemplateGroup.ValueMember = "TemplateGroupName";
            cmbTemplateGroup.DisplayMember = "TemplateGroupName";
        }

        void Init()
        {
            List<CodeTemplateGroup> groups = new List<CodeTemplateGroup>();

            CodeTemplateGroup group = new CodeTemplateGroup();
            group.TemplateGroupName = "Group Test 1";

            CodeTemplate tmp = new CodeTemplate();
            tmp.TemplateName = "Test";

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes("echo heeloo");

            tmp.TemplateCode = System.Convert.ToBase64String(plainTextBytes);
            List<CodeTemplate> temps = new List<CodeTemplate>();
            temps.Add(tmp);

            group.CodeTemplateList = temps;

            groups.Add(group);

            string xml = Utility.Serializer.XML.Serialize(groups);
            File.WriteAllText("CodeTemplates.XML", xml);
        }

        List<CodeTemplateGroup> GetAllCodeTemplateGroups(string find = "")
        {
            string xml = System.IO.File.ReadAllText("CodeTemplates.XML");
            List<CodeTemplateGroup> list = Utility.Serializer.XML.Deserialize<List<CodeTemplateGroup>>(xml);
            return list;
        }

        CodeTemplate GetCodeTemplate(string name)
        {
            string xml = System.IO.File.ReadAllText("CodeTemplates.XML");
            List<CodeTemplate> list = Utility.Serializer.XML.Deserialize<List<CodeTemplate>>(xml);
            
            foreach (CodeTemplate template in list)
            {
                if (template.TemplateName.ToLower().Contains(name.ToLower()))
                {
                    return template;
                }
            }

            return null;
        }


        void DeleteCodeTemplate(string name)
        {
            List<CodeTemplate> list = ((CodeTemplateGroup)cmbTemplateGroup.SelectedItem).CodeTemplateList;
            CodeTemplate tmp = null;
            foreach (CodeTemplate template in list)
            {
                if (template.TemplateName.ToLower() == name.ToLower())
                {
                    tmp = template;
                    break;
                }
            }

            if(tmp != null)
                list.Remove(tmp);
            SaveCodeTemplateGroups((List<CodeTemplateGroup>)cmbTemplateGroup.DataSource);
        }

        void UpdateCodeTemplate(CodeTemplate codeTemplate, string originalName)
        {
            CodeTemplateGroup group = (CodeTemplateGroup)cmbTemplateGroup.SelectedItem;
            List<CodeTemplate> list = group.CodeTemplateList;

            CodeTemplate tmp = null;
            foreach (CodeTemplate template in list)
            {
                if (template.TemplateName.ToLower().Contains(originalName.ToLower()))
                {
                    template.TemplateCode = codeTemplate.TemplateCode;
                    template.DefaultFilename = codeTemplate.DefaultFilename;
                    template.TemplateName = codeTemplate.TemplateName;
                    break;
                }
            }

            SaveCodeTemplateGroups((List<CodeTemplateGroup>)cmbTemplateGroup.DataSource);
        }

        void SaveCodeTemplate(List<CodeTemplate> list)
        {
            string xml = Utility.Serializer.XML.Serialize(list);
            File.WriteAllText("CodeTemplates.XML", xml);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int selectedIdx = cmbTemplateGroup.SelectedIndex;
            FormAddCodeTemplate frm = new FormAddCodeTemplate();
            frm.ShowDialog();
            if(frm.CodeTemplate != null)
            {
                List<CodeTemplate> list = GetSelectedTemplateGroup().CodeTemplateList;
                list.Add(frm.CodeTemplate);
                SaveCodeTemplateGroups( (List<CodeTemplateGroup>) cmbTemplateGroup.DataSource);
                LoadCmbTemplateGroups();
                cmbTemplateGroup.SelectedIndex = selectedIdx;
                DisplaySelectedTemplateGroup();
            }
        }

        CodeTemplate GetSelectedCodeTemplate()
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                CodeTemplate codeTemplate = (CodeTemplate)dataGridView1.SelectedRows[0].DataBoundItem;
                return codeTemplate;
            }
            return null;
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //this.dataGridView1.DataSource = GetAllCodeTemplates(txtSearch.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                CodeTemplate codeTemplate = (CodeTemplate)this.dataGridView1.SelectedRows[0].DataBoundItem;
                string templateName = codeTemplate.TemplateName;
                //TextEditor.TextEditorForm frm = new TextEditor.TextEditorForm();
                //frm.Code = codeTemplate.TemplateCodePlain;
                //frm.ShowDialog();

                FormAddCodeTemplate frm = new FormAddCodeTemplate();
                frm.CodeTemplate = codeTemplate;
                frm.ShowDialog();
                if(frm.IsCanceled == false)
                {
                    codeTemplate = frm.CodeTemplate;
                    UpdateCodeTemplate(codeTemplate, templateName);

                    DisplaySelectedTemplateGroup();
                    this.dataGridView1.Refresh();
                }
                   

            }
        }

        void ShowCodeDialog(CodeTemplate codeTemplate)
        {
            TextEditor.TextEditorForm frm = new TextEditor.TextEditorForm();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIdx = this.cmbTemplateGroup.SelectedIndex;
                CodeTemplate item = (CodeTemplate) this.dataGridView1.SelectedRows[0].DataBoundItem;
                DialogResult res = MessageBox.Show("You are going to delete '" + item.TemplateName + "'.\r\nAre you sure?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {

                    CodeTemplate codeTemplate = (CodeTemplate)this.dataGridView1.SelectedRows[0].DataBoundItem;
                    DeleteCodeTemplate(codeTemplate.TemplateName);
                    LoadCmbTemplateGroups();
                    cmbTemplateGroup.SelectedIndex = selectedIdx;
                    DisplaySelectedTemplateGroup();
                }
               
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                IsGenerated = true;
                SelectedCodeTemplate = (CodeTemplate)this.dataGridView1.SelectedRows[0].DataBoundItem;

                CodeTemplate selectedCodeTemplate = SelectedCodeTemplate;
                string result = CodeCompiler.GenerateCodeForModule(this.Project, this.Module, selectedCodeTemplate.TemplateCodePlain);
                FormCodeResult frmREsult = new FormCodeResult();
                frmREsult.Result = result;
                frmREsult.Show();
                
            }
        }

        private void cmbTemplateGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedTemplateGroup();
        }

        void DisplaySelectedTemplateGroup()
        {
            CodeTemplateGroup group = GetSelectedTemplateGroup();
            if (group != null)
            {
                //this.dataGridView1.DataSource = new List<CodeTemplate>();
                //this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = group.CodeTemplateList;
                
            }
        }

        private void btnAddTemplateGroup_Click(object sender, EventArgs e)
        {
            FormAddGroup frm = new FormAddGroup();
            frm.OnAddTemplateGroup += Frm_OnAddTemplateGroup;
            frm.ShowDialog();
        }

        private void Frm_OnAddTemplateGroup(string templateGroupName, object sender)
        {
            FormAddGroup frm = (FormAddGroup)sender;
            frm.Close();

            List<CodeTemplateGroup> groups = GetAllCodeTemplateGroups();
            CodeTemplateGroup group = null;
            if (frm.IsEdit)
            {
                CodeTemplateGroup curGroup = GetSelectedTemplateGroup();
                group = FindTemplateGroupByName(groups, curGroup.TemplateGroupName);
                if(group != null)
                    group.TemplateGroupName = templateGroupName;
            }
            else
            {
                group = CreateNewTemplateGroup(templateGroupName);
                groups.Add(group);
            }            
            
            SaveCodeTemplateGroups(groups);
            MessageBox.Show("Saved");
            LoadCmbTemplateGroups();
            cmbTemplateGroup.SelectedIndex = cmbTemplateGroup.Items.Count - 1;
        }

        CodeTemplateGroup GetSelectedTemplateGroup()
        {
            return (CodeTemplateGroup)cmbTemplateGroup.SelectedItem;
        }

        CodeTemplateGroup FindTemplateGroupByName(List<CodeTemplateGroup> groups, string name)
        {
            foreach(CodeTemplateGroup group in groups)
            {
                if (group.TemplateGroupName == name)
                    return group;
            }
            return null;
        }

        CodeTemplateGroup CreateNewTemplateGroup(string templateGroupName)
        {
            CodeTemplateGroup group = new CodeTemplateGroup();
            group.TemplateGroupName = templateGroupName;
            return group;
        }

        void SaveCodeTemplateGroups(List<CodeTemplateGroup> groups)
        {
            string xml = Utility.Serializer.XML.Serialize(groups);
            File.WriteAllText("CodeTemplates.XML", xml);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddGroup frm = new FormAddGroup();
            frm.OnAddTemplateGroup += Frm_OnAddTemplateGroup;
            if(cmbTemplateGroup.SelectedIndex > -1)
                frm.TemplateGroupName = (string)cmbTemplateGroup.SelectedValue;
            frm.IsEdit = true;
            frm.ShowDialog();
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure ?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                CodeTemplateGroup group = GetSelectedTemplateGroup();
                List<CodeTemplateGroup> groups = (List<CodeTemplateGroup>)cmbTemplateGroup.DataSource;
                groups.Remove(group);
                SaveCodeTemplateGroups(groups);
                LoadCmbTemplateGroups();
                cmbTemplateGroup.SelectedIndex = 0;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool check = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                CodeTemplate template = (CodeTemplate)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                template.Checked = check;
                UpdateCodeTemplate(template, template.TemplateName);
                DisplaySelectedTemplateGroup();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                bool check = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                CodeTemplate template = (CodeTemplate)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                template.Checked = check;
                UpdateCodeTemplate(template, template.TemplateName);
                DisplaySelectedTemplateGroup();
            }
        }

        string path = "";
        private void btnGenerateAll_Click(object sender, EventArgs e)
        {
            FormSavePath frm = new FormSavePath();
            frm.ShowDialog();
            if(frm.Canceled == false)
            {
                infos.Clear();
                path = frm.Path;
                bool generateAllModules = frm.GenerateAllModule;
                this.OnGenerateDoneEvent += FormCodeTemplate_OnGenerateDoneEvent;
                this.OnGenerateInfoEvent += FormCodeTemplate_OnGenerateInfoEvent;
                RunGenerateCodeThread(generateAllModules);
            }
        }

        List<String> infos = new List<string>();
        private void FormCodeTemplate_OnGenerateInfoEvent(string info)
        {
            infos.Add(info);
            DisplayInfo(info);
        }

        private void FormCodeTemplate_OnGenerateDoneEvent(CodeGeneratorModule module)
        {
            DisplayInfo("Done!");
        }

        void DisplayInfo(string info)
        {
            if (this.InvokeRequired)
                this.Invoke(new Action<string>(DisplayInfo), info);
            else
                lblInfo.Text = info;
        }

        void RunGenerateCodeThread(bool generateAllModules)
        {
            this.pgBar.Value = 0;

            System.Threading.ParameterizedThreadStart threadStart = new System.Threading.ParameterizedThreadStart(RunGenerateCode);
            System.Threading.Thread thread = new System.Threading.Thread(threadStart);
            thread.Start(generateAllModules);
        }


        int currentProgress = 0;
        int maxValue = 0;
        void RunGenerateCode(object generateAllModule)
        {
            currentProgress = 0;
            int totalCodeTemplates = 0;
            List<CodeTemplate> codeTemplates = (List<CodeTemplate>)dataGridView1.DataSource;
            foreach(CodeTemplate codeTemplate in codeTemplates)
            {
                if (codeTemplate.Checked)
                    totalCodeTemplates++;
            }

            if ((bool)generateAllModule)
            {
                maxValue = totalCodeTemplates * Project.Modules.Count;
                this.SetPgBarMax(maxValue);
                foreach (CodeGeneratorModule module in Project.Modules)
                {
                    GenerateAll(path, Project, module);
                }
            }
            else
            {
                maxValue = totalCodeTemplates;
                this.SetPgBarMax(maxValue);
                GenerateAll(path, Project, Module);
            }
        }

        void SetPgBarValue(int value)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action<int>(SetPgBarValue), value);
            }
            else
            {
                this.pgBar.Value = value;
            }
        }

        void SetPgBarMax(int value)
        {
            if(this.InvokeRequired)
            {
                Invoke(new Action<int>(SetPgBarMax), value);
            }
            else
            {
                this.pgBar.Maximum = value;
            }
        }


        public delegate void OnGenerateDoneDelegate(CodeGeneratorModule module);
        public event OnGenerateDoneDelegate OnGenerateDoneEvent;

        public delegate void OnGenerateInfoDelegate(string info);
        public event OnGenerateInfoDelegate OnGenerateInfoEvent;

        void GenerateAll(string path, CodeGeneratorProject project, CodeGeneratorModule module)
        {
            List<CodeTemplate> codeTemplates = (List<CodeTemplate>)dataGridView1.DataSource;
            foreach(CodeTemplate template in codeTemplates)
            {
                if(template.Checked)
                {
                    Info("Generating " + module.SessionName + " : " + template.TemplateName);
                    
                    string filename = template.DefaultFilename.Replace("<companyname>", project.Company).Replace("<projectname>", project.ProjectName).Replace("<modulename>", module.ModuleName);
                    DataSourceTable table = (DataSourceTable)module.Datasource;
                    string tableName = table.TableName;
                    filename = filename.Replace("<tablename>", tableName);
                    filename = path + "/" + filename;

                    string dir = System.IO.Path.GetDirectoryName(filename);
                    if(System.IO.Directory.Exists(dir)==false)
                    {
                        System.IO.Directory.CreateDirectory(dir);
                    }

                    Info("Generating file : " + module.SessionName + " : " + filename);

                    string result = CodeCompiler.GenerateCodeForModule(project, module, template.TemplateCodePlain);
                    result = result.Replace("\\%", "%");
                    
                    try
                    {
                        System.IO.File.WriteAllText(filename, result);
                        Info("Done ");
                    }
                    catch(Exception err)
                    {
                        Info(err.Message);
                    }
                   

                    currentProgress++;
                    this.SetPgBarValue(currentProgress);
                }

            }

            if (this.OnGenerateDoneEvent != null)
                this.OnGenerateDoneEvent(module);
            //MessageBox.Show("Done");
        }

        void Info(string info)
        {
            if (this.OnGenerateInfoEvent != null)
                this.OnGenerateInfoEvent(info);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            FormCodeResult result = new FormCodeResult();
            result.Result = String.Join("\r\n", infos.ToArray());
            result.Show();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyCodeTemplates();
        }

        List<CodeTemplate> codeTemplatesCopied = new List<CodeTemplate>();
        void CopyCodeTemplates()
        {
            codeTemplatesCopied.Clear();
            List<CodeTemplate> list = GetSelectedTemplateGroup().CodeTemplateList;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                CodeTemplate tmp = (CodeTemplate)row.DataBoundItem;

                CodeTemplate newTmp = new CodeTemplate();
                newTmp.Checked = tmp.Checked;
                newTmp.DefaultFilename = tmp.DefaultFilename;
                newTmp.SavedPath = tmp.SavedPath;
                newTmp.TemplateCode = tmp.TemplateCode;
                newTmp.TemplateName = tmp.TemplateName;

                newTmp.TemplateName = tmp.TemplateName + " Copy " + DateTime.Now.ToString();
                codeTemplatesCopied.Add(newTmp);
            }

            codeTemplatesCopied.Reverse();
        }

        void PasteCodeTemplates()
        {
            int selectedIdx = cmbTemplateGroup.SelectedIndex;

            List<CodeTemplate> list = GetSelectedTemplateGroup().CodeTemplateList;
            list.AddRange(codeTemplatesCopied);
            SaveCodeTemplateGroups((List<CodeTemplateGroup>)cmbTemplateGroup.DataSource);
            LoadCmbTemplateGroups();
            cmbTemplateGroup.SelectedIndex = selectedIdx;
            DisplaySelectedTemplateGroup();

        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            PasteCodeTemplates();
        }
    }
}
