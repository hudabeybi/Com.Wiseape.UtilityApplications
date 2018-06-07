using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class CodeGeneratorTemplateGroup
    {
        public string TemplateGroupName { get; set; }
        public List<CodeTemplate> CodeTemplateList = new List<CodeTemplate>();
    }
}
