using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassDemo.Classes.ShapeDemo;

// Abstract class can only be inherited, they cannot be instanciated
public abstract class Polygon
{
    // start by typing prop and double tap the tab key to create a new property
    public double Width { get; set; }

    // Abstract methods can be customised in the derived class
    public abstract double Area(); // Allocates a method called Area but has no code implemented

    public virtual string GetShapeName()
    {
        throw new NotImplementedException();
    }
}
