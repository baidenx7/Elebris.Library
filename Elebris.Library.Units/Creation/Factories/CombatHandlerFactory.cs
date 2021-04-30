using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Elebris.Rpg.Library.Units.Combat.Handlers;

namespace Elebris.Library.Units.Creation
{
    internal class CombatHandlerFactory : ICombatHandlerFactory
    {
        private readonly IWeaknessBuilder _weaknessBuilder;

        public CombatHandlerFactory(IWeaknessBuilder weaknessBuilder)
        {
            _weaknessBuilder = weaknessBuilder;
        }
        public CombatHandler ReturnHandler(Character character)
        {
            CombatHandler handler = new(character, _weaknessBuilder.Retrieve());
            return handler;
        }
    }



}
