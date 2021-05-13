using Elebris.Library.Units.Containers;
using System;

namespace Elebris.Library.Units.Creation
{

    public class CharacterFactory : ICharacterFactory
    {
        private readonly IValueHandlerFactory _valueFactory;
        private readonly IPresentationHandlerFactory _externalFactory;
        private readonly IProgressionHandlerFactory _progressionFactory;

        public CharacterFactory(IValueHandlerFactory valuehandlerfactory, IPresentationHandlerFactory externalHandlerFactory,
            IProgressionHandlerFactory progressionfactory)
        {
            _valueFactory = valuehandlerfactory;
            _externalFactory = externalHandlerFactory;
            _progressionFactory = progressionfactory;
        }
        public Character CreateCharacter()
        {
            Character character = new(_valueFactory, _externalFactory, _progressionFactory);
            return character;

        }
        public Character CreateUnit(Guid guid)
        {
            Character character = new(_valueFactory, _externalFactory, _progressionFactory);
            //load rather than create
            return character;
        }



    }

}
