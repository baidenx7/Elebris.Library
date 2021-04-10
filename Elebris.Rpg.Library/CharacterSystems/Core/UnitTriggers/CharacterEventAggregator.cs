using Elebris.Rpg.Library.CharacterSystems.Core.UnitTriggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.CharacterSystems.Core.UnitEvents
{
    public class CharacterEventAggregator
    {
        public HashSet<TriggerEventPublisher> TriggerVoidEventSet = new HashSet<TriggerEventPublisher>();
        public HashSet<TriggerResourceEventPublisher> TriggerResourceEventSet = new HashSet<TriggerResourceEventPublisher>();

        public void SubscribeToEvent(TriggerEventModel model, TriggerEventSubscriber subscriber)
        {
            bool wasFound = false;
            foreach (var item in TriggerVoidEventSet)
            {
                if (model.EventState == item._model.EventState && model.EventType == item._model.EventType)
                {
                    item.Subscribe(subscriber);
                    wasFound = true;
                    break;
                }

            }
            if (wasFound == false)
            {
                TriggerVoidEventSet.Add(new TriggerEventPublisher(model));

                SubscribeToEvent(model, subscriber);//Run once more to add subscriber to the newly created publisher
            }
        }
        internal void TriggerEvent(TriggerEventModel model)
        {
            foreach (var item in TriggerVoidEventSet)
            {
                if (model.EventState == item._model.EventState && model.EventType == item._model.EventType)
                {
                    item.NotifyOfChange();
                    break;
                }
                //otherwise it doesnt exist/nothing has subscribed to it
            }
        }



        public void SubscribeToEvent(TriggerResourceEventModel model, TriggerEventSubscriber subscriber)
        {
            bool wasFound = false;
            foreach (var item in TriggerVoidEventSet)
            {
                if (model.EventState == item._model.EventState && model.EventType == item._model.EventType)
                {
                    item.Subscribe(subscriber);
                    wasFound = true;
                    break;
                }

            }
            if (wasFound == false)
            {
                TriggerResourceEventSet.Add(new TriggerResourceEventPublisher(model));

                SubscribeToEvent(model, subscriber);//Run once more to add subsccriber to the newly created publisher
            }
        }
       
        internal void TriggerEvent(TriggerResourceEventModel model)
        {
            foreach (var item in TriggerResourceEventSet)
            {
                if (model.EventState == item._model.EventState && model.EventType == item._model.EventType && model.Resource == item._model.Resource)
                {
                    item.NotifyOfChange();
                    break;
                }
                //otherwise it doesnt exist/nothing has subscribed to it
            }
        }
    }
}
