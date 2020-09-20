namespace Elebris.Library.Units
{
    public class CharacterGear
    {
        //switch to list later? should work fine for now
        private EquippedGear equippedWeapon;
        public EquippedGear equippedOffhand;

        public EquippedGear equippedHeadArmor;
        public EquippedGear equippedBodyArmor;
        public EquippedGear equippedHandArmor;

        public EquippedGear EquippedWeapon 
        { 
            get => equippedWeapon;

            set
            {
                //check that it can go in this slot
                equippedWeapon = value;
            }
        }
        public EquippedGear EquippedOffhand
        {
            get => equippedOffhand;

            set
            {

                //check that it can go in this slot
                equippedOffhand = value;
            }
        }
        public EquippedGear EquippeHeadArmor
        {
            get => equippedHeadArmor;

            set
            {

                //check that it can go in this slot
                equippedHeadArmor = value;
            }
        }
        public EquippedGear EquippedBodyArmor
        {
            get => equippedBodyArmor;

            set
            {

                //check that it can go in this slot
                equippedBodyArmor = value;
            }
        }
        public EquippedGear EquippedHandArmor
        {
            get => equippedHandArmor;

            set
            {

                //check that it can go in this slot
                equippedHandArmor = value;
            }
        }


        //equipment inventory, regular inventory, stash?
    }
}
