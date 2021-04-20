using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Core.Handlers;
using Elebris.Rpg.Library.Units.Resources.Creation;
using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Resources.Handlers
{
    /// <summary>
    /// Used primarily for values that have a max, minimum and need to be tracked

    /// </summary>
    /// 

    public class CharacterResourceHandler : CharacterHandler, ICharacterResourceHandler
    {

        private Dictionary<Resource, ResourceBarValue> StoredResourceBars { get; set; }
        public CharacterResourceHandler(Character character, Creation.IResourceBuilder resourcefactory) : base(character)
        {

            StoredResourceBars = resourcefactory.Retrieve();
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
