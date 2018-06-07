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

namespace AspCompiler
{
    /// <summary>
    /// list of template parameters
    /// </summary>
    public class TemplateParameters : List<TemplateParameter>
    {
        /// <summary>
        /// indexer based on the name of the template parameter
        /// </summary>
        /// <param name="name">name of the template parameter to retrieve</param>
        /// <returns>a template parameter if it exists, null otherwise</returns>
        public TemplateParameter this[string name]
        {
            get
            {
                foreach (TemplateParameter tp in this)
                    if (tp.Name == name) return tp;
                return null;
            }
        }

        public TemplateParameter Add(Type paramType, string paramName)
        {
            return Add(paramType, paramName);
        }

        public TemplateParameter Add(Type paramType, string paramName, object paramValue)
        {
            TemplateParameter tp = new TemplateParameter(paramType, paramName, paramValue);
            Add(tp);
            return tp;
        }

    }

    /// <summary>
    /// parameter declarations used
    /// </summary>
    public class TemplateParameter
    {
        /// <summary>
        /// the type of the parameter
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// the name of the parameter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the value of the parameter (null by default)
        /// note that the value can contain a domain object. the value must be of the same type as Type
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// a parameter can be used inside a template
        /// </summary>
        /// <param name="paramType">the .Net type of the parameter</param>
        /// <param name="paramName">the name of the parameter</param>
        public TemplateParameter(Type paramType, string paramName)
            : this(paramType, paramName, null)
        {
        }

        /// <summary>
        /// a parameter can be used inside a template
        /// </summary>
        /// <param name="paramType">the .Net type of the parameter</param>
        /// <param name="paramName">the name of the parameter</param>
        /// <param name="paramValue">the value of the parameter</param>
        public TemplateParameter(Type paramType, string paramName, object paramValue)
        {
            Type = paramType;
            Name = paramName;
            Value = paramValue;
        }

    }
}
