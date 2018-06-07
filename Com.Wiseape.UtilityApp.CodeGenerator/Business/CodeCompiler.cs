using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;
using AspCompiler;
using System.IO;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Business
{
    public class CodeCompiler
    {
        public static string GenerateCodeForModule(CodeGeneratorProject Project, CodeGeneratorModule module, string templateCode, bool isProjectTemplate = false)
        {

            templateCode = templateCode.Replace("{CURRENTDIRECTORY}", System.IO.Directory.GetCurrentDirectory());
            string tmpCodeFile = System.IO.Directory.GetCurrentDirectory() + "/tmp.source.aspx";
            File.WriteAllText(tmpCodeFile, templateCode);

            AspCompiler.Template template = new AspCompiler.Template(tmpCodeFile);
            AspCompiler.TemplateParameters parameters = new AspCompiler.TemplateParameters();
            AspCompiler.TemplateParameter param = new AspCompiler.TemplateParameter(typeof(CodeGeneratorProject), "Project", Project);
            parameters.Add(param);
            param = new AspCompiler.TemplateParameter(typeof(CodeGeneratorModule), "Module", module);
            parameters.Add(param);

            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string[] assemblies = new string[4];
            assemblies[0] = currentPath + "\\Com.Wiseape.Utility.dll";
            assemblies[1] = currentPath + "\\Com.Wiseape.UtilityApp.CodeGenerator.dll";
            assemblies[2] = currentPath + "\\AspCompiler.dll";
            assemblies[3] = currentPath + "\\Com.Wiseape.UtilityApp.CodeGenerator.Helper.dll";


            string[] namespaces = new string[7];
            namespaces[0] = "System.Collections.Generic";
            namespaces[1] = "System.Collections";
            namespaces[2] = "Com.Wiseape.UtilityApp.CodeGenerator.Model";
            namespaces[3] = "Com.Wiseape.UtilityApp.CodeGenerator.Business";
            namespaces[4] = "Com.Wiseape.Utility";
            namespaces[5] = "AspCompiler";
            namespaces[6] = "Com.Wiseape.UtilityApp.CodeGenerator.Helper";

            //namespaces[4] = "System.Data";

            template.Compile(assemblies, namespaces, parameters);
            string tmpFile = System.IO.Directory.GetCurrentDirectory() + "/tmp.result"; 
            template.Execute(tmpFile);
            string content = System.IO.File.ReadAllText(tmpFile);
            return content;
        }
    }

}
