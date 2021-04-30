using Elebris.Library.Items.Equipment;
using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Equipment.Handlers;

namespace Elebris.Rpg.Library.Units.Equipment
{
    public class EquipmentBuilder : IEquipmentBuilder
    {
        public EquipmentHandler ReturnHandler(Character character)
        {
            EquipmentHandler handler = new EquipmentHandler(character);
            Populate(handler);
            return handler;
        }
        private void Populate(EquipmentHandler handler)
        {

        }
    }



}
