using DecoratorDP.Interfaces;

namespace DecoratorDP.Decorators
{
    public abstract class CharacterDecorator : ICharacter
    {
        protected readonly ICharacter _character;
        public CharacterDecorator(ICharacter character)
        {
            _character = character;
        }

        public abstract string GetAbilities();
    }
}
