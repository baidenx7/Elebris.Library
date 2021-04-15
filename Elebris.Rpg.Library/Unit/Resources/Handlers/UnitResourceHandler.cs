using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System.Collections.Generic;

namespace Elebris.Core.Library.CharacterValues.Mutable
{
    /// <summary>
    /// Used primarily for values that have a max, minimum and need to be tracked

    /// </summary>
    /// 

    public class UnitResourceHandler: CharacterHandler
    {
        /// 4/6/21 whatif I create a resource handler isntead of having each resource track itself, and just pass damage through the handler, 
        /// managing event calls there rather than in the resourcebalue itself
        private Dictionary<Resource, ResourceBarValue> StoredResourceBars { get; set; }
        public UnitResourceHandler(Unit container) : base(container)
        {
            
            StoredResourceBars = new Dictionary<Resource, ResourceBarValue>();
        }


        public void ModifyResourceValue(Resource resources, float value)
        {
            StoredResourceBars[resources].CurrentValue += value;
        }



        public ResourceBarValue RetrieveResourceData(Resource value)
        {
            return StoredResourceBars[value];
        }
    }
}
