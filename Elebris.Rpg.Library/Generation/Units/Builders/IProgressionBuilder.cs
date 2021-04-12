using Elebris.Rpg.Library.CharacterSystems.Core;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    public interface IProgressionBuilder
    { 
        UnitProgressionHandler ReturnHandler(Unit unit); 
    }

}