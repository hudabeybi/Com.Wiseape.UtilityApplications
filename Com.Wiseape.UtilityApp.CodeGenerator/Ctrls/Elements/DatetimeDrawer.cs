using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public partial class DatetimeDrawer : UserControl, IElementDesignDrawer
    {
        public DatetimeDrawer()
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            label1.Text = properties["Label"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(properties["DefaultDate"].ToString());
        }

        private void DatetimeDrawer_Load(object sender, EventArgs e)
        {

        }
    }
}
