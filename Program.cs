namespace Shapes
{
    using System.Collections.Generic;

    class Program
    {
        static ShapePrinter shapePrinter = new ShapePrinter();
        

        static void Main(string[] args)
        {
            IShapeFactory shapeFactory = new ShapesFactory();
            List<IShape> shapes = shapeFactory.CreateShapes();
            IShapeRepository shapeRepository = new ShapeRepository(shapes);
            IShapeSorter shapeSorter = new ShapeSorter(shapes);
            IShapeStrategy shapePrinter = new ShapePrinter();
            ShapeHandler shapeHandler = new ShapeHandler(shapeRepository, shapeSorter, shapePrinter);
            shapeHandler.SortShapes();
            shapeHandler.SaveOnDisk();
            shapeHandler.GetShapesInMemory();
        }
    }
}
