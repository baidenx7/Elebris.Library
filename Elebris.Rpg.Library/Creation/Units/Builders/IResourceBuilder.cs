using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    public interface IResourceBuilder
    { 
        UnitResourceHandler ReturnHandler(Unit unit); 
    }

}