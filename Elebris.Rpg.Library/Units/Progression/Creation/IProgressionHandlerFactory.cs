using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Progression.Handlers;

namespace Elebris.Rpg.Library.Units.Progression
{
    public interface IProgressionHandlerFactory
    {
        CharacterProgressionHandler ReturnHandler(Character character);
    }

}