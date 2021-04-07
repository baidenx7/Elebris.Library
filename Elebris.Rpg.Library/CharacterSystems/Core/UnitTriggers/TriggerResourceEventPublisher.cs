using Elebris.UnitCreation.Library.StatGeneration;
using System;

namespace Elebris.Rpg.Library.CharacterSystems.Core.UnitTriggers
{
    public class TriggerResourceEventPublisher
    {
       
            public TriggerResourceEventModel _model { get; }

            public event Action OnTriggered;
            public TriggerResourceEventPublisher(TriggerResourceEventModel model)
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

}
