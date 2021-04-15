using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using Elebris.Core.Library.CharacterValues.Mutable;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.CharacterSystems.Core
{

    public class UnitProgressionHandler : CharacterHandler
    {
        private Dictionary<ProgressionValues, ProgressionValue> StoredProgressionValues { get; set; }
        public UnitProgressionHandler(Unit container) : base(container)
        {
            StoredProgressionValues = new Dictionary<ProgressionValues, ProgressionValue>();
        }
    }
}
