using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator.Business;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class ModelItemType
    {
        public string ModelItemTypeName { get; set; }
        public IConfigContent ConfigContent { get; set; }

        public ModelItemType()
        {

        }
        public ModelItemType(string modelTypeName, IConfigContent configContent)
        {
            this.ModelItemTypeName = modelTypeName;
            this.ConfigContent = configContent;
        }
    }
}
