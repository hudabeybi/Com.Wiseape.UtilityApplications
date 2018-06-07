using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    public partial class FormUIConfig : Form
    {
        public bool IsCanceled { get; set; }
        public IConfigContent ConfigContent { get; set; }

        public Model.DataColumn DataColumn { get; set; }
        public FormUIConfig()
        {
            InitializeComponent();
            IsCanceled = true;
        }

        private void FormUIConfig_Load(object sender, EventArgs e)
        {
            this.cmbControlType.ValueMember = "ModelItemTypeName";
            this.cmbControlType.DisplayMember = "ModelItemTypeName";
            this.cmbControlType.DataSource = GetUIModelTypes();


            if(this.ConfigContent != null)
            {
                int idx = GetSelectedIndex(this.ConfigContent.GetControlType());
                cmbControlType.SelectedIndex = idx;
            }
        }

        int GetSelectedIndex(string name)
        {
            int idx = 0;
            foreach(Model.ModelItemType modelType in cmbControlType.Items)
            {
                if (modelType.ModelItemTypeName.ToLower().Equals(name.ToLower()))
                    return idx;
                idx++;
            }
            return -1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.IsCanceled = false;
            IConfigContent configContent = (IConfigContent)this.panelConfig.Controls[0];
            this.ConfigContent = configContent;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.IsCanceled = true;
            this.Close();
        }

        List<Model.ModelItemType> GetUIModelTypes()
        {
            List<IConfigContent> configContents = new List<IConfigContent>();
            configContents.Add(new TextboxConfiguration());
            configContents.Add(new TextareaConfiguration());
            configContents.Add(new ComboboxConfigurator());
            configContents.Add(new RadiobuttonsConfigurator());
            configContents.Add(new CheckboxesConfigurator());
            configContents.Add(new LookupComboboxConfigurator());
            configContents.Add(new LookupCheckboxesConfigurator());
            configContents.Add(new LookupRadiobuttonsConfigurator());
            configContents.Add(new ImageConfigurator());
            configContents.Add(new FileConfigurator());
            configContents.Add(new DateConfigurator());
            configContents.Add(new NumericboxConfiguration());

            List<Model.ModelItemType> list = new List<Model.ModelItemType>();
            foreach(IConfigContent config in configContents)
            {
                list.Add(new Model.ModelItemType(config.GetControlType(), (IConfigContent) config));
            }
            return list;
        }

        private void cmbControlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbControlType.SelectedItem != null)
            {
                Model.ModelItemType modelType = (Model.ModelItemType)cmbControlType.SelectedItem;

                this.panelConfig.Controls.Clear();
                if (this.ConfigContent != null && this.ConfigContent.GetControlType() == modelType.ConfigContent.GetControlType())
                    ((IConfigContent)modelType.ConfigContent).DisplayConfiguration(this.ConfigContent.Configure());
                else
                     if (this.DataColumn != null)
                        modelType.ConfigContent.InitConfiguration(this.DataColumn);

                this.panelConfig.Controls.Clear();
                this.panelConfig.Controls.Add((UserControl) modelType.ConfigContent);
                
            }
        }
    }
}
