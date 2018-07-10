using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements;


namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls
{
    public partial class ElementPadCtrl : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        List<PropertyPage> elementDesigners = new List<PropertyPage>();

        [Browsable(false)]
        public delegate void OnClickDelegate(PropertyPage ctrl);

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event OnClickDelegate OnClickEventHandler;

        private string indexesToShow = "0,1,2,3,4,5,6,7";

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string IndexesToShow {
                get { return indexesToShow; }
                set
                {
                    indexesToShow = value;
                    AddElementDesigners();
                    DisplayElementDesigners();
                }
        }

        public ElementPadCtrl()
        {
            InitializeComponent();
            AddElementDesigners();
            DisplayElementDesigners();
        }

        private void ElementPadCtrl_Load(object sender, EventArgs e)
        {

        }

        List<PropertyPage> pages = new List<PropertyPage>();
        List<int> counters = new List<int>();

        void AddElementDesigners()
        {
            string[] indexes = IndexesToShow.Split(new char[] { ',' });

            pages.Clear();
            pages.Add(new TextboxPropertyPage());
            pages.Add(new TextareaPropertyPage());
            pages.Add(new SelectBoxPropertyPage());
            pages.Add(new RadioGroupPropertyPage());
            pages.Add(new CheckboxPropertyPage());
            pages.Add(new DateTimePropertyPage());
            pages.Add(new GridPropertyPage());
            pages.Add(new TabPagesPropertyPage());
            pages.Add(new FileUploadPropertyPage());

            counters.Clear();
            counters.Add(1);
            counters.Add(1);
            counters.Add(1);
            counters.Add(1);
            counters.Add(1);
            counters.Add(1);
            counters.Add(1);
            counters.Add(1);
            counters.Add(1);


            elementDesigners.Clear();
            foreach (string idx in indexes)
            {
                PropertyPage pg = pages[Convert.ToInt16(idx)];
                elementDesigners.Add(pg);
            }

        }

        private void Ctrl_Click(object sender, EventArgs e)
        {

        }

        private void Ctrl_OnClickEvent(CommonPropertyConfigurator element)
        {

        }

        void DisplayElementDesigners()
        {
            int top = 0;
            foreach(PropertyPage ctrl in this.elementDesigners)
            {
                Button btn = new Button();
                btn.Text = ctrl.GetElementName();
                btn.FlatStyle = FlatStyle.Popup;
                btn.Width = this.Width;
                btn.Height = 30;
                btn.Image = ctrl.GetIcon();
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.Click += Btn_Click;
                btn.Tag = ctrl;
                this.Controls.Add(btn);
                btn.Top = top;
                top += 28;
            }
        }

        int GetPropertyPageIndex(PropertyPage p)
        {
            int idx = 0;
            foreach(PropertyPage page in pages)
            {
                if (p.GetElementID() == page.GetElementID())
                    return idx;
                idx++;
            }
            return idx;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            PropertyPage page = (PropertyPage)((Button)sender).Tag;
            int idx = GetPropertyPageIndex(page);
            int counter = counters[idx];
            PropertyPage newPage = page.CreateNew(counter);
            counters[idx] = counter + 1;
            if (this.OnClickEventHandler != null)
                this.OnClickEventHandler(newPage);
        }
    }
}
