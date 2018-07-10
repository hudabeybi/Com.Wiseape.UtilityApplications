using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    [Serializable]
    public class ElementObject
    {
        public string ElementType { get; set; }
        public Dictionary<string, object> Properties = new Dictionary<string, object>();
    }
}
