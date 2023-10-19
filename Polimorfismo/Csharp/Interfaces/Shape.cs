using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IShape
    {
        double Area();
    }

    class Circle(double radius) : IShape
    {
        public double Radius { get; set; } = radius;

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    abstract class Shape
    {
        public abstract double Area();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
