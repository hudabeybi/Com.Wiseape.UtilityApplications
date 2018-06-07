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
    public class TextareaPropertyPage : PropertyPage
    {
        public TextareaPropertyPage()
        {
            this.Properties.Add("IsHtml", true);
            this.PropertyConfigurator = new TextAreaConfigurator();
            this.Drawer = new TextAreaDrawer();

        }

        public override string GetElementName()
        {
            return "Textarea";
        }

        public override Image GetIcon()
        {
            return (Image) Resources.type_box__1_;
        }

        public override PropertyPage CreateNew()
        {
            return new TextareaPropertyPage();
        }
    }
}
