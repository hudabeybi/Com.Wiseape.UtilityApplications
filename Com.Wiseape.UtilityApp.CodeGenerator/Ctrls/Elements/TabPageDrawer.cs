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
    public partial class TabPageDrawer : BaseDrawer, IElementDesignDrawer
    {
        public List<TabItem> TabItems
        {
            get
            {
                List<TabItem> items = new List<TabItem>();
                foreach (Control tabCtrlItem in tabCtrl.TabPages)
                {
                    TabItem item = new TabItem(tabCtrlItem.Name, tabCtrlItem.Text);
                    if(tabCtrlItem.Controls.Count > 0)
                        item.TableRowObjects = ((ElementLayoutDesigner)tabCtrlItem.Controls[0]).TableRows;
                    items.Add(item);
                }
                return items;
            }
            set
            {
                if (value != null)
                {
                    tabCtrl.TabPages.Clear();
                    foreach (TabItem item in value)
                    {
                        tabCtrl.TabPages.Add(item.TabName, item.TabLabel);
                        DrawTabItem(item);
                    }
                }
            }
        }

        public TabPageDrawer(PropertyPage page) : base(page)
        {
            InitializeComponent();
        }

        public void Draw(Dictionary<string, object> properties)
        {
            List<TabItem> items = null;
            if(properties.ContainsKey("TabItems"))
                  items = (List<TabItem>)  properties["TabItems"];
            this.TabItems = items;
        }

        private void TabPageDrawer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            int idx = this.tabCtrl.SelectedIndex;
            List<TabItem> items = this.TabItems;
            TabItem newItm = new TabItem("tabPage" + (items.Count + 1), "tabPage" + (items.Count + 1));
            items.Add(newItm);
            this.TabItems = items;
            this.tabCtrl.SelectedIndex = idx;
        }

        TabItem GetOpenedTabItem()
        {
            string tabname = tabCtrl.SelectedTab.Name;
            List<TabItem> items = this.TabItems;
            foreach(TabItem item in items)
            {
                if (item.TabName == tabname)
                    return item;
            }
            return null;
        }

        System.Windows.Forms.TabPage GetTabPageByName(string name)
        {
            foreach(TabPage page in this.tabCtrl.TabPages)
            {
                if (page.Name == name)
                    return page;
            }
            return null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            TabItem curItem = GetOpenedTabItem();
            List<TabItem> items = this.TabItems;
            RemoveTabItem(items, curItem);
            this.TabItems = items;
        }

        void RemoveTabItem(List<TabItem> items, TabItem item)
        {
            TabItem selItem = null;
            foreach(TabItem it in items)
            {
                if(it.TabName == item.TabName)
                {
                    selItem = it;
                    break;
                }

            }
            items.Remove(selItem);
        }


        void UpdateTabItem(List<TabItem> items, TabItem item, string name)
        {
            foreach (TabItem it in items)
            {
                if (it.TabName == name)
                {
                    it.TabLabel = item.TabLabel;
                    it.TabName = item.TabName;
                    it.TableRowObjects = item.TableRowObjects;
                    
                    break;
                }
            }
        }

        void DrawTabItem(TabItem item)
        {
            TabPage page = GetTabPageByName(item.TabName);
            page.AutoScroll = true;

            if (item.TableRowObjects != null)
            {
                ElementLayoutDesigner layoutDesigner = new ElementLayoutDesigner();
                layoutDesigner.TableRows = item.TableRowObjects;
                layoutDesigner.ShowButtons = false;

                page.Controls.Add(layoutDesigner);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TabItem item = GetOpenedTabItem();
            string name = item.TabName;
            FormTabPageConfigure frm = new FormTabPageConfigure();
            frm.TabItem = item;
            frm.ShowDialog();
            if (frm.Iscanceled == false)
            {
                item = frm.TabItem;
                List<TabItem> items = this.TabItems;
                UpdateTabItem(items, item, name);
                this.TabItems = items;

            }
        }

        private void TabPageDrawer_Resize(object sender, EventArgs e)
        {
            tabCtrl.Width = this.Width - 10;
            tabCtrl.Height = this.Height - tabCtrl.Top - 10;
        }
    }
}
