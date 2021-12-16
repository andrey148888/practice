using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_12_kazakov_01._01
{
    internal class RightTriangle
    {
        private double _hypotenuse, _perimeter;

        public double Hypotenuse { get { return _hypotenuse; } private set { _hypotenuse = value; } }
        public double Perimeter { get { return _perimeter; } private set { _perimeter = value; } }

        public void GetHypotenuse(double a, double b)
        {
            Hypotenuse = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 3);
        }

        public void GetPerimeter(double a, double b)
        {
            Perimeter = a + b + Hypotenuse;
        }
    }

}
