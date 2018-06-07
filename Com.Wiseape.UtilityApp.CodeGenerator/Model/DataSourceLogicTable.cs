using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class DataSourceLogicTable : DataSourceTable
    {
        List<LogicColumn> columns = new List<LogicColumn>();
        public List<LogicColumn> DataColumns2
        {
            get
            {
                return columns;
            }

            set
            {
                columns = value;
            }
        }
    }
}
