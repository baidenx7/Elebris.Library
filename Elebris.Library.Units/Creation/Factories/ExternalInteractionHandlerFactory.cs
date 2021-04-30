using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Elebris.Rpg.Library.Units.Resources.Handlers;

namespace Elebris.Library.Units.Creation
{
    public class ExternalInteractionHandlerFactory : IExternalInteractionHandlerFactory
    {
        private readonly IResourceSetBuilder _resourceBuilder;

        public ExternalInteractionHandlerFactory(IResourceSetBuilder resourceBuilder)
        {
            _resourceBuilder = resourceBuilder;
        }
        public ExternalInteractionHandler ReturnHandler(Character character)
        {
            ExternalInteractionHandler handler = new(character, _resourceBuilder.Retrieve());
            return handler;
        }



    }



}
