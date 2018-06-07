using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class DataRepository : DataColumn
    {
        public bool IsDateBetween { get; set; }

        public bool IsContain { get; set; }

        public bool IsMatch { get; set; }
    }
}
