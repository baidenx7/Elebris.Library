using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Rpg.Library.Factories
{
    public static class ResourceGenerator
    {

        private static Dictionary<Resource, ResourceBarValue>  _storedResourceBars = new Dictionary<Resource, ResourceBarValue>();

        public static void PopulateFactoryResources(Character container)
        {
            GenerateResourceBars();
            container.ResourceHandler.StoredResourceBars = _storedResourceBars.ToDictionary(entry => entry.Key,
                entry => entry.Value);
        }
        private static void GenerateResourceBars()
        {
            if (_storedResourceBars.Count > 0) return;
            PopulateResource( Resource.Health);
            PopulateResource( Resource.Mana);
            PopulateResource( Resource.Spirit);
            PopulateResource( Resource.Stamina);
            PopulateResource( Resource.Barrier);
        }

        private static void PopulateResource(Resource resource)
        {
            _storedResourceBars[resource] = new ResourceBarValue(1);
        }

    }
}