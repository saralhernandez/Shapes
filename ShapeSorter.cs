namespace Shapes
{
    using System.Collections.Generic;
    using System.Linq;

    public class ShapeSorter : IShapeSorter
    {
        private List<IShape> shapes = new List<IShape>();

        public ShapeSorter(List<IShape> shapes)
        {
            this.shapes = shapes;
        }

        public List<IShape> SortByArea()
        {
            return this.shapes.OrderBy(shape => shape.SurfaceArea).ToList();
        }

        public List<IShape> SortByPerimeter()
        {
            return this.shapes.OrderBy(shape => shape.Perimeter).ToList();
        }
    }
}
