using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Triangle : Figure
    {
        private double A, B, C;
        public Triangle(string name, double a, double b, double c) : base(name)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public override double Area()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
        public override double Perimeter() => A + B + C;
        public override void Print() => Console.WriteLine($"{Name}: Стороны {A}, {B}, {C}, Площадь: {Area()}, Периметр: {Perimeter()}");
    }
}