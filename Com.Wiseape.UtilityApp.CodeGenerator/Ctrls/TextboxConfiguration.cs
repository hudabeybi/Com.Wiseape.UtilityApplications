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
    public partial class TextboxConfiguration : UserControl, IConfigContent
    {
        public TextboxConfiguration()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("Placeholder", txtPlaceholder.Text);
            result.Add("DefaultValue", txtDefaultValue.Text);
            result.Add("PasswordChar", txtPasswordChar.Text);
            return result;
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            txtDefaultValue.Text = Convert.ToString( configs["DefaultValue"]);
            txtPlaceholder.Text = Convert.ToString(configs["Placeholder"]);
            txtPasswordChar.Text = Convert.ToString(configs["PasswordChar"]);
        }

        public string GetControlType()
        {
            return "Textbox";
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            txtPlaceholder.Text = "Please, fill " + column.ColumnText;
        }

        private void TextboxConfiguration_Load(object sender, EventArgs e)
        {
        }
    }
}
