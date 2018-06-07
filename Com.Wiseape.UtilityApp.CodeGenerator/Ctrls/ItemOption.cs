using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    public class ItemOption
    {
        public string Value { get; set; }
        public string  Text { get; set; }

        public ItemOption(string value, string text)
        {
            this.Value = value;
            this.Text = text;
        }
    }
}
