using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class GridPropertyPage : PropertyPage
    {
        public GridPropertyPage()
        {
            this.Properties.Add("Sortable", true);
            this.Properties.Add("ShowSimpleSearch", true);
            this.Properties.Add("ShowAdvanceSearch", true);
            this.Properties.Add("ShowExport", true);
            this.Properties.Add("ShowSummary", true);
            this.Properties.Add("ShowCheckboxes", true);
            this.Properties.Add("DatasourceInfo", "");
            this.Properties.Add("GridColumns", new List<GridColumn>());

            List<GridActionButton> buttons = new List<GridActionButton>();
            buttons.Add(new GridActionButton("btnAdd", "Add", "icon-add", "btnAddClick"));
            buttons.Add(new GridActionButton("btnEdit", "Edit", "icon-edit", "btnEditClick"));
            buttons.Add(new GridActionButton("btnDelete", "Delete", "icon-delete", "btnDeleteClick"));
            buttons.Add(new GridActionButton("btnSearch", "Search", "icon-search", "btnSearchClick"));
            buttons.Add(new GridActionButton("btnSummary", "Create Summary", "icon-summary", "btnSummaryClick"));
            this.Properties.Add("GridActionButtons", buttons);


            this.PropertyConfigurator = new GridConfigurator(this);
            this.Drawer = new GridDrawer(this);
        }

        public override PropertyPage CreateNew(int idx = 0)
        {
            PropertyPage p = new GridPropertyPage();
            p.Properties["ID"] = "grid" + idx;
            return p;
        }

        public override string GetElementID()
        {
            return Settings.Default.GRID;
        }

        public override string GetElementName()
        {
            return "Grid";
        }

        public override Image GetIcon()
        {
            return Resources.grid_on;
        }
    }
}
