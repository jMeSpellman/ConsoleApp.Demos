using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassDemo.Classes.ShapeDemo
{
    public class Triangle : Polygon
    {
        // Constructor
        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Height { get; set; }

        public override double Area() // Override the Area function from the Polygon class
        {
            return Width / 2 * Height;
        }
    }
}
