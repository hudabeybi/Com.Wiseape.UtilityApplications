using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public interface IElementDesigner
    {
        string GetElementName();
        void ShowConfigureProperties();

        Image GetIcon();

    }
}
