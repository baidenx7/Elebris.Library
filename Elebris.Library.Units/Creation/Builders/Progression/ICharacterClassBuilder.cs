using Elebris.Rpg.Library.Units.UnitClasses.Containers;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public interface ICharacterClassBuilder
    {
        Dictionary<string, CharacterClassModel> Retrieve();
    }
}