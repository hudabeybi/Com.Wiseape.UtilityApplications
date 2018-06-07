using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class DataSourceUITable : DataSourceTable
    {
        List<UIColumn> columns = new List<UIColumn>();
        public List<UIColumn> DataColumns2
        {
            get
            {
                return columns;
            }

            set
            {
                columns = value;
            }
        }

        public int TotalViewColumn
        {
            get
            {
                int total = 0;
                foreach(UIColumn uiColumn in this.DataColumns)
                {
                    if (uiColumn.View)
                        total++;
                }
                return total;
            }
        }

        public int TotalAddColumn
        {
            get
            {
                int total = 0;
                foreach (UIColumn uiColumn in this.DataColumns)
                {
                    if (uiColumn.Add)
                        total++;
                }
                return total;
            }
        }

        public int TotalEditColumn
        {
            get
            {
                int total = 0;
                foreach (UIColumn uiColumn in this.DataColumns)
                {
                    if (uiColumn.Edit)
                        total++;
                }
                return total;
            }
        }

        public int TotalDeleteColumn
        {
            get
            {
                int total = 0;
                foreach (UIColumn uiColumn in this.DataColumns)
                {
                    if (uiColumn.Delete)
                        total++;
                }
                return total;
            }
        }

        public int TotalDetailColumn
        {
            get
            {
                int total = 0;
                foreach (UIColumn uiColumn in this.DataColumns)
                {
                    if (uiColumn.Detail)
                        total++;
                }
                return total;
            }
        }
    }
}
