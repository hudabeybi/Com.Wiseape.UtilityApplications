﻿using System;
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
    [Serializable]
    public partial class CommonPropertyConfigurator : UserControl, IElementConfigurator
    {
        protected PropertyPage propertyPage;
        public PropertyPage PropertyPage { get { return this.propertyPage; } set { propertyPage = value; } }
        public delegate void OnClickDelegate(CommonPropertyConfigurator element);
        public event OnClickDelegate OnClickEvent;


        public CommonPropertyConfigurator()
        {
            InitializeComponent();
        }
        public CommonPropertyConfigurator(PropertyPage propertyPage)
        {
            this.PropertyPage = propertyPage;
            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (this.OnClickEvent != null)
                this.OnClickEvent(this);
        }

        private void CommonPropertyControl_Load(object sender, EventArgs e)
        {
        }

        public virtual void Fill(Dictionary<string, object> properties)
        {
            properties["ID"] = txtID.Text;
            properties["CssClass"] = txtClass.Text;
            properties["DefaultValue"] = txtDefaultValue.Text;
            properties["Label"] = txtLabel.Text;
            properties["CssStyle"] = txtStyle.Text;
            properties["DataField"] = txtDataField.Text;
            properties["Placeholder"] = txtPlaceholder.Text;
            properties["OnClick"] = txtOnClick.Text;
            properties["OnChange"] = txtOnChangeHandler.Text;

        }

        public virtual void Display(Dictionary<string, object> properties)
        {
            txtID.Text = properties["ID"].ToString();
            txtClass.Text = properties["CssClass"].ToString();
            txtDefaultValue.Text = properties["DefaultValue"].ToString();
            
            txtStyle.Text = properties["CssStyle"].ToString();
            txtDataField.Text = properties["DataField"].ToString();
            txtPlaceholder.Text = properties["Placeholder"].ToString();
            txtLabel.Text = properties["Label"].ToString();

            txtOnClick.Text = properties["OnClick"].ToString();
            txtOnChangeHandler.Text = properties["OnChange"].ToString();
        }

        private void txtLabel_TextChanged(object sender, EventArgs e)
        {
            txtPlaceholder.Text = "{PLEASE_ENTER_" + txtLabel.Text + "}";
        }
    }
}
