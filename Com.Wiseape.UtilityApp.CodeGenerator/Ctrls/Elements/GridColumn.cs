using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class GridColumn
    {
        public string ColumnName { get; set; }
        public string ColumnText { get; set; }
        public string ColumnWidth { get; set; }
        public string Field { get; set; }

        public ElementObject Element
        {
            get
            {
                ElementObject elm = new ElementObject();
                elm.ElementType = this.PropertyPage.GetElementID();
                elm.Properties = this.PropertyPage.Properties;
                return elm;
            }
            set
            {
                this.PropertyPage.Properties = value.Properties;
            }

        }


        [JsonIgnore]
        public PropertyPage PropertyPage { set; get; }

    }
}
