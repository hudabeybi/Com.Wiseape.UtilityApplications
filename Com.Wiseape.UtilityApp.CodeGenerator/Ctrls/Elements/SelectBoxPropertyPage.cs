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

            this.Drawer = new SelectBoxDrawer(this);
            this.PropertyConfigurator = new SelectBoxConfigurator(this);
        }

        public override PropertyPage CreateNew(int idx = 0)
        {
            PropertyPage p = new SelectBoxPropertyPage();
            p.Properties["ID"] = "selectBox" + idx;
            return p;
        }

        public override string GetElementName()
        {
            return "Select Box";
        }

        public override string GetElementID()
        {
            return Settings.Default.SELECTBOX;
        }

        public override Image GetIcon()
        {
            return Resources.combo_box;
        }

        
    }
}
