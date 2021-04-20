using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Core.Handlers;
using Elebris.Rpg.Library.Units.Progression.Creation;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Progression.Handlers
{

    public class CharacterProgressionHandler : CharacterHandler
    {
        private Dictionary<ProgressionValues, ProgressionValue> StoredProgressionValues { get; set; }
        public CharacterProgressionHandler(Character character, IProgressionBuilder progressionFactory) : base(character)
        {
            StoredProgressionValues = progressionFactory.Retrieve();
        }

    }
}
