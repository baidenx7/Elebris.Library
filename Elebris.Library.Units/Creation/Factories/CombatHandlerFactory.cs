using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Elebris.Rpg.Library.Units.Combat.Handlers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Library.Units.Creation
{
    internal class CombatHandlerFactory : ICombatHandlerFactory
    {
        private readonly IWeaknessBuilder _weaknessBuilder;

        public CombatHandlerFactory(IWeaknessBuilder weaknessBuilder)
        {
            _weaknessBuilder = weaknessBuilder;
        }
        public CombatHandler ReturnHandler(ValueHandler valuehandler)
        {
            CombatHandler handler = new(valuehandler, _weaknessBuilder.Retrieve());
            return handler;
        }
    }



}
