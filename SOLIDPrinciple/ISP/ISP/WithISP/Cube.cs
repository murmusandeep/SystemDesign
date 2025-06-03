using ISP.WithISP.Interfaces;

namespace ISP.WithISP
{
    public class Cube : IThreeDimensionShape
    {
        private readonly double _side;

        public Cube(double side)
        {
            _side = side;
        }
        public double Area()
        {
            return 6 * _side * _side;
        }

        public double Volume()
        {
            return _side * _side * _side;
        }
    }
}
