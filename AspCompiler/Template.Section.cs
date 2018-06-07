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
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;


namespace AspCompiler
{
    public partial class Template
    {
        #region internally used stuff used while parsing and execution

        private enum SectionType
        {
            /// <summary>
            /// represents a ASP.Net page Directive
            /// </summary>
            Directive,

            /// <summary>
            /// represents an ASP.NET function declaration section
            /// </summary>
            Declaration,
            Code,
            Text
        }

        /// <summary>
        /// maintains the different sections within a aspx page
        /// </summary>
        private class SectionList : List<Section>
        {
            public string ExtractSource(string[] namespaces, TemplateParameters parameters)
            {
                StringBuilder lines = new StringBuilder();
                lines.Append("using System;\r\n");
                lines.Append("using System.Text;\r\n");
                lines.Append("using System.Collections.Generic;\r\n");

                // setup public parameters
                if (namespaces != null)
                    foreach (string ns in namespaces)
                        lines.Append("using " + ns + ";\r\n");

                foreach (Section line in this)
                {
                    if (line.Type == SectionType.Directive)
                        if (line.Values.Directive.ToLower() == "import")
                        {
                            string ns;
                            if (line.Values.TryGetValue("namespace", out ns))
                                lines.Append("using " + ns + ";\r\n");
                        }
                }
                lines.Append("public class Page {\r\n");
                lines.Append("  public MyStreamWriter me;\r\n");
                lines.Append("  public MyStreamWriter Response;\r\n");

                // setup public variable declarations
                foreach (Section line in this)
                {
                    if (line.Type == SectionType.Text)
                        lines.Append("  public string SectionText" + line.Index + ";\r\n");
                }

                // setup public parameters
                if (parameters != null)
                    foreach (TemplateParameter parameter in parameters)
                        lines.Append("  public " + parameter.Type.FullName + " " + parameter.Name + ";\r\n");

                // setup public declarations extracted from the template script-tags
                foreach (Section line in this)
                {
                    if (line.Type == SectionType.Declaration)
                        lines.Append(line.Text + "\r\n");
                }

                lines.Append("  public Page() {}\r\n"); // add a constructor
                lines.Append("  public void RenderPage() {\r\n"); // setup the page execution entrypoint

                foreach (Section line in this)
                {
                    if (line.Type == SectionType.Text)
                    {
                        lines.Append("    me.say(SectionText" + line.Index + ");\r\n");
                    }
                    else if (line.Type == SectionType.Code)
                    {
                        if (line.Text.Trim().StartsWith("@"))
                            continue;
                        lines.Append(line.Text);
                    }
                }
                lines.Append("  }\r\n");
                lines.Append("}\r\n");
                return lines.ToString();
            }

            public void Process(Assembly assembly, TemplateParameters parameters, MyStreamWriter Response)
            {
                try
                {
                    if (assembly == null) return;

                    object instance = assembly.CreateInstance("Page");
                    Type typepage = instance.GetType();

                    // assign Response object to Page
                    typepage.InvokeMember("me", BindingFlags.SetField, null, instance, new object[] { Response });
                    typepage.InvokeMember("Response", BindingFlags.SetField, null, instance, new object[] { Response });

                    // assign section texts to Page members for execution
                    foreach (Section section in this)
                    {
                        if (section.Type == SectionType.Text)
                        {
                            // assign section text to Page members
                            typepage.InvokeMember("SectionText" + section.Index, BindingFlags.SetField, null, instance, new object[] { section.Text });
                        }
                    }

                    // assign parameters to page
                    if (parameters != null)
                        foreach (TemplateParameter tp in parameters)
                        {
                            // try to assign the parameter. if the parameter/variable is not defined in the
                            // template then skip it, there is no need to break the execution here
                            try
                            {
                                typepage.InvokeMember(tp.Name, BindingFlags.SetField, null, instance, new object[] { tp.Value });
                            }
                            catch (MissingFieldException)
                            {
                                //variable was not declared in template but continue anyway
                            }
                        }


                    typepage.InvokeMember("RenderPage", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, instance, null);
                }
                catch (Exception ex)
                {
                    Exception inner;
                    Response.WriteLine();
                    inner = ex;

                    while (inner != null)
                    {
                        Response.WriteLine(inner.Message);
                        inner = inner.InnerException;
                    }
                    Response.WriteLine(ex.StackTrace);
                }
            }

        }

        /// <summary>
        /// contains the directive's name/value pairs that were defined in the template
        /// </summary>
        private class DirectiveValues : Dictionary<string, string>
        {
            public string Directive;

            public DirectiveValues(string directive)
            {
                Directive = directive;
            }
        }

        /// <summary>
        /// represents a section within an aspx page
        /// - directive
        /// - declaration
        /// - text (e.g. html)
        /// - codeblock
        /// </summary>
        private class Section
        {
            public int Index;
            public string Text;
            public SectionType Type;
            public DirectiveValues Values;

            public Section(int index, string text, SectionType type)
                : this(index, text, type, null)
            { }

            public Section(int index, string text, SectionType type, DirectiveValues values)
            {
                Index = index;
                Text = text;
                Type = type;
                Values = values;
            }
        }

        #endregion internally used stuff

    }
}
