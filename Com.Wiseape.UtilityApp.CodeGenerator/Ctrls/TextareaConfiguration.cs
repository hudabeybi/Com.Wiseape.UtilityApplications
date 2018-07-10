using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    public partial class TextareaConfiguration : UserControl, IConfigContent
    {
        public TextareaConfiguration()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("Placeholder", txtPlaceholder.Text);
            result.Add("DefaultValue", txtDefaultValue.Text);
            result.Add("Width", txtWidth.Text);
            result.Add("Height", txtHeight.Text);
            result.Add("IsHtmlEditor", chkHtml.Checked);
            return result;
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            txtDefaultValue.Text = Convert.ToString(configs["DefaultValue"]);
            txtPlaceholder.Text = Convert.ToString(configs["Placeholder"]);
            txtHeight.Text = Convert.ToString(configs["Height"]);
            txtWidth.Text = Convert.ToString(configs["Width"]);
            chkHtml.Checked = Convert.ToBoolean(configs["IsHtmlEditor"]);
        }

        public string GetControlType()
        {
            return ControlType.Textarea.ToString();
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            txtPlaceholder.Text = "Please, fill " + column.ColumnText;
        }

        private void TextareaConfiguration_Load(object sender, EventArgs e)
        {

        }
    }
}
