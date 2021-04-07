using Elebris.Rpg.Library.Enums;
using Elebris.UnitCreation.Library.StatGeneration;

namespace Elebris.Rpg.Library.CharacterSystems.Core.UnitTriggers
{
    public struct TriggerResourceEventModel
    {
        public TriggerResourceEventModel(TriggerEventState eventState, TriggerEventType eventType, ResourceStats resource)
        {
            EventState = eventState;
            EventType = eventType;
            Resource = resource;
        }

        public TriggerEventState EventState { get; set; }
        public TriggerEventType EventType { get; set; }
        public ResourceStats Resource { get; set; }
    }

}
