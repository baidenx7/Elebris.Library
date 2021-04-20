using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.Unit.Core.Containers;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Rpg.Library.Units.Progression.Creation
{
    public class ProgressionBuilder : IProgressionBuilder
    {
        private Dictionary<ProgressionValues, ProgressionValue> _progressionDictionary = new Dictionary<ProgressionValues, ProgressionValue>();


        public Dictionary<ProgressionValues, ProgressionValue> Retrieve()
        {
            Dictionary<ProgressionValues, ProgressionValue> dict = new Dictionary<ProgressionValues, ProgressionValue>();
            PopulateProgressionDict();
            dict = _progressionDictionary.ToDictionary(entry => entry.Key,
                entry => entry.Value);
            return dict;
        }

        private void PopulateProgressionDict()
        {
            if (_progressionDictionary.Count > 0) return;
            _progressionDictionary.Add(ProgressionValues.CharacterExperience, new ProgressionValue());
            _progressionDictionary.Add(ProgressionValues.SanityLevel, new ProgressionValue());

        }
    }
}
