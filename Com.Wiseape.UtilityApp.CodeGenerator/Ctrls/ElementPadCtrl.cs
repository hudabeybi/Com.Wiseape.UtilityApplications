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
        List<PropertyPage> elementDesigners = new List<PropertyPage>();

        public delegate void OnClickDelegate(PropertyPage ctrl);
        public event OnClickDelegate OnClickEventHandler;

        public ElementPadCtrl()
        {
            InitializeComponent();
        }

        private void ElementPadCtrl_Load(object sender, EventArgs e)
        {
            AddElementDesigners();
            DisplayElementDesigners();
        }

        void AddElementDesigners()
        {
            TextboxPropertyPage ctrl = new TextboxPropertyPage();
            //ctrl.OnClickEvent += Ctrl_OnClickEvent;
            elementDesigners.Add(ctrl);

            TextareaPropertyPage ctrl2 = new TextareaPropertyPage();
            //ctrl2.OnClickEvent += Ctrl_OnClickEvent;
            elementDesigners.Add(ctrl2);

            SelectBoxPropertyPage ctrl3 = new SelectBoxPropertyPage();
            //ctrl2.OnClickEvent += Ctrl_OnClickEvent;
            elementDesigners.Add(ctrl3);

            RadioGroupPropertyPage ctrl4 = new RadioGroupPropertyPage();
            elementDesigners.Add(ctrl4);

            CheckboxPropertyPage ctrl5 = new CheckboxPropertyPage();
            elementDesigners.Add(ctrl5);

            DateTimePropertyPage ctrl6 = new DateTimePropertyPage();
            elementDesigners.Add(ctrl6);

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

        private void Btn_Click(object sender, EventArgs e)
        {
            if (this.OnClickEventHandler != null)
                this.OnClickEventHandler(((PropertyPage)((Button)sender).Tag).CreateNew());
        }
    }
}
