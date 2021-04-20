using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Rpg.Library.Units.Resources.Creation
{
    class ResourceBuilder : IResourceBuilder
    {
        private Dictionary<Resource, ResourceBarValue> _storedResourceBars;
        public ResourceBuilder(Dictionary<Resource, ResourceBarValue> storedResourceBars)
        {
            _storedResourceBars = storedResourceBars;
        }
        public Dictionary<Resource, ResourceBarValue> Retrieve()
        {

            Dictionary<Resource, ResourceBarValue> dict = new Dictionary<Resource, ResourceBarValue>();
            GenerateResourceBars();
            dict = _storedResourceBars.ToDictionary(entry => entry.Key,
            entry => entry.Value);
            return dict;

        }
        private void GenerateResourceBars()
        {
            if (_storedResourceBars.Count > 0) return;
            PopulateResource(Resource.Health);
            PopulateResource(Resource.Mana);
            PopulateResource(Resource.Spirit);
            PopulateResource(Resource.Stamina);
            PopulateResource(Resource.Barrier);
        }

        private void PopulateResource(Resource resource)
        {
            _storedResourceBars[resource] = new ResourceBarValue(1);
        }
    }
}
