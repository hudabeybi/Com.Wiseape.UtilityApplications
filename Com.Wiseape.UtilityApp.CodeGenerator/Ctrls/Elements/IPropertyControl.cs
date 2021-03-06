﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public interface IPropertyControl
    {
        void SetProperties(Dictionary<string, object> properties);
        Dictionary<string, object> GetProperties();

        string GetElementName();
        void ShowConfigureProperties();

        Image GetIcon();

        IElementDesignDrawer GetDrawer();
    }
}
