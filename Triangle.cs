namespace Shapes
{
    public class Triangle : IShape
    {
        private double heigth;
        private double triangleBase;
        private double rightSide;
        private double leftSide;

        public Triangle(double heigth, double trianguleBase, double rightSide, double leftSide)
        {
            this.heigth = heigth;
            this.triangleBase = trianguleBase;
            this.rightSide = rightSide;
            this.leftSide = leftSide;
        }

        public string Name { 
            get => this.validateTriangleType();
        }

        public double Perimeter {
            get => this.leftSide + this.rightSide + this.triangleBase;
        }

        public double SurfaceArea {
            get => (this.heigth * triangleBase) / 2;
        }

        private string validateTriangleType()
        {
            if (this.rightSide == this.leftSide && this.leftSide == this.triangleBase)
            {
                return "Equilateral Triangle";
            }

            if (this.rightSide == leftSide || this.rightSide == this.triangleBase || this.leftSide == this.triangleBase)
            {
                return "Isosceles Triangle";
            }
            else
            {
                return "Scalene Triangle";
            }
        }
    }
}
