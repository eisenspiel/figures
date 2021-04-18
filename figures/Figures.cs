using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public static class Circle
    {
        //Вычисляет площадь круга
        public static double GetArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double GetArea(int radius)
        {
            return Math.PI * radius * radius;
        }
    }

    public static class Triangle
    {
        //Вычисляет площадь треугольника
        public static double GetArea(double a, double b, double c)
        {
            double p = a + b + c;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double GetArea(int a, int b, int c)
        {
            double p = a + b + c;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //Проверяет, является ли треугольник прямоугольным
        public static bool IsRight(double a, double b, double c)
        {
            return ( (a*a == b*b + c*c) || (b * b == a * a + c * c )|| (c * c == a * a + b * b));
        }

        public static bool IsRight(int a, int b, int c)
        {
            return ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b));
        }
    }
}
