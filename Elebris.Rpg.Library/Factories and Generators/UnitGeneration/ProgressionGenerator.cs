using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Rpg.Library.Factories
{
    public static class ProgressionGenerator
    {
        private static Dictionary<ProgressionValues, ProgressionValue> _progressionDictionary = new Dictionary<ProgressionValues, ProgressionValue>();

        public static void PopulateProgressionValues(Character container)
        {
            PopulateProgressionDict();
            container.ProgressionHandler.StoredProgressionValues = _progressionDictionary.ToDictionary(entry => entry.Key,
                entry => entry.Value);
        }

        private static void PopulateProgressionDict()
        {
            if (_progressionDictionary.Count > 0) return;
            _progressionDictionary.Add(ProgressionValues.CharacterExperience, new ProgressionValue());
            _progressionDictionary.Add(ProgressionValues.SanityLevel, new ProgressionValue());

        }
    }
}