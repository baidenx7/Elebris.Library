using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.StatGeneration
{
    public static class TestPopulator
    {
        public static void PopulateUnit(ref CharacterValueContainer container)
        {
            FillAttributes(ref container);


            FillResources(ref container);
        }

        private static void FillAttributes(ref CharacterValueContainer container)
        {
            container.StoredAttributes = new Dictionary<Attributes, StatValue>();
            foreach (var item in Enum.GetNames(typeof(Attributes)))
            {
                container.StoredAttributes.Add((Attributes)Enum.Parse(typeof(Attributes), item),new StatValue(6));
            }
        }

        private static void FillResources(ref CharacterValueContainer container, float val = 10)
        {

            container.StoredResourceBars = new Dictionary<ResourceStats, ResourceBarValue>();

            foreach (var item in Enum.GetNames(typeof(ResourceStats)))
            {
                container.StoredResourceBars.Add((ResourceStats)Enum.Parse(typeof(ResourceStats),item), new ResourceBarValue(val));
            }
        }
    }

}
