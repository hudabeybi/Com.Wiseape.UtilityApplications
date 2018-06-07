using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Helper
{
    public class DatabaseMapper
    {
        public static string MapType(string dbType)
        {
            string type = "string";
            switch(dbType)
            {
                case "varchar":
                    type = "string";
                    break;
                case "text":
                    type = "string";
                    break;
                case "int":
                    type = "Int16";
                    break;
                case "bigint":
                    type = "Int64";
                    break;
                case "double":
                    type = "double";
                    break;
                case "float":
                    type = "float";
                    break;
                case "date":
                    type = "DateTime";
                    break;
                case "datetime":
                    type = "DateTime";
                    break;

            }

            return type;
        }
    }
}
