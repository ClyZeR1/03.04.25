using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            List<Figure> figures = new List<Figure>()
        {
            new Rectangle("Прямоугольник", 10, 5),
            new Square("Квадрат", 7),
            new Circle("Круг", 4),
            new Triangle("Треугольник", 3, 4, 5)
        };
            foreach (var figure in figures)
            {
                figure.Print();
            }
            Console.ReadKey();
        }
    }
}