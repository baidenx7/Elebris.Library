using Elebris.Rpg.Library.Creation.Units.Modules;
using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Rpg.Library.Units.Values.Creation
{
    public class ValueHandlerFactory : IValueHandlerFactory
    {
        IAttributeFactory _attributeFactory;
        ICharacterStatFactory _statFactory;
        public ValueHandlerFactory(IAttributeFactory defaultAttributeFactory, ICharacterStatFactory defaultStatFactory)
        {
            this._attributeFactory = defaultAttributeFactory;
            this._statFactory = defaultStatFactory;
        }
       
        public ICharacterValueHandler ReturnHandler(Character character)
        {
            CharacterValueHandler handler = new CharacterValueHandler(character, _attributeFactory, _statFactory );
            
            return handler;
        }

    }



}
