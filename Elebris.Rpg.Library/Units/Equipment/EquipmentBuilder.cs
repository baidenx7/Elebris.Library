using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Equipment.Handlers;

namespace Elebris.Rpg.Library.Units.Equipment
{
    public class EquipmentBuilder : IEquipmentBuilder
    {
        public UnitEquipmentHandler ReturnHandler(Character character)
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
