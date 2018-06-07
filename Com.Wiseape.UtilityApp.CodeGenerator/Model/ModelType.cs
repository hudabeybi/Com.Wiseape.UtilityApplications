using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class ModelType
    {
        public string ModelTypeName { get; set; }

        [XmlIgnoreAttribute]
        [JsonIgnore]
        public IModelTypeConfigurator ModelTypeConfigurator { get; set; }

        public ModelType()
        {

        }
        public ModelType(string modelTypeName, IModelTypeConfigurator modelTypeConfigurator)
        {
            this.ModelTypeName = modelTypeName;
            this.ModelTypeConfigurator = modelTypeConfigurator;
        }

        public string ModelTypeConfiguratorClass
        {
            get
            {
                return ModelTypeConfigurator.GetType().ToString();
            }
            set
            {
                ModelTypeConfigurator =  (IModelTypeConfigurator)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(value);
            }
        }

        
        public object Datasource {
            get
            {
                if (this.ModelTypeConfigurator != null)
                {
                    DataSourceTable table = this.ModelTypeConfigurator.GetDatasource();
                    return table; 
                }

                return null;
            }

            set
            {
                if (this.ModelTypeConfigurator != null)
                    this.ModelTypeConfigurator.UpdateDatasource(value);
            }
        }

        public ModelType Clone()
        {
            ModelType newModelType = new ModelType();
            newModelType.ModelTypeConfigurator = (IModelTypeConfigurator)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(ModelTypeConfiguratorClass);
            newModelType.ModelTypeName = this.ModelTypeName;
            newModelType.Datasource = this.Datasource;
            return newModelType;
        }

  
    }
}
