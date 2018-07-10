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
            this.PropertyConfigurator = new TextAreaConfigurator(this);
            this.Drawer = new TextAreaDrawer(this);

        }

        public override string GetElementName()
        {
            return "Textarea";
        }

        public override string GetElementID()
        {
            return Settings.Default.TEXTAREA;
        }

        public override Image GetIcon()
        {
            return (Image) Resources.type_box__1_;
        }

        public override PropertyPage CreateNew(int idx = 0)
        {
            PropertyPage p = new TextareaPropertyPage();
            p.Properties["ID"] = "textArea" + idx;
            return p;
        }
    }
}
