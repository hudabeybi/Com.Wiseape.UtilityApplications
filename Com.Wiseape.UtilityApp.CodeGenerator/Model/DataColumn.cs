using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class DataColumn
    {
        public string ColumnName { get; set; }
        public string ColumnText { get; set; }
        public string DataType { get; set; }
        public int Size { get; set; }

        public bool Key { get; set; }

        public bool Use { get; set; }

        [JsonIgnore]
        public string GenericDataType {
            get
            {
                if(DataType.ToLower().Contains("int") || DataType.ToLower().Contains("double") || DataType.ToLower().Contains("decimal") || DataType.ToLower().Contains("float"))
                {
                    return "numeric";
                }
                else
                {
                    return "string";
                }
            }
        }

        [XmlIgnoreAttribute]
        [JsonIgnore]
        IConfigContent configContent;

        [JsonIgnore]
        public IConfigContent ConfigContent {
            get
            {
                return configContent;
            }
           set
            {
                //value.InitConfiguration(this);
                configContent = value;
                configContent.InitConfiguration(this);
            }
        }

        [JsonProperty(Order = 1)]
        public virtual string ConfigContentClassname
        {
            get
            {
                if(this.ConfigContent != null)
                    return this.ConfigContent.GetType().ToString();
                return "";
            }
            set
            {
                try
                {
                    this.ConfigContent = (IConfigContent)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(value);
                }
                catch
                { }
               
            }
        }

        private Dictionary<string, object> configs = new Dictionary<string, object>();

        [JsonProperty(Order = 10)]
        public Dictionary<string, object> ControlConfigurations
        {
            get
            {
                if (this.ConfigContent != null)
                {
                    Dictionary<string, object> config = this.ConfigContent.Configure();
                    return config;
                }

                return null;
            }
            set
            {

                if(this.ConfigContent != null)
                    this.ConfigContent.DisplayConfiguration(value);
            }
        }

        [JsonIgnore]
        public string ControlConfigurationsJson
        {
            get
            {
                if (this.ConfigContent != null)
                {
                    string json = this.ConfigContent.GetControlType() + ": " + Utility.Serializer.Json.Serialize(this.ControlConfigurations);
                    return json;
                }
                else
                    return "";
            }
        }
    }
}
