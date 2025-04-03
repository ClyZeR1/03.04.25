using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Circle : Figure
    {
        private double Radius;
        public Circle(string name, double radius) : base(name) { this.Radius = radius; }
        public override double Area() => Math.PI * Radius * Radius;
        public override double Perimeter() => 2 * Math.PI * Radius;
        public override void Print() => Console.WriteLine($"{Name}: Радиус {Radius}, Площадь: {Area()}, Периметр: {Perimeter()}");
    }
}