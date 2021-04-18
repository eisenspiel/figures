using System;
using Figures;

namespace figures
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 10.5;
            Console.WriteLine($"Площадь круга с радиусом {r} равна {Math.Round(Circle.GetArea(r), 2)}");
            Console.WriteLine($"Площадь круга с радиусом {(int)r} равна {Math.Round(Circle.GetArea((int)r), 2)}");
            Console.WriteLine();

            int a = 3;
            int b = 4;
            int c = 5;
            double area1 = Math.Round(Triangle.GetArea(a, b, c), 2);

            Console.WriteLine($"Площадь треугольника со сторонами {a}, {b}, {c} равна {area1}");
            if (Triangle.IsRight(a, b, c)) Console.WriteLine("Это прямоугольный треугольник");
            else Console.WriteLine("Это не прямоугольный треугольник");
            Console.WriteLine();

            double x = 3.5;
            double y = 8.0;
            double z = 14.4;
            double area2 = Math.Round(Triangle.GetArea(x, y, z), 2);

            Console.WriteLine($"Площадь треугольника со сторонами {x}, {y}, {z}" +
                $" равна {area2}");
            if (Triangle.IsRight(x, y, z)) Console.WriteLine("Это прямоугольный треугольник");
            else Console.WriteLine("Это не прямоугольный треугольник");
        }
    }
}
