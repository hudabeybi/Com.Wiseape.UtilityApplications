using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Business
{
    public interface IAssemblyNameGenerator
    {
        string GenerateNamespace(string projectName, string moduleName, string tableName);
        string GenerateClassName(string projectName, string moduleName, string tableName);

 
    }
}
