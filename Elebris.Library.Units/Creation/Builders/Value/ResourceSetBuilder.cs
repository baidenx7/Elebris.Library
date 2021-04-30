using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Library.Units.Creation
{
    public class ResourceSetBuilder : IResourceSetBuilder
    {
        private readonly Dictionary<string, ResourceBarValue> _storedResourceBars;
        public ResourceSetBuilder(Dictionary<string, ResourceBarValue> storedResourceBars)
        {
            _storedResourceBars = storedResourceBars;
            GenerateResourceBars();
        }
        public Dictionary<string, ResourceBarValue> Retrieve()
        {

            Dictionary<string, ResourceBarValue> dict = new();

            dict = _storedResourceBars.ToDictionary(entry => entry.Key,
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
            _storedResourceBars[resource.ToString()] = new ResourceBarValue(1);
        }
    }
}
