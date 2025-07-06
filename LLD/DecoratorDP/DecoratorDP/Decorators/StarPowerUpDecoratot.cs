using DecoratorDP.Interfaces;

namespace DecoratorDP.Decorators
{
    public class StarPowerUpDecoratot : CharacterDecorator
    {
        public StarPowerUpDecoratot(ICharacter character) : base(character)
        {
        }

        public override string GetAbilities()
        {
            return _character.GetAbilities() + " Star Power Up";
        }
    }
}
