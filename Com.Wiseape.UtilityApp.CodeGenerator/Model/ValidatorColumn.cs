using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using Com.Wiseape.UtilityApp.CodeGenerator.ModelTypeConfigurator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class ValidatorColumn : DataColumn
    {
        public bool IsValidate { get; set; }

        private List<ModelItemType> validationTypeList = new List<ModelItemType>();
        public List<ModelItemType> ValidationTypeList {
            get
            {
                return validationTypeList;
            }
        }

    }
}
