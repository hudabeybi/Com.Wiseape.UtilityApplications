using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class FunctionParameter
    {
        public string ParameterName { get; set; }
        public string ParameterType { get; set; }

        public DataColumn DataColumn { get; set; }

        public FunctionParameter()
        {

        }

        public FunctionParameter(string parameterName, string parameterType)
        {
            this.ParameterName = parameterName;
            this.ParameterType = parameterType;
        }

        public FunctionParameter(string parameterName, string parameterType, DataColumn column)
        {
            this.ParameterName = parameterName;
            this.ParameterType = parameterType;
            this.DataColumn = column;
        }
    }
}
