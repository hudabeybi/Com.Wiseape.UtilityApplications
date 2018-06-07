using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class RepositoryFunction
    {
        public enum CompareType
        {
            Contains=1,
            Match=2,
            Between=3
        }
        public string TableName { get; set; }

        private Dictionary<DataColumn, CompareType> parameters = new Dictionary<DataColumn, CompareType>();
        public Dictionary<DataColumn, CompareType> Parameters {
            get
            {
                return parameters;
            }
        }
    }
}
