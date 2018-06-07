using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class SelectBoxPropertyPage : PropertyPage
    {

        public SelectBoxPropertyPage()
        {
            this.Properties.Add("IsStatic", true);
            this.Properties.Add("ValueMember", "");
            this.Properties.Add("DisplayMember", "");
            this.Properties.Add("QueryOrUrl", "");
            this.Properties.Add("Items", new Dictionary<string, string>());

            this.Drawer = new SelectBoxDrawer();
            this.PropertyConfigurator = new SelectBoxConfigurator();
        }

        public override PropertyPage CreateNew()
        {
            return new SelectBoxPropertyPage();
        }

        public override string GetElementName()
        {
            return "Select Box";
        }

        public override Image GetIcon()
        {
            return Resources.combo_box;
        }

        
    }
}
