using Elebris.Rpg.Library.Units.UnitClasses.Containers;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.UnitClasses.Creation
{
    public interface ICharacterClassBuilder
    {
        Dictionary<string, CharacterClassHolder> Retrieve();
    }
}