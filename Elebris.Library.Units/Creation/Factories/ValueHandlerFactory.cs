using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Library.Units.Creation
{
    public class ValueHandlerFactory : IValueHandlerFactory
    {
        readonly IAttributeFactory _attributeFactory;
        readonly ICharacterStatFactory _statFactory;
        public ValueHandlerFactory(IAttributeFactory defaultAttributeFactory, ICharacterStatFactory defaultStatFactory)
        {
            _attributeFactory = defaultAttributeFactory;
            _statFactory = defaultStatFactory;
        }

        public ICharacterValueHandler ReturnHandler(Character character)
        {
            CharacterValueHandler handler = new(character, _attributeFactory.Retrieve(), _statFactory.Retrieve());

            return handler;
        }

    }



}
