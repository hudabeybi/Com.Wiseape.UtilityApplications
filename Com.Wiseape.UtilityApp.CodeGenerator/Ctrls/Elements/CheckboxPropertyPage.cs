using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class CheckboxPropertyPage : PropertyPage
    {

        public CheckboxPropertyPage()
        {
            this.Properties.Add("IsStatic", true);
            this.Properties.Add("ValueMember", "");
            this.Properties.Add("DisplayMember", "");
            this.Properties.Add("QueryOrUrl", "");
            this.Properties.Add("Items", new Dictionary<string, string>());

            this.Drawer = new CheckboxGroupDrawer(this);
            this.PropertyConfigurator = new SelectBoxConfigurator(this);
        }

        public override PropertyPage CreateNew(int idx = 0)
        {
            PropertyPage pg = new CheckboxPropertyPage();
            pg.Properties["ID"] = "checkbox" + idx;
            return pg;
        }

        public override string GetElementName()
        {
            return "Checkbox Group";
        }

        public override string GetElementID()
        {
            return Settings.Default.CHECKBOXGROUP;
        }

        public override Image GetIcon()
        {
            return Resources.check_square;
        }
    }
}
