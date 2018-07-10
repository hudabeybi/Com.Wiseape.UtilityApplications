using Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements;
using Newtonsoft.Json;
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

        public List<TableRowObject> UIObjects
        {
            get
            {
                if (this.ElementLayoutDesigner != null)
                    return this.ElementLayoutDesigner.TableRows;
                else
                    return null;
            }
            set
            {
                if (this.ElementLayoutDesigner == null)
                    this.ElementLayoutDesigner = new ElementLayoutDesigner();
                this.ElementLayoutDesigner.TableRows = value;
            }
        }

        [JsonIgnore]
        public ElementLayoutDesigner ElementLayoutDesigner { get; set; }

    }
}
