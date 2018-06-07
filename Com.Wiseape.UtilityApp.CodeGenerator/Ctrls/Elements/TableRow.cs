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
    public partial class TableRow : UserControl
    {
        public delegate void OnTableRowCellClickDelegate(TableCell cell);
        public event OnTableRowCellClickDelegate OnTableRowCellClick;

        public int Index { get; set; }

        public TableRow()
        {
            InitializeComponent();
            
        }

        private void TableRow_Load(object sender, EventArgs e)
        {
            AddTableCells(1);
        }

        private void TableRow_DoubleClick(object sender, EventArgs e)
        {
            Add();
        }

        void Add()
        {
            FormTableRow frm = new FormTableRow();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                AddTableCells(frm.TotalColumns);
            }
        }

        public void AddTableCells(int totalCell)
        {
            this.Controls.Clear();
            int w = this.Width / totalCell;
            int l = 0;
            for (int i = 0; i < totalCell; i++)
            {
                TableCell cell = new TableCell();
                cell.ParentRow = this;
                cell.Width = w;
                cell.Height = this.Height;
                cell.Left = l;
                l += w;
                this.Controls.Add(cell);
                cell.OnDblClick += Cell_OnDblClick;
                cell.OnClick += Cell_OnClick;
            }
        }

        public void ResizeCells()
        {
            int totalCell = this.Controls.Count;
            int w = this.Width / totalCell;
            int l = 0;
            for (int i = 0; i < totalCell; i++)
            {
                TableCell cell = (TableCell)this.Controls[i];
                cell.Width = w;
                cell.Height = this.Height;
                cell.Left = l;
                l += w;
            }
        }

        private void Cell_OnClick(object o)
        {
            foreach(Control ctrl in this.Controls)
            {
                ctrl.BackColor = Color.White;
            }
            if (this.OnTableRowCellClick != null)
                this.OnTableRowCellClick((TableCell)o);
        }

        private void Cell_OnDblClick(object o)
        {
            Add();
        }

        private void TableRow_Resize(object sender, EventArgs e)
        {
            ResizeCells();
        }

        public List<TableCell> Cells
        {
            get
            {
                return GetTableCells();
            }
        }

        List<TableCell> GetTableCells()
        {
            List<TableCell> tableCells = new List<TableCell>();
            foreach(TableCell cell in this.Controls)
            {
                tableCells.Add(cell);
            }
            return tableCells;
        }
    }
}
