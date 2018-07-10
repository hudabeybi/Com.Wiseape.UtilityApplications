using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    public enum GenerateUIType
    {
        Grid=1,
        Form=2
    }
    public partial class FormGenerateUIType : Form
    {

        public bool IsCanceled { get; set; }

        public GenerateUIType UIType {
            get
            {
                if(this.rdForm.Checked)
                {
                    return GenerateUIType.Form;
                }
                else
                {
                    return GenerateUIType.Grid;
                }
            }
            set
            {
                if (value == GenerateUIType.Grid)
                    rdGrid.Checked = true;
                else
                    rdForm.Checked = true;
            }
        }

        public FormGenerateUIType()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsCanceled = true;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.IsCanceled = false;
            this.Close();
        }
    }
}
