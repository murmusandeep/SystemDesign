using ISP.WithISP.Interfaces;

namespace ISP.WithISP
{
    public class Square : ITwoDimensionShape
    {
        private readonly double _side;

        public Square(double side)
        {
            _side = side;
        }
        public double Area()
        {
            return _side * _side;
        }
    }
}
