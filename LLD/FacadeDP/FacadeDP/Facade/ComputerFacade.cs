using FacadeDP.Subsystems;
using OperatingSystem = FacadeDP.Subsystems.OperatingSystem;

namespace FacadeDP.Facade
{
    public class ComputerFacade
    {
        private PowerSupply powerSupply = new PowerSupply();
        private CoolingSystem coolingSystem = new CoolingSystem();
        private CPU cpu = new CPU();
        private Memory memory = new Memory();
        private HardDrive hardDrive = new HardDrive();
        private BIOS bios = new BIOS();
        private OperatingSystem os = new OperatingSystem();

        public void StartComputer()
        {
            Console.WriteLine("----- Starting Computer -----");
            powerSupply.ProvidePower();
            coolingSystem.StartFans();
            bios.Boot(cpu, memory);
            hardDrive.SpinUp();
            os.Load();
            Console.WriteLine("Computer Booted Successfully!");
        }
    }
}
