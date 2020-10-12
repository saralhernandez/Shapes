namespace Shapes
{
    using System.Collections.Generic;

    public interface IShapeSorter
    {

        public List<IShape> SortByPerimeter();
        public List<IShape> SortByArea();
    }
}
