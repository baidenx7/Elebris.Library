using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Equipment.Handlers;

namespace Elebris.Rpg.Library.Units.Equipment
{
    public interface IEquipmentBuilder
    {
        UnitEquipmentHandler ReturnHandler(Character character);
    }
}