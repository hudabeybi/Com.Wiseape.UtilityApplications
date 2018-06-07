using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class CodeTemplateGroup
    {
        public string TemplateGroupName { get; set; }

        List<CodeTemplate> codeTemplateList = new List<CodeTemplate>();
        public List<CodeTemplate> CodeTemplateList { get { return codeTemplateList;  }  set { codeTemplateList = value; } }
    }
}
