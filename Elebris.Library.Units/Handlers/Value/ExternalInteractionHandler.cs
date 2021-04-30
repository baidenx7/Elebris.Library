using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Elebris.Rpg.Library.Units.Core.Handlers;
using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Resources.Handlers
{
    /// <summary>
    /// Used primarily for values that have a max, minimum and need to be tracked

    /// </summary>
    /// 

    public class ExternalInteractionHandler : CharacterHandler, IExternalInteractionHandler
    {

        private Dictionary<string, ResourceBarValue> StoredResourceBars { get; set; }
        public ExternalInteractionHandler(Character character, Dictionary<string, ResourceBarValue> resourceSet) : base(character)
        {

            StoredResourceBars = resourceSet;
        }


        public void ModifyResourceValue(string resources, float value)
        {
            StoredResourceBars[resources].CurrentValue += value;
        }

        public ResourceBarValue RetrieveResourceData(string value)
        {
            return StoredResourceBars[value];
        }


        //Queue for external objects requesting single points of data

        //dictionary for external objects listening for certain events
    }
}
