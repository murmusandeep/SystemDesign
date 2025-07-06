namespace FacadeDP.Subsystems
{
    public class BIOS
    {
        public void Boot(CPU cpu, Memory memory)
        {
            Console.WriteLine("BIOS: Booting CPU and Memory checks...");
            cpu.Initialize();
            memory.SelfTest();
        }
    }
}
