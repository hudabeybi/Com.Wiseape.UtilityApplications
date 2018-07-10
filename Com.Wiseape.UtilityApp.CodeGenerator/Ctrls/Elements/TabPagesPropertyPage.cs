using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class TabPagesPropertyPage : PropertyPage
    {

        public TabPagesPropertyPage()
        {
            this.Properties.Add("IsHtml", true);
            this.PropertyConfigurator = new TabPagesConfigurator(this);
            this.Drawer = new TabPageDrawer(this);
        }

        public override string GetElementName()
        {
            return "Tab Pages";
        }

        public override string GetElementID()
        {
            return Settings.Default.TABPAGES;
        }

        public override Image GetIcon()
        {
            return (Image)Resources.web_tabs;
        }

        public override PropertyPage CreateNew(int idx = 0)
        {
            PropertyPage p = new TabPagesPropertyPage();
            p.Properties["ID"] = "tabControl" + idx;
            return p;
        }
    }
}
