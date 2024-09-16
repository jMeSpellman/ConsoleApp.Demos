using ConsoleApp.ClassDemo.Interfaces;

namespace ConsoleApp.ClassDemo.Classes.ShapeDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        // Constructor
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public double Length { get; set; }

        public override double Area() // Override the Area function from the Polygon class
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return 2 * Length + 2 * Width;
        }

        public override string GetShapeName()
        {
            return base.GetShapeName();
        }
    }
}
