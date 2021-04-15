using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    public interface ICombatBuilder
    {
        UnitCombatHandler ReturnHandler(Unit unit);
    }
}