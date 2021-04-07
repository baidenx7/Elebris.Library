using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System.Collections.Generic;

namespace Elebris.Core.Library.CharacterValues.Mutable
{
    /// <summary>
    /// Used primarily for values that have a max, minimum and need to be tracked

    /// </summary>
    /// 

    public class CharacterResourceHandler: CharacterHandler
    {
        /// 4/6/21 whatif I create a resource handler isntead of having each resource track itself, and just pass damage through the handler, 
        /// managing event calls there rather than in the resourcebalue itself
        internal Dictionary<ResourceStats, ResourceBarValue> StoredResourceBars { get; set; }
        public CharacterResourceHandler(CharacterValueContainer container) : base(container)
        {
            
            StoredResourceBars = new Dictionary<ResourceStats, ResourceBarValue>();
        }


        public void ModifyResourceValue(ResourceStats resources, float value)
        {
            StoredResourceBars[resources].CurrentValue += value;
        }



        public ResourceBarValue RetrieveResourceData(ResourceStats value)
        {
            return StoredResourceBars[value];
        }
    }
}
