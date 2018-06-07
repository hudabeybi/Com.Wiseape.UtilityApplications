using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class DataSourceValidationTable : DataSourceTable
    {
        List<ValidatorColumn> columns = new List<ValidatorColumn>();
        public List<ValidatorColumn> DataColumns2
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
