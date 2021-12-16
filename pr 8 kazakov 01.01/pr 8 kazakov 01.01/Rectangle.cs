using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_8_kazakov_01._01
{
    internal class Rectangle : IFigure, IComparable
    {
        private double _perimeter;
        private double _area;

        public double Perimeter
        {
            get { return _perimeter; }
            set
            {
                if (value > 0)
                    _perimeter = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public double Area
        {
            get { return _area; }
            set
            {
                if (value > 0)
                    _area = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public int CompareTo(object? obj)
        {
            Circle circle = (Circle)obj;
            if (this.Area > circle.Area)
                return 1;
            if (this.Area < circle.Area)
                return -1;
            return 0;
        }

        public double GetCircleArea(double radius)
        {
            throw new NotImplementedException();
        }

        public double GetCirclePerimeter(double radius)
        {
            throw new NotImplementedException();
        }

        public double GetRectangleArea(double a, double b)
        {
            Area = a * b;
            return Area;
        }

        public double GetRectanglePerimeter(double a, double b)
        {
            Perimeter = 2 * (a + b);
            return Perimeter;
        }
    }
}
