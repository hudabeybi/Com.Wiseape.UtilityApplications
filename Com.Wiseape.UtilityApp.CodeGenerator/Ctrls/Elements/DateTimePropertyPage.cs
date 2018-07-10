using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class DateTimePropertyPage : PropertyPage
    {

        public DateTimePropertyPage()
        {
            this.Properties.Add("DefaultDate", DateTime.Now);
            this.Properties.Add("DateFormat", "YYYY-MM-DD hh:mm:ss");
            this.Properties.Add("IncludeTime", false);
            this.Properties.Add("DateRange", false);

            this.Drawer = new DatetimeDrawer(this);
            this.PropertyConfigurator = new DatetimePropertyConfigurator(this);
        }

        public override PropertyPage CreateNew(int idx = 0)
        {
            PropertyPage p = new DateTimePropertyPage();
            p.Properties["ID"] = "dateTime" + idx;
            return p;
        }

        public override string GetElementName()
        {
            return "Date/Time";
        }

        public override string GetElementID()
        {
            return Settings.Default.DATETIME;
        }

        public override Image GetIcon()
        {
            return Resources.calendar;
        }
    }
}
