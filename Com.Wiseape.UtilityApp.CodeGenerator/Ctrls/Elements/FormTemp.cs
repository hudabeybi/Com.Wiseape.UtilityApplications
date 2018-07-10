using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public partial class FormTemp : Form
    {

        public ElementLayoutDesigner Control
        {
            set
            {

                this.elementLayoutDesigner1.TableRows = value.TableRows;
            }
        }
        public FormTemp()
        {
            InitializeComponent();
        }

        private void FormTemp_Load(object sender, EventArgs e)
        {

        }
    }
}
