using Elebris.Rpg.Library.CharacterSystems.UnitGeneration;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Rpg.Library.Creation.Units.Builders
{
    public class CombatBuilder : ICombatBuilder
    {
        public UnitCombatHandler ReturnHandler(Unit unit)
        {
            UnitCombatHandler handler = new UnitCombatHandler(unit);
            Populate(handler);
            return handler;
        }
        private void Populate(UnitCombatHandler handler)
        {

        }
    }



}
