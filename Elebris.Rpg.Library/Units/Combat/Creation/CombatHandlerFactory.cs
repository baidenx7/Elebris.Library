using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Combat.Creation;
using Elebris.Rpg.Library.Units.Combat.Handlers;

namespace Elebris.Rpg.Library.Units.Combat
{
    public class CombatHandlerFactory : ICombatHandlerFactory
    {
        private readonly IDamageModelBuilder _damageModelFactory;
        private readonly IWeaknessBuilder _weaknessFactory;

        public CombatHandlerFactory(IDamageModelBuilder damageModelFactory, IWeaknessBuilder weaknessFactory)
        {
            _damageModelFactory = damageModelFactory;
            _weaknessFactory = weaknessFactory;
        }
        public CombatHandler ReturnHandler(Character character)
        {
            CombatHandler handler = new CombatHandler(character);
            return handler;
        }
    }



}
