using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_5_kazakov_01._01
{
    class Triad
    {
        private int _first;
        private int _second;
        private int _third;

        public int First { get { return _first; } set { _first = value; } }

        public int Second { get { return _second; } set { _second = value; } }

        public int Third { get { return _third; } set { _third = value; } }

        // описан но не реализован
        public void SetParams(int number)
        {
            First = number;
            Second = number;
            Third = number;
        }

        public void Clear()
        {
            First = 0;
            Second = 0;
            Third = 0;
        }

        public void SetParams(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public bool Compare(Triad triad)
        {
            return ((First > triad.First || First == triad.First) && Second > triad.Second && Third > triad.Third);
        }

        public void IncreaseTenTimes()
        {
                First *= 10;
                Second *= 10;
                Third *= 10;
        }
    }
}
