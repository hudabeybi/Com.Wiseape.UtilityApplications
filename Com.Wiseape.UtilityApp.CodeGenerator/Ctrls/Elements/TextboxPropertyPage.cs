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
    public class TextboxPropertyPage : PropertyPage
    {
        public TextboxPropertyPage()
        {

            this.Properties.Add("MaxLength", "0");
            this.Properties.Add("MinLength", 0);
            this.Properties.Add("PasswordMask", "");
            this.Properties.Add("IsNumeric", false);

            this.PropertyConfigurator = new TextboxConfigurator();
            this.Drawer = new TextboxDrawer();

        }

        public override string GetElementName()
        {
            return "Textbox";
        }

        public override Image GetIcon()
        {
            return (Image) Resources.text_box;
        }

        public override PropertyPage CreateNew()
        {
            return new TextboxPropertyPage();
        }
    }
}
