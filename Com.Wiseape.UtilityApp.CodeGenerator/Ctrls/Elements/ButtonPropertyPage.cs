using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    [Serializable]
    public class ButtonPropertyPage : PropertyPage
    {
        public ButtonPropertyPage()
        {
            string eventName = Properties["ID"].ToString();

            this.Properties["OnClick"] = eventName + "OnClick";
            this.Properties["OnChange"] = eventName + "OnChange";
            this.Properties.Add("Icon", "");

            this.PropertyConfigurator = new ButtonConfigurator(this);
            this.Drawer = new ButtonDrawer(this);

        }

        public override string GetElementName()
        {
            return "Button";
        }

        public override string GetElementID()
        {
            return Settings.Default.BUTTON;
        }

        public override Image GetIcon()
        {
            return (Image) Resources.plus;
        }

        public override PropertyPage CreateNew(int idx = 0)
        {
            PropertyPage p = new ButtonPropertyPage();
            p.Properties["ID"] = "Button" + idx;
            return p;
        }
    }
}
