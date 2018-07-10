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
    public partial class ElementLayoutDesigner : UserControl
    {
        TableCell CurrentTableCell = null;
        [Browsable(false)]
        public delegate void OnTableCellClickDelegate(TableCell tableCell);

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public event OnTableCellClickDelegate OnTableCellClick;

        public delegate void OnStateChangedDelegate(object sender);
        public event OnStateChangedDelegate OnStateChanged;

        public bool ShowButtons {
            get { return this.btnAddRow.Visible; }
            set { this.btnAddRow.Visible = value; this.btnDeleteCell.Visible = value; this.btnDeleteRow.Visible = value; }
        }

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
        public TableRow AddRow()
        {
            TableRow row = new TableRow();
            row.Index = idx;
            row.TabIndex = idx;
            row.Name = "Row" + idx;
            idx ++;
            row.OnTableRowCellClick += Row_OnTableRowCellClick;
            //row.BorderStyle = BorderStyle.FixedSingle;
            row.Top = GetTop();
            this.panel1.Controls.Add(row);
            
            row.Width = this.panel1.Width - 5;

            //RearrangeRows();
            
            row.BringToFront();
            if (this.OnStateChanged != null)
                this.OnStateChanged(this);
            return row;
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

            if (this.OnStateChanged != null)
                this.OnStateChanged(this);
        }

        public void DeleteCurrentCell()
        {
            TableRow currentRow = this.CurrentTableCell.ParentRow;
            currentRow.Controls.Remove(this.CurrentTableCell);
            currentRow.Width = this.panel1.Width - 5;
            currentRow.Left = 0;
            currentRow.ResizeCells();

            if (this.OnStateChanged != null)
                this.OnStateChanged(this);
        }

        private void Row_OnTableRowCellClick(TableCell cell)
        {
            foreach(TableRow row in panel1.Controls)
            {
                List<TableCell> cells = row.Cells;
                foreach(TableCell c in cells)
                {
                    c.BackColor = Color.Transparent;
                }
            }
            cell.BackColor = Color.Wheat;
            this.CurrentTableCell = cell;
            //MessageBox.Show(cell.ParentRow.Name);
            if (this.OnTableCellClick != null)
                this.OnTableCellClick(cell);
        }

        public void SelectCell(int rowIdx, int cellIdx)
        {
            int ridx = 0;
            foreach (TableRow row in panel1.Controls)
            {
                int cIdx = 0;
                List<TableCell> cells = row.Cells;
                if (row.Index == rowIdx)
                {
                    foreach (TableCell c in cells)
                    {
                        if (cIdx == cellIdx)
                        {
                            this.CurrentTableCell = c;
                            break;
                        }
                        cIdx++;
                    }
                    break;
                }
                ridx++;
            }
        }

        public void AddElement(PropertyPage ctrl)
        {
           
            if (this.CurrentTableCell != null)
            {
                this.CurrentTableCell.Element = ctrl;
            }   
            else
                MessageBox.Show("No Selected cell. Please, select one cell.");
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

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected List<TableRow> Rows
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


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<TableRowObject> TableRows
        {
            get
            {
                List<TableRow> ctrls = new List<TableRow>();
                foreach (TableRow ctrl in this.panel1.Controls)
                {
                    ctrls.Add(ctrl);
                }

                ctrls.Sort((x, y) => x.Index.CompareTo(y.Index));

                List<TableRowObject> rows = new List<TableRowObject>();
                foreach (Control ctrl in ctrls)
                {
                    TableRow row = (TableRow)ctrl;
                    TableRowObject rowObj = Convert(row);
                    rows.Add(rowObj);
                }

                //rows.Reverse();
                return rows;
            }
            set
            {
                this.panel1.Controls.Clear();
                if (value != null)
                {
                    foreach (TableRowObject o in value)
                    {
                        TableRow newRowCtrl = AddRow(); //ConvertToTableRow(o);
                        newRowCtrl.OnStateChanged += NewRowCtrl_OnStateChanged;
                        newRowCtrl.CreateTableCellControls(o.TableCells);
                    }
                }
            }
        }

        private void NewRowCtrl_OnStateChanged(object sender)
        {
            if (this.OnStateChanged != null)
                this.OnStateChanged(sender);
        }

        TableRowObject Convert(TableRow row)
        {
            TableRowObject o = new TableRowObject();
            o.AddCellsFromControl(row.Cells);
            return o;
        }

        TableRow ConvertToTableRow(TableRowObject o)
        {
            TableRow row = new TableRow();
            this.panel1.Controls.Add(row);
            row.CreateTableCellControls(o.TableCells);
            return row;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            this.DeleteCurrentRow();
        }

        private void btnDeleteCell_Click(object sender, EventArgs e)
        {
            this.DeleteCurrentCell();
        }

        public void Clear()
        {
            panel1.Controls.Clear();
            if (this.OnStateChanged != null)
                this.OnStateChanged(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveRowUp();
        }

        void MoveRowUp()
        {
            TableRow currentRow = this.CurrentTableCell.ParentRow;
            int curRowIdx = currentRow.Index;

            int prevRowIdx = curRowIdx - 1;
            TableRow prevRow = GetTableRowByIndex(prevRowIdx);

            if(prevRow != null)
            {

                SwitchRow(prevRow, currentRow);
                if (this.OnStateChanged != null)
                    this.OnStateChanged(this);
            }
        }

        void MoveRowDown()
        {
            TableRow currentRow = this.CurrentTableCell.ParentRow;
            int curRowIdx = currentRow.Index;

            int prevRowIdx = curRowIdx + 1;
            TableRow nextRow = GetTableRowByIndex(prevRowIdx);

            if (nextRow != null)
            {

                SwitchRow( currentRow, nextRow);
                if (this.OnStateChanged != null)
                    this.OnStateChanged(this);
            }
        }

        void SwitchRow(TableRow prevRow, TableRow currentRow)
        {
            int curRowIdx = currentRow.Index;
            int prevRowIdx = prevRow.Index;

            int curtop = currentRow.Top;
            int prevtop = prevRow.Top;


            currentRow.Top = prevtop;
            prevRow.Top = curtop;

            prevRow.Index = curRowIdx;
            currentRow.Index = prevRowIdx;

        }

        TableRow GetTableRowByIndex(int idx)
        {
            foreach(TableRow row in this.panel1.Controls)
            {
                if (row.Index == idx)
                    return row;
            }

            return null;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveRowDown();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
