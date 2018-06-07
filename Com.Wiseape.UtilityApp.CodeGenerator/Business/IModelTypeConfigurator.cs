using Com.Wiseape.UtilityApp.CodeGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Business
{
    public interface IModelTypeConfigurator
    {
        void InitFromDatasource(DataSourceTable table);

        void UpdateDatasource(object table);

        DataSourceTable GetDatasource();

    }
}
