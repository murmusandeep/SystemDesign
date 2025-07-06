using DecoratorDP.Interfaces;

namespace DecoratorDP.Decorators
{
    public class GunPowerUpDecorator : CharacterDecorator
    {
        public GunPowerUpDecorator(ICharacter character) : base(character)
        {
        }

        public override string GetAbilities()
        {
            return _character.GetAbilities() + " With Gun Power Up";
        }
    }
}
