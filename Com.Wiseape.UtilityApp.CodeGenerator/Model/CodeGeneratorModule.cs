using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class CodeGeneratorModule
    {
        public string  SessionName { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDesc { get; set; }

        public ModelType ModelType { get; set; }

        public SavedConnection Connection { get; set; }
        public DataSourceTable Datasource { get; set; }
        public string Namespace { get; set; }
        public string Classname { get; set; }

    }
}
