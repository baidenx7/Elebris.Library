using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    public class ResourceBuilder : IResourceBuilder
        {
        public UnitResourceHandler ReturnHandler(Unit unit)
        {
            UnitResourceHandler handler = new UnitResourceHandler(unit);
            Populate(handler);
            return handler;
        }
        private void Populate(UnitResourceHandler handler)
        {

        }


        private Dictionary<Resource, ResourceBarValue> _storedResourceBars = new Dictionary<Resource, ResourceBarValue>();

        public void PopulateFactoryResources(Unit container)
        {
            GenerateResourceBars();
            //container.ResourceHandler.StoredResourceBars = _storedResourceBars.ToDictionary(entry => entry.Key,
                //entry => entry.Value);
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
