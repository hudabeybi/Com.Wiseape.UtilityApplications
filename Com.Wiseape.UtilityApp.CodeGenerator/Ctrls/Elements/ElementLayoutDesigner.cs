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
    public partial class ElementLayoutDesigner : UserControl
    {
        TableCell CurrentTableCell = null;
        public delegate void OnTableCellClickDelegate(TableCell tableCell);
        public event OnTableCellClickDelegate OnTableCellClick;

        public ElementLayoutDesigner()
        {
            InitializeComponent();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            this.panel1.Width = this.Width - this.panel1.Left - 10;
            AddRow();
        }

        int top = 0;
        int idx = 0;
        public void AddRow()
        {
            TableRow row = new TableRow();
            row.Index = idx;
            idx ++;
            row.OnTableRowCellClick += Row_OnTableRowCellClick;
            //row.BorderStyle = BorderStyle.FixedSingle;
            row.Top = GetTop();
            this.panel1.Controls.Add(row);
            
            row.Width = this.panel1.Width - 5;

            //RearrangeRows();
            
            row.BringToFront();
        }

        int GetTop()
        {
            int top = 0;
            foreach(Control ctrl in this.panel1.Controls)
            {
                top += ctrl.Height;
            }
            return top;
        }

        void RearrangeRows()
        {
            int top = 0;
            foreach(Control ctrl in this.panel1.Controls)
            {
                //ctrl.Top = top;
                top += ctrl.Height;
            }
        }

        public void DeleteCurrentRow()
        {
            List<TableRow> rows = new List<TableRow>();
            bool ok = false;
            TableRow currentRow = this.CurrentTableCell.ParentRow;
            int top = currentRow.Top;
            foreach(Control ctrl in this.panel1.Controls)
            {
                if(ctrl.Top > top)
                {
                    rows.Add((TableRow)ctrl);
                }
               
            }
            this.panel1.Controls.Remove(currentRow);
            //RearrangeRows();
            foreach(TableRow row in rows)
            {
                row.Top = top;
                top += row.Height;
            }
        }

        public void DeleteCurrentCell()
        {
            TableRow currentRow = this.CurrentTableCell.ParentRow;
            currentRow.Controls.Remove(this.CurrentTableCell);
            currentRow.Width = this.panel1.Width - 5;
            currentRow.Left = 0;
            currentRow.ResizeCells();
        }

        private void Row_OnTableRowCellClick(TableCell cell)
        {
            foreach(TableRow row in panel1.Controls)
            {
                List<TableCell> cells = row.Cells;
                foreach(TableCell c in cells)
                {
                    c.BackColor = Color.White;
                }
            }

            this.CurrentTableCell = cell;
            if (this.OnTableCellClick != null)
                this.OnTableCellClick(cell);
        }

        public void AddElement(PropertyPage ctrl)
        {
           
            if (this.CurrentTableCell != null)
            {
                UserControl cc = (UserControl)ctrl.Drawer;
                cc.Width = this.CurrentTableCell.Width - 10;
                cc.Height = this.CurrentTableCell.Height - 10;
                cc.Tag = ctrl;
                cc.DoubleClick += Cc_DoubleClick;
                this.CurrentTableCell.Controls.Clear();
                this.CurrentTableCell.Controls.Add(cc);
            }   
            else
                MessageBox.Show("No Selected cell. Please, select one cell.");
        }

        private void Cc_DoubleClick(object sender, EventArgs e)
        {
            PropertyPage propertyPage = (PropertyPage)((UserControl)sender).Tag;
            propertyPage.ShowConfigurationWindow();

            //commonPropertyControl.ShowConfigureProperties();

        }

        private void ElementLayoutDesigner_SizeChanged(object sender, EventArgs e)
        {
            this.panel1.Width = this.Width - this.panel1.Left - 10;
            this.panel1.Height = this.Height - this.panel1.Top - 10;
            foreach(Control c in this.panel1.Controls)
            {
                c.Width = this.panel1.Width - 5;
            }
        }

        private void ElementLayoutDesigner_Load(object sender, EventArgs e)
        {

        }

        public List<TableRow> Rows
        {
            get
            {
                List<TableRow> rows = new List<TableRow>();
                foreach (Control ctrl in this.panel1.Controls)
                {
                    TableRow row = (TableRow)ctrl;
                    rows.Add(row);
                }
                return rows;
            }

        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            this.DeleteCurrentRow();
        }

        private void btnDeleteCell_Click(object sender, EventArgs e)
        {
            this.DeleteCurrentCell();
        }
    }
}
