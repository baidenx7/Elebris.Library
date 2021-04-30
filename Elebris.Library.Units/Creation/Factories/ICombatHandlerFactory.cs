using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Combat.Handlers;

namespace Elebris.Library.Units.Creation
{
    internal interface ICombatHandlerFactory
    {
        CombatHandler ReturnHandler(Character character);
    }
}