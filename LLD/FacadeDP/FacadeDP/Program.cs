using FacadeDP.Facade;

namespace FacadeDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComputerFacade computer = new ComputerFacade();
            computer.StartComputer();
        }
    }
}
