using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;

namespace Sodoko.Model
{
    public class Cell : BaseCell
    {
       

        private List<int> PermitedNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private bool filled = false;

        private int Value { get; set; }
        public int MatrixNumber { get; set; }
        public bool IsFilled() => filled;
        public int ReadValue() => Value;
        public int GetPermitedNumbersLength() => PermitedNumbers.Count();


        public void RemovePermitedNumber(int v)
        {
            if (PermitedNumbers.Contains(v))
                PermitedNumbers.Remove(v);
        }

        public void Fill(int v)
        {
            Value = v;
            PermitedNumbers = new List<int>() { v };
            filled = true;
        }

        public void AutoFill()
        {
            Value = PermitedNumbers[0];
            filled = true;
        }

        public int RandomFill()
        {
            var r = new Random();
            var randomValue = r.Next(0, GetPermitedNumbersLength() - 1);

            Fill(PermitedNumbers[randomValue]);

            return PermitedNumbers[0];
        }
    }
}
