using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public interface IElementDesignDrawer
    {
        void Draw(Dictionary<string, object> properties);

    }
}
