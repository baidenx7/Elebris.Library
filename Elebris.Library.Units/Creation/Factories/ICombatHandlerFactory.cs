using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Combat.Handlers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Library.Units.Creation
{
    internal interface ICombatHandlerFactory
    {
        CombatHandler ReturnHandler(ValueHandler valuehandler);
    }
}