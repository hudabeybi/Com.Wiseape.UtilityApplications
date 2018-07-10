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
    public partial class FileConfigurator : UserControl, IConfigContent
    {
        public FileConfigurator()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Configure()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("Placeholder", txtPlaceholder.Text);
            result.Add("AllowedExtensions", txtAllowedExtentions.Text);
            result.Add("SavedFolder", txtSavedFolder.Text);
            result.Add("IsGenerateFilename", chkGenerateFilename.Checked);
            return result;
        }

        public void DisplayConfiguration(Dictionary<string, object> configs)
        {
            txtAllowedExtentions.Text = Convert.ToString( configs["AllowedExtensions"]);
            txtPlaceholder.Text = Convert.ToString(configs["Placeholder"]);
            txtSavedFolder.Text = Convert.ToString(configs["SavedFolder"]);
            chkGenerateFilename.Checked = Convert.ToBoolean(configs["IsGenerateFilename"]);
        }

        public string GetControlType()
        {
            return ControlType.File.ToString();
        }

        public void InitConfiguration(Model.DataColumn column)
        {
            txtPlaceholder.Text = "Please, select " + column.ColumnText;
        }

        private void FileConfigurator_Load(object sender, EventArgs e)
        {

        }
    }
}
