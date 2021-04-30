using Elebris.Rpg.Library.Units.Data.Containers;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public interface IProfessionBuilder
    {
        Dictionary<string, CharacterProfessionModel> Retrieve();
    }
}