using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator.Properties;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public partial class TableRow : UserControl
    {
        public delegate void OnTableRowCellClickDelegate(TableCell cell);
        public event OnTableRowCellClickDelegate OnTableRowCellClick;

        public delegate void OnStateChangedDelegate(object sender);
        public event OnStateChangedDelegate OnStateChanged;

        public int Index { get; set; }

        public TableRow()
        {
            InitializeComponent();
            AddTableCells(1);

        }

        private void TableRow_Load(object sender, EventArgs e)
        {
           
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

                if (this.OnStateChanged != null)
                    this.OnStateChanged(this);
            }
        }

        public void CreateTableCellControls(List<TableCellObject> cellObjects)
        {
            int totalCell = cellObjects.Count;
            AddTableCells(totalCell);
            if(totalCell == 2)
            {
                string temp = "";
            }
            if (totalCell > 0)
            {
                for (int i = 0; i < totalCell; i++)
                {
                    TableCell cell = (TableCell)this.Controls[i];
                    TableCellObject cellObj = (TableCellObject)cellObjects[i];
                    string elementType = cellObj.Element.ElementType;
                    PropertyPage page = cellObj.CreatePropertyPage();
                    if (cellObj.Element != null && page != null)
                    {
                        page.Properties = cellObj.Element.Properties;
                        cell.Element = page;
                    }
                    

                }
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
                cell.Name = "TableCell" + (this.Index + i);
                cell.ParentRow = this;
                cell.Width = w;
                cell.Height = this.Height;
                cell.Left = l;
                l += w;
                this.Controls.Add(cell);
                cell.OnDblClick += Cell_OnDblClick;
                cell.OnClick += Cell_OnClick;
                cell.OnStateChanged += Cell_OnStateChanged;
            }
        }

        private void Cell_OnStateChanged(object sender)
        {
            if (this.OnStateChanged != null)
                this.OnStateChanged(sender);
        }

        public void ResizeCells()
        {
            int totalCell = this.Controls.Count;
            if (totalCell > 0)
            {
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
