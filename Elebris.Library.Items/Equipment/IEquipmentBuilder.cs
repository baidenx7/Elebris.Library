using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Equipment.Handlers;

namespace Elebris.Library.Items.Equipment
{
    public interface IEquipmentBuilder
    {
        EquipmentHandler ReturnHandler(Character character);
    }
}