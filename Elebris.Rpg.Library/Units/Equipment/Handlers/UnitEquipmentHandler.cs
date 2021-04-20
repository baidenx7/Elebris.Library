using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Core.Handlers;
using Elebris.Rpg.Library.Units.Equipment.Enforcing;
using Elebris.Rpg.Library.Units.Equipment.Models;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Equipment.Handlers
{
    public class UnitEquipmentHandler : CharacterHandler
    {

        //switch to list later? should work fine for now
        private Dictionary<EquipSlot, IEquippable> EquippedGear = new Dictionary<EquipSlot, IEquippable>();

        public UnitEquipmentHandler(Character character) : base(character)
        {
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
