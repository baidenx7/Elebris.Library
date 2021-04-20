using Elebris.Rpg.Library.Units.Data.Containers;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Data.Creation
{
    public interface IProfessionBuilder
    {
        Dictionary<string, CharacterProfessionHolder> Retrieve();
    }
}