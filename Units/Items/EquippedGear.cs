namespace Elebris.Library.Units
{
    public class EquippedGear : IDurable
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

    }
}
