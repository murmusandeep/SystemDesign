using DecoratorDP.Decorators;
using DecoratorDP.Interfaces;

namespace DecoratorDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICharacter mario = new Mario();
            Console.WriteLine("Basic Character : " + mario.GetAbilities());

            mario = new HightUpDecorator(mario);
            Console.WriteLine("After Hight Up : " + mario.GetAbilities());

            mario = new GunPowerUpDecorator(mario);
            Console.WriteLine("After Gun Power Up : " + mario.GetAbilities());

            mario = new StarPowerUpDecoratot(mario);
            Console.WriteLine("After Star Power Up : " + mario.GetAbilities());
        }
    }
}
