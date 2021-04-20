using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Combat.Handlers;

namespace Elebris.Rpg.Library.Units.Combat
{
    public interface ICombatHandlerFactory
    {
        CombatHandler ReturnHandler(Character character);
    }
}