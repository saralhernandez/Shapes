namespace Shapes
{
    using System;

    public class Circle : IShape
    {
        private const double Pi = 3.14;
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public string Name { 
            get => "Circle";
        }

        public double Perimeter { 
            get => 2 * Pi * this.radius;
        }

        public double SurfaceArea {
            get => Pi * Math.Pow(this.radius, 2);
        }
    }
}
