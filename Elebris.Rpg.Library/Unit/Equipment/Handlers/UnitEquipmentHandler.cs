using Elebris.Core.Library.Enums.Tags;
using Elebris.Core.Library.Items;
using Elebris.Core.Library.Items.Equipment;
using Elebris.Rpg.Library.CharacterValues;
using System;
using System.Collections.Generic;

namespace Elebris.Core.Library.Components
{
    public class UnitEquipmentHandler : CharacterHandler
    {

        //switch to list later? should work fine for now
        private Dictionary<EquipSlot, IEquippable> EquippedGear = new Dictionary<EquipSlot, IEquippable>();

        public UnitEquipmentHandler(Unit container) : base(container)
        {
            _unit = container;
            //EquippedGear.Add(EquipSlot.WieldedLeft, new GearHolder(characterContainer));
            //EquippedGear.Add(EquipSlot.WieldedRight, new GearHolder(characterContainer));
            //EquippedGear.Add(EquipSlot.Head, new GearHolder(characterContainer));
            //EquippedGear.Add(EquipSlot.Legs, new GearHolder(characterContainer));
            //EquippedGear.Add(EquipSlot.Body, new GearHolder(characterContainer));
            //EquippedGear.Add(EquipSlot.Gloves, new GearHolder(characterContainer));
        }

        //weapons?
      

        //stored equipment inventory(FFIV), regular inventory, stash?
    }

    
}
