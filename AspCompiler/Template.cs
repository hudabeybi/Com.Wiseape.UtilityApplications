// Copyright 2008 Herre Kuijpers - <herre@xs4all.nl>
//
// This source file(s) may be redistributed, altered and custimized
// by any means PROVIDING the authors name and all copyright
// notices remain intact.
// THIS SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED. USE IT AT YOUR OWN RISK. THE AUTHOR ACCEPTS NO
// LIABILITY FOR ANY DATA DAMAGE/LOSS THAT THIS PRODUCT MAY CAUSE.
//-----------------------------------------------------------------------
using System;
using System.IO;
using System.Collections.Generic;
using System.CodeDom.Compiler;


namespace AspCompiler
{
    /// <summary>
    /// the document generator engine
    /// usage: 
    /// step 1: compile the template resulting in a compiled assembly
    /// step 2: execute the assembly given a set of instance parameters
    /// </summary>
    public partial class Template
    {

        /// <summary>
        /// creates an empty template
        /// </summary>
        public Template()
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="templatePath">loads the template from file</param>
        public Template(string templatePath)
        {
            string ss = "";
            TemplatePath = templatePath;
            if (File.Exists(templatePath))
                Page = File.ReadAllText(TemplatePath);
            else
                ss = "";
        }

        
        /// <summary>
        /// the template page contents goes here
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// the path to the template file
        /// </summary>
        private string TemplatePath { get; set; }

        /// <summary>
        /// the list of references assemblies
        /// </summary>
        private string[] Assemblies { get; set; }

        /// <summary>
        /// the list of namespaces to add to the compiled template
        /// </summary>
        private string[] Namespaces { get; set; }

        /// <summary>
        /// the list of variable declarations to add to the compiled template
        /// </summary>
        private TemplateParameters Parameters { get; set; }

        private System.CodeDom.Compiler.CompilerResults Result;
        private SectionList Sections = null;

        /// <summary>
        /// just compiles without any parameters
        /// </summary>
        public void Compile(TemplateParameters parameters)
        {

            //Compile(null, null, null);
            Compile(this.Assemblies, this.Namespaces, parameters);

        }

        /// <summary>
        /// compiles a template into an assembly
        /// </summary>
        /// <param name="assemblies">the assemblies to refernce</param>
        /// <param name="namespaces">the namespaces to add to the compiled template</param>
        /// <param name="parameternames">the names of the parameters to be declared in the assembly (these can be used inside the template)</param>
        /// <returns>the comiled assembly</returns>
        public void Compile(string[] assemblies, string[] namespaces, TemplateParameters parameters)
        {
            Assemblies = assemblies;
            Namespaces = namespaces;
            Parameters = parameters;

            Sections = Parser.ParsePage(Page);

            CodeDomProvider provider = new Microsoft.CSharp.CSharpCodeProvider();
            System.CodeDom.Compiler.CompilerParameters compilerparams = new System.CodeDom.Compiler.CompilerParameters();
            compilerparams.GenerateInMemory = true;
            compilerparams.GenerateExecutable = false;

            // setup references assemblies
            if (assemblies != null)
                foreach (string assembly in assemblies)
                    compilerparams.ReferencedAssemblies.Add(assembly);


            foreach (Section s in Sections)
            {
                if (s.Type == SectionType.Directive)
                {
                    if (s.Values.Directive.ToLower() == "assembly")
                    {
                        string assembly;
                        if (s.Values.TryGetValue("name", out assembly))
                            compilerparams.ReferencedAssemblies.Add(assembly + ".dll");
                    }
                }
            }


            string source = Sections.ExtractSource(namespaces, parameters);
            if (source.Length > 0)
            {
                Result = provider.CompileAssemblyFromSource(compilerparams, new string[] { source });
                Console.WriteLine(source);
            }


        }

        /// <summary>
        /// generates the source code to be executed from the template
        /// </summary>
        /// <returns>the generated source code</returns>
        public string GenerateSource()
        {
            return Sections.ExtractSource(Namespaces, Parameters);
        }


        /// <summary>
        /// execute the template using the default set template parameters during compilation
        /// </summary>
        /// <param name="targetFile"></param>
        public void Execute(string targetFile)
        {
            if(Page != null)
                Execute(targetFile, Parameters);
        }

        /// <summary>
        /// executes the template given a set of instance parameters
        /// and writes its output to the target file
        /// </summary>
        /// <param name="targetFile"></param>
        public void Execute(string targetFile, TemplateParameters parameters)
        {
            if(System.IO.Directory.Exists( System.IO.Path.GetDirectoryName(targetFile)) == false)
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(targetFile));
            MyStreamWriter response = new MyStreamWriter(targetFile);
            Execute(response, parameters);
            response.Close(); // done writing
        }

        /// <summary>
        /// executes the template and writes output to the response
        /// caller is required to open and close the output stream
        /// </summary>
        /// <param name="response">the output stream to write to</param>
        public void Execute(MyStreamWriter response, TemplateParameters parameters)
        {
            if (Result == null)
                return;

            if (Result.Errors.HasErrors)
            {
                foreach (System.CodeDom.Compiler.CompilerError error in Result.Errors)
                {
                    response.Write(GenerateSource());
                    response.Write(String.Format("Error on line {0}: {1}", error.Line, error.ErrorText));
                }
                return;
            }

            if (Sections == null) return; // nothing to execute

            Sections.Process(Result.CompiledAssembly, parameters, response);
        }
    }
}
