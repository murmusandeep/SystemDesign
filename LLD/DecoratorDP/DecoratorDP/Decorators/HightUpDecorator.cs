using DecoratorDP.Interfaces;

namespace DecoratorDP.Decorators
{
    public class HightUpDecorator : CharacterDecorator
    {
        public HightUpDecorator(ICharacter character) : base(character)
        {
        }

        public override string GetAbilities()
        {
            return _character.GetAbilities() + " With Hight Up";
        }
    }
}
