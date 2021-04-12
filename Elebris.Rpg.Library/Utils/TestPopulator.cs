using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Enums;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.StatGeneration
{
    public static class TestPopulator
    {
        public static void PopulateUnit(ref Unit container)
        {
            FillAttributes(ref container);


            FillResources(ref container);
        }

        private static void FillAttributes(ref Unit container)
        {
            container.ValueHandler.StoredAttributes = new Dictionary<Attributes, StatValue>();
            foreach (var item in Enum.GetNames(typeof(Attributes)))
            {
                container.ValueHandler.StoredAttributes.Add((Attributes)Enum.Parse(typeof(Attributes), item),new StatValue(6));
            }
        }

        private static void FillResources(ref Unit container, float val = 10)
        {

            container.ResourceHandler.StoredResourceBars = new Dictionary<Resource, ResourceBarValue>();

            foreach (var item in Enum.GetNames(typeof(Resource)))
            {
                container.ResourceHandler.StoredResourceBars.Add((Resource)Enum.Parse(typeof(Resource),item), new ResourceBarValue(val));
            }
        }
    }

}
