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
using Com.Wiseape.UtilityApp.CodeGenerator.Business;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    public partial class FormValidatorConfig : Form
    {

        public bool IsCanceled { get; set; }

        public IConfigContent ConfigContent { get; set; }

        public Model.DataColumn DataColumn { get; set; }

        public FormValidatorConfig()
        {
            InitializeComponent();
        }

        private void FormValidatorConfig_Load(object sender, EventArgs e)
        {
            InitComboValidationType();
            this.IsCanceled = true;
        }

        

        void InitComboValidationType()
        {
            cmbValidationType.DisplayMember = "ModelItemTypeName";
            cmbValidationType.ValueMember = "ModelItemTypeName";

            IConfigContent config = new ValidationIsEmpty();
            cmbValidationType.Items.Add(new ModelItemType(config.GetControlType(), config));

            config = new ValidationStringMinMaxLength();
            cmbValidationType.Items.Add(new ModelItemType(config.GetControlType(), config));

            config = new ValidationNumericMinMax();
            cmbValidationType.Items.Add(new ModelItemType(config.GetControlType(), config));

            if(this.ConfigContent != null)
            {
                int idx = GetValidationTypeSelectedIndex(this.ConfigContent.GetControlType());
                if(idx > -1)
                {
                    cmbValidationType.SelectedIndex = idx;
                }
               
            }
        }

        int GetValidationTypeSelectedIndex(string validationName)
        {
            int idx = 0;
            foreach(ModelItemType item  in cmbValidationType.Items)
            {
                if (item.ModelItemTypeName.Equals(validationName))
                    return idx;
                idx++;
            }

            return -1;
        }

        private void cmbValidationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelItemType type = (ModelItemType) cmbValidationType.SelectedItem;

            UserControl validationContent = (UserControl)type.ConfigContent;
            if (this.ConfigContent != null && this.ConfigContent.GetControlType().Equals(type.ConfigContent.GetControlType()))
                type.ConfigContent.DisplayConfiguration(this.ConfigContent.Configure());
            else
                if(this.DataColumn != null)
                    type.ConfigContent.InitConfiguration(this.DataColumn);

            panelControl.Controls.Clear();
            panelControl.Controls.Add(validationContent);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.IsCanceled = true;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.IsCanceled = false;
            IConfigContent configContent = (IConfigContent)this.panelControl.Controls[0];
            this.ConfigContent = configContent;
            this.Close();
        }
    }
}
