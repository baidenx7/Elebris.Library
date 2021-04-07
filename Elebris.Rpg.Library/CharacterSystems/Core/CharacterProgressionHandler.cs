using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using Elebris.Core.Library.CharacterValues.Mutable;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.CharacterSystems.Core
{

    public class CharacterProgressionHandler : CharacterHandler
    {
        public Dictionary<ProgressionValues, ProgressionValue> StoredProgressionValues { get; set; }
        public CharacterProgressionHandler(CharacterValueContainer container) : base(container)
        {

        }
    }
}
