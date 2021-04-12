using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterSystems.Core;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    public class ProgressionBuilder : IProgressionBuilder
    {
        public UnitProgressionHandler ReturnHandler(Unit unit)
        {
            UnitProgressionHandler handler = new UnitProgressionHandler(unit);
            Populate(handler);
            return handler;
        }
        private void Populate(UnitProgressionHandler handler)
        {

        }

        private Dictionary<ProgressionValues, ProgressionValue> _progressionDictionary = new Dictionary<ProgressionValues, ProgressionValue>();

        public void PopulateProgressionValues(Unit container)
        {
            PopulateProgressionDict();
            container.ProgressionHandler.StoredProgressionValues = _progressionDictionary.ToDictionary(entry => entry.Key,
                entry => entry.Value);
        }

        private void PopulateProgressionDict()
        {
            if (_progressionDictionary.Count > 0) return;
            _progressionDictionary.Add(ProgressionValues.CharacterExperience, new ProgressionValue());
            _progressionDictionary.Add(ProgressionValues.SanityLevel, new ProgressionValue());

        }
    }



}
