using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Elebris.Rpg.Library.Units.Core.Handlers;
using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;
using Elebris.Rpg.Library.Units.Values.Handlers;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Resources.Handlers
{
    /// <summary>
    /// Used primarily for values that have a max, minimum and need to be tracked

    /// </summary>
    /// 

    public class InteractionHandler : ValueHandlerInteractor, IInteractionHandler
    {

        private Dictionary<string, MeasurementValue> StoredMeasurementValues { get; set; }
        public InteractionHandler(IValueHandler valuehandler, Dictionary<string, MeasurementValue> resourceSet) : base(valuehandler)
        {

            StoredMeasurementValues = resourceSet;
        }


        public void ModifyMeasurementValue(string resources, float value)
        {
            StoredMeasurementValues[resources].CurrentValue += value;
        }

        public MeasurementValue RetrieveResourceData(string value)
        {
            return StoredMeasurementValues[value];
        }


        //Queue for external objects requesting single points of data

        //dictionary for external objects listening for certain events
    }
}
