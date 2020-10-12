namespace Shapes
{
    public interface IShape
    {
        public string Name { get; }

        public double Perimeter { get; }

        public double SurfaceArea { get; }
    }
}
