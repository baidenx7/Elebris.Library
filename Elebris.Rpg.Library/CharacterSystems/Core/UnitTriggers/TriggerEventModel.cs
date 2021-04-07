﻿using Elebris.Rpg.Library.Enums;

namespace Elebris.Rpg.Library.CharacterSystems.Core.UnitTriggers
{
    public struct TriggerEventModel
    {
        public TriggerEventModel(TriggerEventState eventState, TriggerEventType eventType)
        {
            EventState = eventState;
            EventType = eventType;
        }

        public TriggerEventState EventState { get; set; }
        public TriggerEventType EventType { get; set; }
        //Trigger enum for target? (Self, Enemy, Ally)
    }

}
