using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class DataSourceTable
    {
        public string TableName { get; set; }
        public string TableSchema { get; set; }
        private List<DataColumn> columns = new List<DataColumn>();

        public List<DataColumn> DataColumns {
            get
            {
                return columns;
            }
            set
            {
                columns = value;
            }
        }

        [XmlIgnoreAttribute]
        [JsonIgnore]
        public string FullTableName
        {
            get
            {
                return this.TableSchema + "." + this.TableName;
            }
        }

        [JsonIgnore]
        public DataColumn KeyColumn
        {
            get
            {
                foreach(DataColumn col in DataColumns)
                {
                    if (col.Key)
                        return col;
                }
                return null;
            }
        }
    }
}
