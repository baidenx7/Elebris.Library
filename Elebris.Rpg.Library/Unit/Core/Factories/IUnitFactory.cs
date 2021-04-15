using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Factories;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    public interface IUnitFactory
    {
        UnitFactory ReturnUnit(Unit unit); 
    }

}