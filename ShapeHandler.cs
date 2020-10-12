namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShapeHandler
    {
        private List<IShape> shapes = new List<IShape>();
        private IShapeRepository shapeRepository;
        private IShapeSorter shapeSorter;
        private IShapeStrategy shapePrinter;

        public ShapeHandler(IShapeRepository shapeRepository, IShapeSorter shapeSorter, IShapeStrategy shapePrinter)
        {
            this.shapeRepository = shapeRepository;
            this.shapeSorter = shapeSorter;
            this.shapePrinter = shapePrinter;
        }

        public void SortShapes()
        {
            Console.WriteLine("+++++++++++ Sorted by Area +++++++++++");
            this.shapes = this.shapeSorter.SortByArea();
            this.Print();

            Console.WriteLine("+++++++++++ Sorted by Perimeter +++++++++++");
            this.shapes = this.shapeSorter.SortByPerimeter();
            this.Print();

        }

        public void SaveOnDisk()
        {
            Console.WriteLine("+++++++++++ Saving on Disk +++++++++++");
            this.shapeRepository.SaveOnDisk();
            Console.WriteLine("Saved shapes in Shapes.json file");
        }

        public void GetShapesInMemory()
        {
            Console.WriteLine("+++++++++++ Counting Shapes in Memory +++++++++++");
            var groupedShapes = this.shapeRepository.GetShapesInMemory();

            foreach (var groupedShape in groupedShapes) {
                Console.WriteLine("Quantity of " + groupedShape.Key + " is : " + groupedShape.Count());
            }
        }

        private void Print()
        {
            foreach (IShape shape in shapes)
            {
                shapePrinter.Shape = shape;
                shapePrinter.PrintCharacteristics();
            }
        }
    }
}
