using Elebris.Core.Library.Components;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    public interface IEquipmentBuilder
    {
        UnitEquipmentHandler ReturnHandler(Unit unit);
    }
}