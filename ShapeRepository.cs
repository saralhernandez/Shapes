namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.Json;

    class ShapeRepository : IShapeRepository
    {
        private List<IShape> shapes = new List<IShape>();

        public ShapeRepository(List<IShape> shapes)
        {
            this.shapes = shapes;
        }

        public IEnumerable<IGrouping<Type, IShape>> GetShapesInMemory()
        {
            return this.shapes.GroupBy(shape => shape.GetType());
        }

        public void SaveOnDisk()
        {
            File.WriteAllText(@"C:\Shapes.json", JsonSerializer.Serialize(this.shapes));
        }
    }
}
