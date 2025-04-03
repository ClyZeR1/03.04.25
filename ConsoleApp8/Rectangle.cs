using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Rectangle : Figure
    {
        private double Width, Height;
        public Rectangle(string name, double width, double height) : base(name)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double Area() => Width * Height;
        public override double Perimeter() => 2 * (Width + Height);
        public override void Print() => Console.WriteLine($"{Name}: {Width} x {Height}, Площадь: {Area()}, Периметр: {Perimeter()}");
    }
}