using System;
using System.Collections.Generic;
using Sodoko.Model;



namespace Sodoko
{
    class Program
    {
        static void Main(string[] args)
        {
            var preFilledCells = new List<PreFilledCell>();
            #region test values
            /*{
               new PreFilledCell{
                   ColNumber = 2,
                   RowNumber = 1,
                   Value = 8,
               },
               new PreFilledCell{
                   ColNumber = 3,
                   RowNumber = 1,
                   Value = 3,
               },
               new PreFilledCell{
                   ColNumber = 6,
                   RowNumber = 1,
                   Value = 2,
               },
               new PreFilledCell{
                   ColNumber = 7,
                   RowNumber = 1,
                   Value = 6,
               },
               new PreFilledCell{
                   ColNumber = 9,
                   RowNumber = 1,
                   Value = 4,
               },
               new PreFilledCell{
                   ColNumber = 5,
                   RowNumber = 2,
                   Value = 3,
               },
               new PreFilledCell{
                   ColNumber = 6,
                   RowNumber = 2,
                   Value = 9,
               },
               new PreFilledCell{
                   ColNumber = 7,
                   RowNumber = 2,
                   Value = 2,
               },
               new PreFilledCell{
                   ColNumber = 4,
                   RowNumber = 3,
                   Value = 8,
               },
               new PreFilledCell{
                   ColNumber = 6,
                   RowNumber = 3,
                   Value = 4,
               },
               new PreFilledCell{
                   ColNumber = 7,
                   RowNumber = 3,
                   Value = 7,
               },
                              new PreFilledCell{
                   ColNumber = 8,
                   RowNumber = 3,
                   Value = 3,
               },
               new PreFilledCell{
                   ColNumber = 1,
                   RowNumber = 4,
                   Value = 4,
               },
               new PreFilledCell{
                   ColNumber = 3,
                   RowNumber = 4,
                   Value = 1,
               },
               new PreFilledCell{
                   ColNumber = 1,
                   RowNumber = 5,
                   Value = 9,
               },
               new PreFilledCell{
                   ColNumber = 2,
                   RowNumber = 5,
                   Value = 7,
               },
               new PreFilledCell{
                   ColNumber = 3,
                   RowNumber = 5,
                   Value = 6,
               },
               new PreFilledCell{
                   ColNumber = 7,
                   RowNumber = 5,
                   Value = 1,
               },
               new PreFilledCell{
                   ColNumber = 8,
                   RowNumber = 5,
                   Value = 4,
               },
               new PreFilledCell{
                   ColNumber = 9,
                   RowNumber = 5,
                   Value = 2,
               },
               new PreFilledCell{
                   ColNumber = 7,
                   RowNumber = 6,
                   Value = 9,
               },
               new PreFilledCell{
                   ColNumber = 9,
                   RowNumber = 6,
                   Value = 3,
               },
               new PreFilledCell{
                   ColNumber = 2,
                   RowNumber = 7,
                   Value = 2,
               },
               new PreFilledCell{
                   ColNumber = 3,
                   RowNumber = 7,
                   Value = 7,
               },
               new PreFilledCell{
                   ColNumber = 4,
                   RowNumber = 7,
                   Value = 9,
               },
               new PreFilledCell{
                   ColNumber = 6,
                   RowNumber = 7,
                   Value = 5,
               },
               new PreFilledCell{
                   ColNumber = 4,
                   RowNumber = 8,
                   Value = 6,
               },
               new PreFilledCell{
                   ColNumber = 5,
                   RowNumber = 8,
                   Value = 1,
               },
               new PreFilledCell{
                   ColNumber = 1,
                   RowNumber = 9,
                   Value = 1,
               },
               new PreFilledCell{
                   ColNumber = 3,
                   RowNumber = 9,
                   Value = 9,
               },
               new PreFilledCell{
                   ColNumber = 4,
                   RowNumber = 9,
                   Value = 3,
               },
               new PreFilledCell{
                   ColNumber = 7,
                   RowNumber = 9,
                   Value = 4,
               },
               new PreFilledCell{
                   ColNumber = 8,
                   RowNumber = 9,
                   Value = 7,
               },
            };
            */

            #endregion

            var table = new TableManager();

            int r,c,v;

            Console.WriteLine("add prefilled cells");
            Console.WriteLine("Enter 0 for continue To Solve Your Table");

            do {
                Console.WriteLine("Enter Cell Row Number:");
                r = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter Cell Col Number:");
                c = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter Cell Value:");
                v = Convert.ToInt16(Console.ReadLine());

                if (v == 0 || c == 0 || r == 0) continue;

                preFilledCells.Add(new PreFilledCell()
                {
                    RowNumber = r,
                    ColNumber = c,
                    Value = v
                });
            } 
            while (v != 0 && c != 0 && r != 0);


            table.SetPreFilledCells(preFilledCells);

            Console.WriteLine("Table Before Solve: ");
            table.Print();

            table.Solve();

            Console.WriteLine("Table After Solve: ");
            table.Print();
        }
    }
}
