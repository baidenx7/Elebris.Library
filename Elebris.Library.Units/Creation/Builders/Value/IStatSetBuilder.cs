using Elebris.Rpg.Library.Units.Core.Models;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public interface IStatSetBuilder
    {
        Dictionary<string, CharacterStatValue> GenerateStatSet();
    }
}
