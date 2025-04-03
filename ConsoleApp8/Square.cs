using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Square : Figure
    {
        private double Side;
        public Square(string name, double side) : base(name) { this.Side = side; }
        public override double Area() => Side * Side;
        public override double Perimeter() => 4 * Side;
        public override void Print() => Console.WriteLine($"{Name}: Сторона {Side}, Площадь: {Area()}, Периметр: {Perimeter()}");
    }
}