using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Business
{
    public interface IConfigContent
    {
        string GetControlType();
        Dictionary<string, object> Configure();
        void DisplayConfiguration(Dictionary<string, object> configs);

        void InitConfiguration(DataColumn column);
    }
}
