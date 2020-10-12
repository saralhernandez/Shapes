namespace Shapes
{
    using System.Collections.Generic;

    public interface IShapeFactory
    {
        public List<IShape> CreateShapes();
    }
}
