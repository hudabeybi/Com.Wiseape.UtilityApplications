using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class RadioGroupPropertyPage : PropertyPage
    {
        public RadioGroupPropertyPage()
        {
            this.Properties.Add("IsStatic", true);
            this.Properties.Add("ValueMember", "");
            this.Properties.Add("DisplayMember", "");
            this.Properties.Add("QueryOrUrl", "");
            this.Properties.Add("Items", new Dictionary<string, string>());

            this.Drawer = new RadioGroupDrawer();
            this.PropertyConfigurator = new SelectBoxConfigurator();
        }

        public override PropertyPage CreateNew()
        {
            return new RadioGroupPropertyPage();
        }

        public override string GetElementName()
        {
            return "Radio Group";
        }

        public override Image GetIcon()
        {
            return Resources.radio_button_group;
        }
    }
}
