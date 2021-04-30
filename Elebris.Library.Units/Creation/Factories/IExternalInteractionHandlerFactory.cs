using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Resources.Handlers;

namespace Elebris.Library.Units.Creation
{
    public interface IExternalInteractionHandlerFactory
    {
        ExternalInteractionHandler ReturnHandler(Character character);
    }
}