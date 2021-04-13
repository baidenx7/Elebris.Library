using Elebris.Core.Library.Components;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    public class EquipmentBuilder : IEquipmentBuilder
    {
        public UnitEquipmentHandler ReturnHandler(Unit unit)
        {
            UnitEquipmentHandler handler = new UnitEquipmentHandler(unit);
            Populate(handler);
            return handler;
        }
        private void Populate(UnitEquipmentHandler handler)
        {

        }
    }



}
