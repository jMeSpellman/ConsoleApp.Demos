namespace ConsoleApp.ClassDemo.Classes.ShapeDemo
{
    public class Square : Polygon
    {
        // Constructor
        public Square(double width)
        {
            Width = width;
        }
        public override double Area() // Override the Area function from the Polygon class
        {
            return Width * Width;
        }
    }
}
