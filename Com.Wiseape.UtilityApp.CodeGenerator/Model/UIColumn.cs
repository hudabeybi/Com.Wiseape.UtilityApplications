using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class UIColumn : DataColumn
    {
        public enum ControlType
        {
            Textbox=1,
            Combobox=2,
            LookupCombobox=10,
            Radiobuttons=3,
            LookupRadiobuttons=11,
            Checkboxes=4,
            LookupCheckboxes=12,
            Date=5,
            Datetime=6,
            Daterange=7,
            Image=8,
            File=9,
            Numericbox=13,
            Textarea=14,
            HtmlEditor=15
        }
        public string Label {
            get
            {
                return this.ColumnText;
            }
            set
            {
                this.ColumnText = value;
            }
        }

        public bool View { get; set; }

        public bool Detail { get; set; }

        public bool Add { get; set; }

        public bool Edit { get; set; }

        public bool Delete { get; set; }

        public string InputGroup { get; set; }

        public ControlType CtrlType { get; set; }

       
    }
}
