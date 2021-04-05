using Elebris.Rpg.Library.Enums;

namespace Elebris.Rpg.Library.CharacterSystems.Core.UnitTriggers
{
    public struct TriggerEventModel
    {
        public TriggerEventState EventState { get; set; }
        public TriggerEventState EventType { get; set; }
        //Trigger enum for target? (Self, Enemy, Ally)
    }

}
