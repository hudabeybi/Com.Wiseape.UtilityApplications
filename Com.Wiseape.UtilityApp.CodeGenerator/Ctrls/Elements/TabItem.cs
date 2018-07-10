using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class TabItem
    {
        public string TabName { get; set; }
        public string TabLabel { get; set; }

        public ElementLayoutDesigner ElementLayoutDesigner;

        public List<TableRowObject> TableRowObjects;

        public TabItem()
        {

        }

        public TabItem(string name, string label)
        {
            this.TabLabel = label;
            this.TabName = name;
        }
    }
}
