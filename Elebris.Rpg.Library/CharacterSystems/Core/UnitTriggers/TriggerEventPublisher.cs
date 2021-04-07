using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.CharacterSystems.Core.UnitTriggers
{
    public class TriggerEventPublisher
    {
        public TriggerEventModel _model { get; }
        public event Action OnTriggered;
        public TriggerEventPublisher(TriggerEventModel model)
        {
            _model = model;
        }

        public void NotifyOfChange()
        {
            OnTriggered?.Invoke();
        }

        public void Subscribe(TriggerEventSubscriber subscriber)
        {
            OnTriggered += subscriber.TriggerNotification;
        }
        public void Unsubscribe(TriggerEventSubscriber subscriber)
        {

            OnTriggered -= subscriber.TriggerNotification;
        }
    }

}
