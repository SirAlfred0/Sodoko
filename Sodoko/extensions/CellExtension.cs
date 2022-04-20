using System;
using System.Collections.Generic;
using System.Linq;
using Sodoko.Model;

namespace Sodoko.extensions
{
    public static class CellExtension
    {

        public static void UpdateTable(this Cell cell, List<Cell> table)
        {
            foreach(var c in table)
            {
                if (c.ColNumber == cell.ColNumber && c.RowNumber == cell.RowNumber) continue;

                if(c.ColNumber == cell.ColNumber || c.RowNumber == cell.RowNumber || c.MatrixNumber == cell.MatrixNumber)
                {
                    if(!c.IsFilled())
                    {
                        c.RemovePermitedNumber(cell.ReadValue());
                    }
                }
            }
        }
    }
}
