namespace Shapes
{
    using System.Collections.Generic;

    public class ShapesFactory : IShapeFactory
    {
        public List<IShape> CreateShapes() 
        {
            List<IShape> shapes = new List<IShape>();

            Triangle equilateral = new Triangle(2, 5, 5, 5);
            Triangle scalene = new Triangle(2, 4, 6, 8);
            Triangle isosceles = new Triangle(2, 10, 5, 5);
            Quadrilateral square = new Quadrilateral(3, 3);
            Quadrilateral rectangle = new Quadrilateral(4, 2);
            Circle circle = new Circle(2);
            shapes.Add(equilateral);
            shapes.Add(scalene);
            shapes.Add(isosceles);
            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(circle);

            return shapes;
        }
    }
}
