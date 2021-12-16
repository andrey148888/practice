using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_8_kazakov_01._01
{
    internal interface IFigure
    {
        double GetCircleArea(double radius);

        double GetCirclePerimeter(double radius);

        double GetRectangleArea(double a, double b);

        double GetRectanglePerimeter(double a, double b);
    }
}
