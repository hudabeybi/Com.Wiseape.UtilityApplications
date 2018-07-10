using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class BaseDrawer : UserControl
    {
        public PropertyPage PropertyPage { get; set; }

        public BaseDrawer()
        { }

        public BaseDrawer(PropertyPage page)
        {
            this.PropertyPage = page;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseDrawer
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "BaseDrawer";
            this.Size = new System.Drawing.Size(491, 71);
            this.Load += new System.EventHandler(this.BaseDrawer_Load);
            this.ResumeLayout(false);

        }

        private void BaseDrawer_Load(object sender, EventArgs e)
        {

        }
    }
}
