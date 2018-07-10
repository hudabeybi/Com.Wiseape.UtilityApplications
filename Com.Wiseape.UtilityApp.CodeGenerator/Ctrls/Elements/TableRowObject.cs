using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    [Serializable()]
    public class TableRowObject
    {
        public List<TableCellObject> TableCells = new List<TableCellObject>();
        public void AddCellsFromControl(List<TableCell> cellCtrls)
        {
            foreach(TableCell cell in cellCtrls)
            {
                TableCellObject cellObject = new TableCellObject();
                cellObject.TableCellName = cell.Name;
                if(cell.Element != null)
                    cellObject.AddElementFromControl(cell.Element);
                TableCells.Add(cellObject);
            }
        }


    }
}
