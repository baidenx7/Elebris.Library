using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Elebris.Rpg.Library.Units.Resources.Handlers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Library.Units.Creation
{
    public class PresentationHandlerFactory : IPresentationHandlerFactory
    {
        private readonly IResourceSetBuilder _resourceBuilder;

        public PresentationHandlerFactory(IResourceSetBuilder resourceBuilder)
        {
            _resourceBuilder = resourceBuilder;
        }
        public InteractionHandler ReturnHandler(IValueHandler valuehandler)
        {
            InteractionHandler handler = new(valuehandler, _resourceBuilder.Retrieve());
            return handler;
        }



    }



}
