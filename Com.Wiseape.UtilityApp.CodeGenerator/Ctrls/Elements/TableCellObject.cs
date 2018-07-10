using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    [Serializable]
    public class TableCellObject
    {
        public string TableCellName { get; set; }
        public ElementObject Element = new ElementObject();

        public void AddElementFromControl(PropertyPage propertyPage)
        {
            ElementObject o = new ElementObject();
            o.ElementType = propertyPage.GetElementID();
            o.Properties = propertyPage.Properties;
            this.Element = o;
        }

        public PropertyPage CreatePropertyPage()
        {
            PropertyPage page = null;
            string elemType = this.Element.ElementType;
            if (elemType == Settings.Default.CHECKBOXGROUP)
                page = new CheckboxPropertyPage();
            else if (elemType == Settings.Default.DATETIME)
                page = new DateTimePropertyPage();
            else if (elemType == Settings.Default.RADIOGROUP)
                page = new RadioGroupPropertyPage();
            else if (elemType == Settings.Default.SELECTBOX)
                page = new SelectBoxPropertyPage();
            else if (elemType == Settings.Default.GRID)
                page = new GridPropertyPage();
            else if (elemType == Settings.Default.TABPAGES)
                page = new TabPagesPropertyPage();
            else if (elemType == Settings.Default.TEXTAREA)
                page = new TextareaPropertyPage();
            else if (elemType == Settings.Default.TEXTBOX)
                page = new TextboxPropertyPage();
            else if (elemType == Settings.Default.FILEUPLOAD)
                page = new FileUploadPropertyPage();
            else if (elemType == Settings.Default.BUTTON)
                page = new ButtonPropertyPage();

            return page;
        }
    }
}
