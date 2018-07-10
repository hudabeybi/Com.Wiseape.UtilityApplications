using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class SelectBoxConfigurator : CommonPropertyConfigurator
    {
        private System.Windows.Forms.RadioButton rdStatic;
        private System.Windows.Forms.RadioButton rdDynamic;
        private System.Windows.Forms.Panel pnlValues;

        private SelectDynamicValueCtrl selectDynamicValueCtrl = new SelectDynamicValueCtrl();
        private SelectStaticValueCtrl selectStaticValueCtrl = new SelectStaticValueCtrl();

        public SelectBoxConfigurator(PropertyPage propertyPage) : base(propertyPage)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.rdStatic = new System.Windows.Forms.RadioButton();
            this.rdDynamic = new System.Windows.Forms.RadioButton();
            this.pnlValues = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rdStatic
            // 
            this.rdStatic.AutoSize = true;
            this.rdStatic.Checked = true;
            this.rdStatic.Location = new System.Drawing.Point(13, 194);
            this.rdStatic.Name = "rdStatic";
            this.rdStatic.Size = new System.Drawing.Size(87, 17);
            this.rdStatic.TabIndex = 12;
            this.rdStatic.TabStop = true;
            this.rdStatic.Text = "Static Values";
            this.rdStatic.UseVisualStyleBackColor = true;
            this.rdStatic.CheckedChanged += new System.EventHandler(this.rdStatic_CheckedChanged);
            // 
            // rdDynamic
            // 
            this.rdDynamic.AutoSize = true;
            this.rdDynamic.Location = new System.Drawing.Point(125, 194);
            this.rdDynamic.Name = "rdDynamic";
            this.rdDynamic.Size = new System.Drawing.Size(101, 17);
            this.rdDynamic.TabIndex = 13;
            this.rdDynamic.Text = "Dynamic Values";
            this.rdDynamic.UseVisualStyleBackColor = true;
            this.rdDynamic.CheckedChanged += new System.EventHandler(this.rdDynamic_CheckedChanged);
            // 
            // pnlValues
            // 
            this.pnlValues.Location = new System.Drawing.Point(3, 217);
            this.pnlValues.Name = "pnlValues";
            this.pnlValues.Size = new System.Drawing.Size(799, 262);
            this.pnlValues.TabIndex = 14;
            // 
            // SelectBoxConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.pnlValues);
            this.Controls.Add(this.rdDynamic);
            this.Controls.Add(this.rdStatic);
            this.Name = "SelectBoxConfigurator";
            this.Size = new System.Drawing.Size(827, 503);
            this.Load += new System.EventHandler(this.SelectBoxConfigurator_Load);
            this.Controls.SetChildIndex(this.txtPlaceholder, 0);
            this.Controls.SetChildIndex(this.lblPlaceholder, 0);
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
            this.Controls.SetChildIndex(this.rdStatic, 0);
            this.Controls.SetChildIndex(this.rdDynamic, 0);
            this.Controls.SetChildIndex(this.pnlValues, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SelectBoxConfigurator_Load(object sender, EventArgs e)
        {
            AddCtrl();
        }

        private void rdStatic_CheckedChanged(object sender, EventArgs e)
        {
            AddCtrl();
        }

        private void rdDynamic_CheckedChanged(object sender, EventArgs e)
        {
            AddCtrl();
        }

        void AddCtrl()
        {
            this.pnlValues.Controls.Clear();
            if (rdStatic.Checked)
            {
                this.pnlValues.Controls.Add(this.selectStaticValueCtrl);
            }
            else
            {
                this.pnlValues.Controls.Add(this.selectDynamicValueCtrl);
            }
        }

        public override void Fill(Dictionary<string, object> properties)
        {
            base.Fill(properties);
            
            properties["IsStatic"] = rdStatic.Checked;
            properties["QueryOrUrl"] = this.selectDynamicValueCtrl.QueryOrUrl;
            properties["ValueMember"] = this.selectDynamicValueCtrl.ValueMember;
            properties["DisplayMember"] = this.selectDynamicValueCtrl.DisplayMember;

            Dictionary<string, string> items = this.selectStaticValueCtrl.GetItems();
            properties["Items"] = items;
        }

        public override void Display(Dictionary<string, object> properties)
        {
            base.Display(properties);
            bool ok = properties.ContainsKey("IsStatic");
            this.rdStatic.Checked = Convert.ToBoolean( properties["IsStatic"]);
            try
            {
                this.selectStaticValueCtrl.DisplayItems((Dictionary<string, string>)properties["Items"]);
            }
            catch
            {

            }
            
            this.selectDynamicValueCtrl.QueryOrUrl = properties["QueryOrUrl"].ToString();
            this.selectDynamicValueCtrl.ValueMember = properties["ValueMember"].ToString();
            this.selectDynamicValueCtrl.DisplayMember = properties["DisplayMember"].ToString();
        }
    }
}
