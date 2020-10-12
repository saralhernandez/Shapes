namespace Shapes
{
    public class Quadrilateral : IShape
    {
        private double width;
        private double length;

        public Quadrilateral(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public string Name { 
            get => this.width == this.length ? "Square" : "Rectangle";
        }

        public double Perimeter { 
            get => (this.width + this.length) * 2;
        }

        public double SurfaceArea { 
            get => this.width * this.length;
        }
    }
}
