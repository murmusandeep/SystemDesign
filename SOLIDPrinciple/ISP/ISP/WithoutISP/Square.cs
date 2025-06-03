using ISP.WithoutISP.Interfaces;

namespace ISP.WithoutISP
{
    public class Square : IShape
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

        public double Volume()
        {
            throw new NotSupportedException("Square does not support volume calculation.");
        }
    }
}
