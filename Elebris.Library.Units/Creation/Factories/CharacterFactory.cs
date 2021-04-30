using Elebris.Library.Units.Containers;
using System;

namespace Elebris.Library.Units.Creation
{

    public class CharacterFactory : ICharacterFactory
    {
        private readonly IValueHandlerFactory _valueFactory;
        private readonly IExternalInteractionHandlerFactory _resourceFactory;
        private readonly IProgressionHandlerFactory _progressionFactory;

        public CharacterFactory(IValueHandlerFactory valuehandlerfactory, IExternalInteractionHandlerFactory resourcehandlerfactory,
            IProgressionHandlerFactory progressionfactory)
        {
            _valueFactory = valuehandlerfactory;
            _resourceFactory = resourcehandlerfactory;
            _progressionFactory = progressionfactory;
        }
        public Character CreateCharacter()
        {
            Character character = new(_valueFactory, _resourceFactory, _progressionFactory);
            return character;

        }
        public Character CreateUnit(Guid guid)
        {
            Character character = new(_valueFactory, _resourceFactory, _progressionFactory);
            //load rather than create
            return character;
        }



    }

}
