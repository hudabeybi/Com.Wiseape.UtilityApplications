using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class CodeGeneratorSession
    {
        public string ProjectName { get; set; }
        public string ModuleName { get; set; }
        public SavedConnection UsedConnection { get; set; }
        public ModelType ModelType { get; set; }
        public DataSourceTable DatasourceTable { get; set; }
        public string Namespace { get; set; }
        public string Classname { get; set; }
    }
}
