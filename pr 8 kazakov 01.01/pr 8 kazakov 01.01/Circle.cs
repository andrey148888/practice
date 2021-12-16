using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_8_kazakov_01._01
{
    internal class Circle : IFigure, IComparable
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
            Rectangle rectangle = (Rectangle)obj;
            if (this.Area > rectangle.Area)
                return 1;
            if (this.Area < rectangle.Area)
                return -1;
            return 0;
        }

        public double GetCircleArea(double radius)
        {
            Area = Math.Round(Math.PI * Math.Pow(radius, 2), 3);
            return Area;
        }

        public double GetCirclePerimeter(double radius)
        {
            Perimeter = Math.Round(2 * Math.PI * radius, 3);
            return Perimeter;
        }

        public double GetRectangleArea(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double GetRectanglePerimeter(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
}
