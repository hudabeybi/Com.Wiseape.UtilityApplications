using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    public class DatetimePropertyConfigurator : CommonPropertyConfigurator
    {
        private System.Windows.Forms.TextBox txtDateFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDateRange;
        private System.Windows.Forms.CheckBox chkWithTime;

        public DatetimePropertyConfigurator()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtDateFormat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkWithTime = new System.Windows.Forms.CheckBox();
            this.chkDateRange = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtDateFormat
            // 
            this.txtDateFormat.Location = new System.Drawing.Point(17, 182);
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Size = new System.Drawing.Size(273, 20);
            this.txtDateFormat.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date Format";
            // 
            // chkWithTime
            // 
            this.chkWithTime.AutoSize = true;
            this.chkWithTime.Location = new System.Drawing.Point(17, 147);
            this.chkWithTime.Name = "chkWithTime";
            this.chkWithTime.Size = new System.Drawing.Size(83, 17);
            this.chkWithTime.TabIndex = 12;
            this.chkWithTime.Text = "Include time";
            this.chkWithTime.UseVisualStyleBackColor = true;
            // 
            // chkDateRange
            // 
            this.chkDateRange.AutoSize = true;
            this.chkDateRange.Location = new System.Drawing.Point(17, 223);
            this.chkDateRange.Name = "chkDateRange";
            this.chkDateRange.Size = new System.Drawing.Size(84, 17);
            this.chkDateRange.TabIndex = 15;
            this.chkDateRange.Text = "Date Range";
            this.chkDateRange.UseVisualStyleBackColor = true;
            // 
            // DatetimePropertyConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.chkDateRange);
            this.Controls.Add(this.txtDateFormat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkWithTime);
            this.Name = "DatetimePropertyConfigurator";
            this.Size = new System.Drawing.Size(827, 254);
            this.Load += new System.EventHandler(this.DatetimePropertyConfigurator_Load);
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
            this.Controls.SetChildIndex(this.chkWithTime, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtDateFormat, 0);
            this.Controls.SetChildIndex(this.chkDateRange, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DatetimePropertyConfigurator_Load(object sender, EventArgs e)
        {

        }

        public override void Fill(Dictionary<string, object> properties)
        {
            base.Fill(properties);
            properties["DefaultDate"] = Convert.ToDateTime(txtDefaultValue.Text);
            properties["DateFormat"] = txtDateFormat.Text;
            properties["IncludeTime"] = chkWithTime.Checked;
            properties["DateRange"] = chkDateRange.Checked;
        }

        public override void Display(Dictionary<string, object> properties)
        {
            base.Display(properties);
            txtDateFormat.Text = properties["DateFormat"].ToString();
            chkWithTime.Checked = Convert.ToBoolean(properties["IncludeTime"]);
            txtDefaultValue.Text = properties["DefaultDate"].ToString();
            chkDateRange.Checked = Convert.ToBoolean(properties["DateRange"]);
        }
    }
}
