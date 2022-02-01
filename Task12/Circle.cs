using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    static class Circle
    {
        static public double GetCircumference(int r)
        {
            return 2 * r * Math.PI;
        }
        static public double GetSquare(int r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        static public string ToBelong(int x, int y, int r)
        {
            double xy = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (xy<=r)
            {
                return "Точка принадлежит кругу";
            }
            else
            {
                return "Точка не принадлежит кругу";
            }
               
        }
    }
}
