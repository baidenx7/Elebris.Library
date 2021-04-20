using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Enforcing;
using Elebris.Rpg.Library.Units.Values.Models;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Creation.Units.Modules
{
    public interface ICharacterStatFactory
    {
        Dictionary<string, StatValue> Retrieve();
    }
}