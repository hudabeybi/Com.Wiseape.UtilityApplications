using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class CodeGeneratorProject
    {
        public string Filename { get; set; }
        public string ProjectName
        { get; set; }

        public string Company { get; set; }

        public string CompanyName { get { return this.Company; }  }

        public string ProjectDesc { get; set; }

        List<CodeGeneratorModule> modules = new List<CodeGeneratorModule>();
        public List<CodeGeneratorModule> Modules {
            get
            {
                return modules;
            }
            set
            {
                modules = value;
            }
        }

        List<SavedConnection> connections = new List<SavedConnection>();
        public List<SavedConnection> Connections
        {
            get
            {
                return connections;
            }
            set
            {
                connections = value;
            }
        }
    }
}
