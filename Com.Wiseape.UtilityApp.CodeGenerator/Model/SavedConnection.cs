using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class SavedConnection
    {
        public string ConnectionName { get; set; }
        public string ConnectionString { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
