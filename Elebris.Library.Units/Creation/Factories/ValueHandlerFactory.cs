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

        public IValueHandler ReturnHandler()
        {
            ValueHandler handler = new(_statFactory.Retrieve());

            return handler;
        }

    }



}
