namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IShapeRepository
    {
        public void SaveOnDisk();

        public IEnumerable<IGrouping<Type, IShape>> GetShapesInMemory();
    }
}
