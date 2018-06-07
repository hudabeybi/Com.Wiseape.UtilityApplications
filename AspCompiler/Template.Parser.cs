// Copyright 2008 Herre Kuijpers - <herre@xs4all.nl>
//
// This source file(s) may be redistributed, altered and custimized
// by any means PROVIDING the authors name and all copyright
// notices remain intact.
// THIS SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED. USE IT AT YOUR OWN RISK. THE AUTHOR ACCEPTS NO
// LIABILITY FOR ANY DATA DAMAGE/LOSS THAT THIS PRODUCT MAY CAUSE.
//-----------------------------------------------------------------------
using System.Text;
using System.Text.RegularExpressions;

namespace AspCompiler
{
    public partial class Template
    {
        #region defines the aspx template parser

        /// <summary>
        /// the Parser class parses the aspx page and converts it into compilable code
        /// currently the parser supports the following Page Directives:
        /// @Page - defines the type of page (cs or vb code)
        /// @Assembly - used to include (external) assemblies
        /// @Import - used to include namespaces
        /// note that currently added script declarations must be written in the 
        /// same language as the page (no mixed vb and cs allowed)
        /// </summary>
        private class Parser
        {
            public static SectionList ParsePage(string page)
            {
                //maches <script> sections, returns result in 'code' variable 
                //<script[^>]*runat[\s]*=[\s]*"?Server"?[^>]*>(?<code>[^<]*)</script>

                // matches code blocks <% %>
                //<%{1}([^%])*%>
                SectionList list = new SectionList();
                //SectionList list1 = ParseDeclares(page);
                page = ParseDirectives(list, page);
                page = ParseDeclarations(list, page);
                ParseText(list, page);
                return list;
            }

            private static string ParseDirectives(SectionList list, string page)
            {
                // finds directives
                //<%\s*@\s*(?<directive>[\w]*)[^%]*%>
                //<%\s*@\s*(?<directive>[\w]*)\s*(?<p1>[\w]*)\s*=(?<v1>[^\s%]*)[^%]*%>

                // parses the directive and up to 4 name/value pairs
                //<%\s*@\s*(?<directive>[\w]*)\s*((?<p1>[\w]*)\s*=(?<v1>[^\s%]*))?\s*((?<p2>[\w]*)\s*=(?<v2>[^\s%]*))?\s*((?<p3>[\w]*)\s*=(?<v3>[^\s%]*))?\s*((?<p4>[\w]*)\s*=(?<v4>[^\s%]*))?[^%]*%>

                StringBuilder result = new StringBuilder();
                //Regex reg =new Regex(@"<%\s*@\s*(?<directive>[\w]*)[^%]*%>", RegexOptions.IgnoreCase);
                Regex reg = new Regex(@"<%\s*@\s*(?<directive>[\w]*)\s*((?<p1>[\w]*)\s*=(?<v1>[^\s%]*))?\s*((?<p2>[\w]*)\s*=(?<v2>[^\s%]*))?\s*((?<p3>[\w]*)\s*=(?<v3>[^\s%]*))?\s*((?<p4>[\w]*)\s*=(?<v4>[^\s%]*))?[^%]*%>", RegexOptions.IgnoreCase);
                MatchCollection mc = reg.Matches(page);

                int index = 0;
                foreach (Match m in mc)
                {
                    result.Append(page.Substring(index, m.Index - index));
                    DirectiveValues dvs = new DirectiveValues(m.Groups["directive"].Value.ToLower());
                    if (m.Groups["p1"].Value != string.Empty)
                        dvs.Add(m.Groups["p1"].Value.ToLower(), StripQuotes(m.Groups["v1"].Value));
                    if (m.Groups["p2"].Value != string.Empty)
                        dvs.Add(m.Groups["p2"].Value.ToLower(), StripQuotes(m.Groups["v2"].Value));
                    if (m.Groups["p3"].Value != string.Empty)
                        dvs.Add(m.Groups["p3"].Value.ToLower(), StripQuotes(m.Groups["v3"].Value));
                    if (m.Groups["p4"].Value != string.Empty)
                        dvs.Add(m.Groups["p4"].Value.ToLower(), StripQuotes(m.Groups["v4"].Value));

                    Section s = new Section(list.Count, page.Substring(m.Index, m.Length), SectionType.Directive, dvs);
                    list.Add(s);
                    index = m.Index + m.Length;
                }
                result.Append(page.Substring(index));
                return result.ToString();
            }

            private static string StripQuotes(string text)
            {
                return text.Trim("\" ".ToCharArray());
            }

            private static string ParseDeclarations(SectionList list, string page)
            {
                StringBuilder result = new StringBuilder();
                Regex reg1 = new Regex("<script[^>]*runat[\\s]*=[\\s]*\"?server\"?[^>]*>", RegexOptions.IgnoreCase);
                Regex reg2 = new Regex("</\\s*script\\s*>", RegexOptions.IgnoreCase);

                int index = 0;
                while (index < page.Length)
                {
                    // try find start of block
                    Match m1 = reg1.Match(page, index);
                    if (!m1.Success) break; // exit loop here

                    //start <script> found, now find end.
                    Match m2 = reg2.Match(page, m1.Index + m1.Length);
                    if (!m2.Success) break; // exit loop here

                    result.Append(page.Substring(index, m1.Index - index));

                    string block = page.Substring(m1.Index + m1.Length, m2.Index - (m1.Index + m1.Length));
                    Section s = new Section(list.Count, block, SectionType.Declaration);
                    list.Add(s);
                    index = m2.Index + m2.Length;
                }
                result.Append(page.Substring(index));
                return result.ToString();
            }

            private static void ParseText(SectionList list, string page)
            {
                if (page.Length <= 0) return;

                int index = 0;
                while (index < page.Length)
                {
                    int k = page.IndexOf("<%", index);
                    if (k < 0) break; // no code blocks found, exit

                    if (k > 0)
                        list.Add(new Section(list.Count, page.Substring(index, k - index), SectionType.Text));
                    index = k;

                    int j = page.IndexOf("%>", index);
                    if (j <= index) break; // no matching closing brackets found

                    list.Add(new Section(list.Count, page.Substring(index + 2, j - (index + 2)), SectionType.Code));
                    index = j + 2;
                }
                list.Add(new Section(list.Count, page.Substring(index), SectionType.Text));
            }

        }
        #endregion defines the aspx template parser
    }
}
