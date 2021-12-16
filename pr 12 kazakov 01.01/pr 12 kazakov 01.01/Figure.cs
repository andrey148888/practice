using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_12_kazakov_01._01
{
    internal class Figure
    {
        public int GetFigure(int number)
        {
            number = number % 100 / 10;
            return number;

        }
    }
}
