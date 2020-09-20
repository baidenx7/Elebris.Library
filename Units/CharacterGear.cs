

namespace Elebris.Library.Units
{

    public class CharacterGear
    {
        public EquippedGear equippedWeapon;
        public EquippedGear equippedOffhand;

        public EquippedGear equippedHeadArmor;
        public EquippedGear equippedBodyArmor;
        public EquippedGear equippedHandArmor;


        //equipment inventory, regular inventory, stash?
    }

    public class EquippedGear
    {
        //statdata needs to be passed in to this, but dont use a scriptableobject directly
        private ValueHolder characterGearDurability;
        public ValueHolder CharacterGearDurability
        {
            get => characterGearDurability;
            set
            {
                characterGearDurability = value;
                if (CharacterGearDurability.currentValue <= 0)
                {
                    ////break gear
                    // startcoroutine to reform gear
                }

            }
        }

        public class EquippedWeapon : EquippedGear
        {
            //repalce these with scriptableobject references to data
            public float weaponDamage;
            public float attackSpeed; //.5 for very slow, 1.5 would be considered VERY FAST. dont forget flat base will be modified so 1.5 is 3 time as easy to cap as .5
            public int handSlots;//replace with data for 1h, 2h, offhand
            //damage type
            //secondary type
        }

        public class EquippedArmor : EquippedGear
        {
            //armor values
            //weight class?
            //repalce these with scriptableobject references to data
        }

    }
}