namespace ISP
{
    public class Program
    {
        static void Main(string[] args)
        {
            WithoutISP.Square withoutISPSquare = new WithoutISP.Square(4);
            WithoutISP.Cube withoutISPCube = new WithoutISP.Cube(4);
            Console.WriteLine(withoutISPSquare.Area());
            Console.WriteLine(withoutISPSquare.Volume());
            Console.WriteLine(withoutISPCube.Area());
            Console.WriteLine(withoutISPCube.Volume());

            WithISP.Square withISPSquare = new WithISP.Square(4);
            WithISP.Cube withISPCube = new WithISP.Cube(4);
            Console.WriteLine(withISPSquare.Area());
            Console.WriteLine(withISPCube.Area());
            Console.WriteLine(withISPCube.Volume());
        }
    }
}
