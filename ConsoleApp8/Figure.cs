using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class Figure
    {
        public string Name { get; }
        public Figure(string name) { Name = name; }
        public abstract double Area();
        public abstract double Perimeter();
        public virtual void Print() => Console.WriteLine($"Фигура: {Name}");
    }
}