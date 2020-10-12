using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class ShapePrinter : IShapeStrategy
    {
        private const string messageFormat = "{0} : {1}";
        private IShape shape;

        public IShape Shape { 
            set => this.shape = value; 
        }

        public void PrintCharacteristics()
        {
            if (shape == null) throw new Exception("Please, provide a valid Shape");
            Console.WriteLine("========" + shape.Name + "========");
            Console.WriteLine(String.Format(messageFormat, "Area", shape.SurfaceArea));
            Console.WriteLine(String.Format(messageFormat, "Perimeter", shape.Perimeter));
        }

    }
}
