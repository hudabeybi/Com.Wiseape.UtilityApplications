using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class GridDrawer : BaseDrawer, IElementDesignDrawer
    {
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;

        public GridDrawer(PropertyPage page) : base(page)
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            if (properties.ContainsKey("Label"))
                label1.Text = properties["Label"].ToString();
            if(properties.ContainsKey("GridColumns"))
            {
                List<GridColumn> cols = (List<GridColumn>)properties["GridColumns"];
                this.grid.Columns.Clear();
                foreach(GridColumn col in cols)
                {
                    grid.Columns.Add(col.ColumnName, col.ColumnText);
                }
            }
        }

        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(4, 22);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(633, 96);
            this.grid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grid";
            // 
            // GridDrawer
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid);
            this.Name = "GridDrawer";
            this.Size = new System.Drawing.Size(640, 131);
            this.Load += new System.EventHandler(this.GridDrawer_Load);
            this.Resize += new System.EventHandler(this.GridDrawer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GridDrawer_Resize(object sender, EventArgs e)
        {
            grid.Width = this.Width - 5;
            grid.Height = this.Height - grid.Top - 5;
        }

        private void GridDrawer_Load(object sender, EventArgs e)
        {

        }
    }
}
