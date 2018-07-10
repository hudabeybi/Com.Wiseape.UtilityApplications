using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class GridActionButton
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string OnClick { get; set; }
        public string Icon { get; set; }

        public GridActionButton()
        {

        }

        public GridActionButton(string name, string text, string icon, string onClick)
        {
            this.Name = name;
            this.Text = text;
            this.Icon = icon;
            this.OnClick = onClick;
        }
    }
}
