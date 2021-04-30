using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Elebris.Library.Units.Objects.Progression;
using Elebris.Rpg.Library.Units.Data.Handlers;

namespace Elebris.Library.Units.Creation
{
    internal class ProgressionHandlerFactory : IProgressionHandlerFactory
    {
        private readonly IProfessionBuilder _professionBuilder;

        private readonly ICharacterClassBuilder _classbuilder;

        private readonly ProgressionValue _characterExperience;
        public ProgressionHandlerFactory(IProfessionBuilder professionBuilder,
        ICharacterClassBuilder classbuilder)
        {
            _professionBuilder = professionBuilder;
            _classbuilder = classbuilder;
        }

        public IProgressionHandler ReturnHandler(Character character)
        {
            ProgressionHandler handler = new(character, _classbuilder.Retrieve(), _professionBuilder.Retrieve());

            return handler;
        }

    }



}
