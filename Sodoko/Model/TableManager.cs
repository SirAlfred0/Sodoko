using System;
using System.Collections.Generic;
using System.Linq;
using Sodoko.extensions;

namespace Sodoko.Model
{
    public class TableManager
    {
        private List<Cell> table = new List<Cell>();


        public TableManager()
        {
            for (var j = 0; j < 9; j++)
            {
                for (var i = 0; i < 9; i++)
                {
                    table.Add(new Cell()
                    {
                        RowNumber = j + 1,
                        ColNumber = i + 1,
                        MatrixNumber = (i / 3) + 1 + (j / 3 * 3),
                    });
                }
            }
        }

        public void SetPreFilledCells(List<PreFilledCell> preFilledCells)
        {
            foreach (var item in preFilledCells)
            {
                var index = ((item.RowNumber - 1) * 9) + item.ColNumber;
                table[index - 1].Fill(item.Value);
                table[index - 1].UpdateTable(table);
            }
        }

        public void Solve()
        {
            var solvedCells = 0;
            var MinPermitedNumberCell = new Cell();
            while(table.Any(c => !c.IsFilled()))
            {
                solvedCells = 0;
                foreach (var cell in table)
                {
                    if (!cell.IsFilled())
                    {
                        if (cell.GetPermitedNumbersLength() == 1)
                        {
                            cell.AutoFill();
                            cell.UpdateTable(table);
                            solvedCells++;
                            MinPermitedNumberCell = new Cell();
                        }
                        else if(MinPermitedNumberCell.GetPermitedNumbersLength() >= cell.GetPermitedNumbersLength())
                        {
                            MinPermitedNumberCell = cell;
                        }
                    }
                }

                if(solvedCells == 0 && !MinPermitedNumberCell.IsFilled())
                {
                    MinPermitedNumberCell.RandomFill();
                    MinPermitedNumberCell.UpdateTable(table);
                    MinPermitedNumberCell = new Cell();
                }
            }
        }

        public void Print()
        {
            for (var i = 0; i < 81; i++)
            {
                if (i % 3 == 0) Console.Write("\t");
                if (i % 9 == 0) Console.WriteLine("");
                if (i % 27 == 0) Console.WriteLine("");

                Console.Write(table[i].ReadValue() + " ");
            }

            Console.WriteLine();
        }
    }
}
