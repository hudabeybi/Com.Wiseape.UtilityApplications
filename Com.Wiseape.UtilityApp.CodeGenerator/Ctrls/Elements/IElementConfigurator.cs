using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public interface IElementConfigurator
    {
        void Fill(Dictionary<string, object> config);

        void Display(Dictionary<string, object> config);
    }
}
