﻿using ConsoleApp.ClassDemo.Interfaces;

namespace ConsoleApp.ClassDemo.Classes.ShapeDemo
{
    public class Sphere : ICircularShape, I3DShape
    {
        public Sphere(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        public double Circumference()
        {
            return 4 * Math.PI * Math.Pow(Radius, 3);
        }

        public double Volume()
        {
            return 4 / 3 * Math.PI * Radius;
        }
    }
}
