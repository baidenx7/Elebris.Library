using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Library.Units.Creation
{
    public class ResourceSetBuilder : IResourceSetBuilder
    {
        private readonly Dictionary<string, MeasurementValue> _storedMeasurementValues;
        public ResourceSetBuilder(Dictionary<string, MeasurementValue> storedMeasurementValues)
        {
            _storedMeasurementValues = storedMeasurementValues;
            GenerateResourceBars();
        }
        public Dictionary<string, MeasurementValue> Retrieve()
        {

            Dictionary<string, MeasurementValue> dict = new();

            dict = _storedMeasurementValues.ToDictionary(entry => entry.Key,
            entry => entry.Value);
            return dict;

        }
        private void GenerateResourceBars()
        {
            PopulateResource(Resource.Health);
            PopulateResource(Resource.Mana);
            PopulateResource(Resource.Spirit);
            PopulateResource(Resource.Stamina);
            PopulateResource(Resource.Barrier);
            PopulateResource(Resource.Charge);
        }

        private void PopulateResource(Resource resource)
        {
            _storedMeasurementValues[resource.ToString()] = new MeasurementValue(resource.ToString());
        }
    }
}
