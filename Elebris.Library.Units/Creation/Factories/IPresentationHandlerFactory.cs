using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Resources.Handlers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Library.Units.Creation
{
    public interface IPresentationHandlerFactory
    {
        InteractionHandler ReturnHandler(IValueHandler valuehandler);
    }
}