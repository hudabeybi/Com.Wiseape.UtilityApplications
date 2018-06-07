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
    public partial class SelectStaticValueCtrl : UserControl
    {
        public SelectStaticValueCtrl()
        {
            InitializeComponent();
        }

        private void SelectStaticValueCtrl_Resize(object sender, EventArgs e)
        {
            gridValues.Width = this.Width - gridValues.Left - gridValues.Left;
            gridValues.Height = this.Height - gridValues.Height - 10;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gridValues.Rows.Add();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(gridValues.SelectedRows.Count > 0)
                gridValues.Rows.Remove(gridValues.SelectedRows[0]);
        }

        private void SelectStaticValueCtrl_Load(object sender, EventArgs e)
        {

        }

        public Dictionary<string, string> GetItems()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            foreach(DataGridViewRow row in gridValues.Rows)
            {
                if(row.Cells[0].Value != null && row.Cells[1].Value != null)
                    items.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
            }
            return items;
        }

        public void DisplayItems(Dictionary<string, string> items)
        {
            gridValues.Rows.Clear();
            foreach(KeyValuePair<string, string> item in items)
            {
                gridValues.Rows.Add(new[] { item.Key, item.Value });
            }
        }
    }
}
