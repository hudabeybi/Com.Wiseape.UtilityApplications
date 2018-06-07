using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    [Serializable]
    public abstract class PropertyPage
    {

        private Dictionary<string, object> properties = new Dictionary<string, object>();
        public Dictionary<string, object> Properties { get { return properties; } }
        public IElementDesignDrawer Drawer { get; set; }

        public UserControl PropertyConfigurator { get; set; }


        public PropertyPage()
        {
            this.Properties.Add("ID", "");
            this.Properties.Add("Label", "Label");
            this.Properties.Add("DefaultValue", "Default Value");
            this.Properties.Add("DataField", "");
            this.Properties.Add("CssStyle", "");
            this.Properties.Add("CssClass", "");
        }

        public void ShowConfigurationWindow()
        {
            IElementConfigurator configurator = (IElementConfigurator)PropertyConfigurator;
            configurator.Display(this.Properties);

            FormElementConfiguration form = new FormElementConfiguration();
            form.PropertyConfigurator = PropertyConfigurator;
            form.ShowDialog();
           
            configurator.Fill(Properties);
            this.Drawer.Draw(Properties);
        }

        public virtual string GetElementName()
        {
            return "DefaultPropertyPage";
        }

        public virtual Image GetIcon()
        {
            return null;
        }

        public virtual PropertyPage CreateNew()
        {
            return null;
        }


    }
}
