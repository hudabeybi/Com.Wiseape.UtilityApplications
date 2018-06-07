using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class CodeTemplate
    {
        public bool Checked { get; set; }

        public string SavedPath { get; set; }
        public string TemplateName { get; set; }
        public string TemplateCode { get; set; }

        public string DefaultFilename { get; set; }

        public string TemplateCodePlain
        {
            get

            {
                return Utility.StringUtility.Base64Decode(this.TemplateCode);
            }
        }

        public CodeTemplate()
        {

        }

        public CodeTemplate(string name, string code)
        {
            this.TemplateName = name;
            this.TemplateCode = code;
        }
    }
}
