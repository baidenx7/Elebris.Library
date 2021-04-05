using Elebris.Rpg.Library.CharacterSystems.Core.UnitTriggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.CharacterSystems.Core.UnitEvents
{
    public class UnitTriggerHandler
    {
        public HashSet<TriggerEventPublisher> TriggerEventSet = new HashSet<TriggerEventPublisher>();

        internal void TriggerEvent(TriggerEventModel model)
        {
            bool wasFound = false;
            foreach (var item in TriggerEventSet)
            {
                if(model.EventState == item._model.EventState && model.EventType == item._model.EventType)
                {
                    item.NotifyOfChange();
                    wasFound = true;
                    break;
                }
               
            }
            if(wasFound == false)
            {
                TriggerEventSet.Add(new TriggerEventPublisher(model));
                TriggerEvent(model);//Run once more to trigger the newly created publisher
            }
        }
    }
}
