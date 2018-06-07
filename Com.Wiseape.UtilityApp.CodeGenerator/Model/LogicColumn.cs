using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class LogicColumn : DataColumn
    {
        public string Tag { get; set; }
        public string FunctionName { get; set; }
        public string ReturnType { get; set; }

        [JsonIgnore]
        public List<FunctionParameter> Parameters
        {
            get
            {
                return (List<FunctionParameter>)this.ControlConfigurations["Parameters"];
            }
        }

        [JsonIgnore]
        public string ParameterString
        {
            get
            {
                string s = "";
                List<FunctionParameter> parameters = Parameters;
                foreach(FunctionParameter functionParameter in parameters)
                {
                    s += functionParameter.ParameterType + " " + functionParameter.ParameterName + ", ";
                }
                if(s.Length > 0)
                {
                    s = s.Substring(0, s.Length - 2);
                }
                return s;
            }
        }

        [JsonIgnore]
        public string ParameterVariableString
        {
            get
            {
                string s = "";
                List<FunctionParameter> parameters = Parameters;
                foreach (FunctionParameter functionParameter in parameters)
                {
                    s += functionParameter.ParameterName + ", ";
                }
                if (s.Length > 0)
                {
                    s = s.Substring(0, s.Length - 2);
                }
                return s;
            }
        }

        public string ToString(string pattern, string separator)
        {
            string s = "";
            List<FunctionParameter> parameters = Parameters;
            foreach (FunctionParameter functionParameter in parameters)
            {
                string ss = pattern.Replace("<var>", functionParameter.ParameterName);
                ss = ss.Replace("<convert.toint16>", "Convert.ToInt16(" + functionParameter.ParameterName + ")");
                ss = ss.Replace("<convert.toint32>", "Convert.ToInt32(" + functionParameter.ParameterName + ")");
                ss = ss.Replace("<convert.toint64>", "Convert.ToInt64(" + functionParameter.ParameterName + ")");
                ss = ss.Replace("<convert.tostring>", "Convert.ToString(" + functionParameter.ParameterName + ")");

                if(functionParameter.ParameterType.ToLower().Contains("int16"))
                    ss = ss.Replace("<convert_string_to_type>", "Convert.ToInt16");
                else if (functionParameter.ParameterType.ToLower().Contains("int32"))
                    ss = ss.Replace("<convert_string_to_type>", "Convert.ToInt32");
                else if (functionParameter.ParameterType.ToLower().Contains("int64"))
                    ss = ss.Replace("<convert_string_to_type>", "Convert.ToInt64");
                else if (functionParameter.ParameterType.ToLower().Contains("float"))
                    ss = ss.Replace("<convert_string_to_type>", "(float)Convert.ToDouble");
                else
                    ss = ss.Replace("<convert_string_to_type>", "Convert.To" + Helper.StrUtil.UpFirst(functionParameter.ParameterType));

                s += ss + separator;
            }
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
            }
            return s;
        }


        [JsonIgnore]
        public string ParameterVariableStringPrimary
        {
            get
            {
                string s = "";
                List<FunctionParameter> parameters = Parameters;
                int idx = 0;
                foreach (FunctionParameter functionParameter in parameters)
                {
                    if (idx == 0)
                        s = functionParameter.ParameterName + "";
                    break;
                }
                return s;
            }
        }

        [JsonIgnore]
        public string ParameterVariableStringNonPrimary
        {
            get
            {
                string s = "";
                List<FunctionParameter> parameters = Parameters;
                int idx = 0;
                foreach (FunctionParameter functionParameter in parameters)
                {
                    if(idx > 0)
                        s += functionParameter.ParameterName + ", ";
                    idx++;
                }
                if (s.Length > 0)
                {
                    s = s.Substring(0, s.Length - 2);
                }
                return s;
            }
        }

        [JsonIgnore]
        public FunctionParameter PrimaryKeyParameter
        {
            get
            {
                foreach(FunctionParameter param in Parameters)
                {
                    if (param.DataColumn != null && param.DataColumn.Key)
                        return param;
                }

                return null;
            }
        }

    }
}
