namespace Shapes
{
    public interface IShapeStrategy
    {
        public IShape Shape { set; }

        public void PrintCharacteristics();

    }
}
