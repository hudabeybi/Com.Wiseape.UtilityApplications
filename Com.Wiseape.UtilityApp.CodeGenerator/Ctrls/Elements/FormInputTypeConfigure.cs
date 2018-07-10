using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public partial class FormInputTypeConfigure : Form
    {
        public bool IsCanceled { get; set; }


        private PropertyPage selectedpropertyPage = null;
         
        public PropertyPage SelectedpropertyPage
        {
            get
            {
                return selectedpropertyPage;
            }
            set
            {
                selectedpropertyPage = value;
                if (value != null)
                {
                    
                    lblSelected.Text = PropertyToString();
                }
            }
        }
        public FormInputTypeConfigure()
        {
            InitializeComponent();
        }

        private void FormInputTypeConfigure_Load(object sender, EventArgs e)
        {
            elementPadCtrl1.IndexesToShow = "1,2,3,4,5";
            elementPadCtrl1.OnClickEventHandler += ElementPadCtrl1_OnClickEventHandler;
        }

        private void ElementPadCtrl1_OnClickEventHandler(PropertyPage ctrl)
        {
            FormElementConfiguration frm = new FormElementConfiguration();
            frm.PropertyConfigurator = ctrl.PropertyConfigurator;
            frm.ShowDialog();
            if (frm.IsCancel == false)
            {
                CommonPropertyConfigurator configurator = (CommonPropertyConfigurator)frm.PropertyConfigurator;
                configurator.Fill(ctrl.Properties);
                SelectedpropertyPage = ctrl;

            }
            else
                SelectedpropertyPage = null;
        }

        string PropertyToString()
        {
            string tmp = selectedpropertyPage.GetElementName() + ": " + Newtonsoft.Json.JsonConvert.SerializeObject(selectedpropertyPage.Properties);
            return tmp;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsCanceled = true;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.IsCanceled = false;
            this.Close();
        }

        private void elementPadCtrl1_Load(object sender, EventArgs e)
        {

        }
    }
}
