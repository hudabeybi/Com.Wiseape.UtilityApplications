using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public partial class TabPagesConfigurator : CommonPropertyConfigurator
    {
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddTab;


        public List<TabItem> TabItems
        {
            get
            {
                List<TabItem> items = new List<TabItem>();
                foreach (Control tabCtrlItem in tabCtrl.TabPages)
                {
                    TabItem item = new TabItem(tabCtrlItem.Name, tabCtrlItem.Text);
                    if (tabCtrlItem.Controls.Count > 0)
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

        public TabPagesConfigurator(PropertyPage propertyPage) : base(propertyPage)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddTab = new System.Windows.Forms.Button();
            this.tabCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(18, 106);
            this.txtDefaultValue.Size = new System.Drawing.Size(389, 20);
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Location = new System.Drawing.Point(14, 204);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(792, 318);
            this.tabCtrl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(199, 175);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "o Edit Tab";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(105, 175);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "- Remove Tab";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddTab
            // 
            this.btnAddTab.Location = new System.Drawing.Point(17, 175);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(91, 23);
            this.btnAddTab.TabIndex = 5;
            this.btnAddTab.Text = "+ Add Tab";
            this.btnAddTab.UseVisualStyleBackColor = true;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // TabPagesConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddTab);
            this.Name = "TabPagesConfigurator";
            this.Size = new System.Drawing.Size(827, 540);
            this.Load += new System.EventHandler(this.TabPagesConfigurator_Load);
            this.Resize += new System.EventHandler(this.TabPagesConfigurator_Resize);
            this.Controls.SetChildIndex(this.txtPlaceholder, 0);
            this.Controls.SetChildIndex(this.lblPlaceholder, 0);
            this.Controls.SetChildIndex(this.btnAddTab, 0);
            this.Controls.SetChildIndex(this.btnRemove, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.tabCtrl, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtClass, 0);
            this.Controls.SetChildIndex(this.txtStyle, 0);
            this.Controls.SetChildIndex(this.txtDefaultValue, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtLabel, 0);
            this.Controls.SetChildIndex(this.txtDataField, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.tabCtrl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TabPagesConfigurator_Load(object sender, EventArgs e)
        {

        }

        public override void Fill(Dictionary<string, object> properties)
        {
            base.Fill(properties);
            if (properties.ContainsKey("TabItems"))
                properties["TabItems"] = this.TabItems;
            else
                properties.Add("TabItems", this.TabItems);
        }

        public override void Display(Dictionary<string, object> properties)
        {
            base.Display(properties);
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            TabItem curItem = GetOpenedTabItem();
            List<TabItem> items = this.TabItems;
            RemoveTabItem(items, curItem);
            this.TabItems = items;
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

        void RemoveTabItem(List<TabItem> items, TabItem item)
        {
            TabItem selItem = null;
            foreach (TabItem it in items)
            {
                if (it.TabName == item.TabName)
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


        TabItem GetOpenedTabItem()
        {
            string tabname = tabCtrl.SelectedTab.Name;
            List<TabItem> items = this.TabItems;
            foreach (TabItem item in items)
            {
                if (item.TabName == tabname)
                    return item;
            }
            return null;
        }

        System.Windows.Forms.TabPage GetTabPageByName(string name)
        {
            foreach (TabPage page in this.tabCtrl.TabPages)
            {
                if (page.Name == name)
                    return page;
            }
            return null;
        }

        private void TabPagesConfigurator_Resize(object sender, EventArgs e)
        {
            tabCtrl.Width = this.Width - 10;
            tabCtrl.Height = this.Height - tabCtrl.Top - 10;
        }
    }
}
