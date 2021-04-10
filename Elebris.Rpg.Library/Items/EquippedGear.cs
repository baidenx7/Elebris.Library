using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Components;
using Elebris.Core.Library.Enums.Tags;
using Elebris.Core.Library.Items.Equipment;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Items.Equipment;

namespace Elebris.Core.Library.Items
{
    public class EquippedGear : IDurable, IEquippable
    {
       
        //requiredStats (as a struct)
        //bool canEquip (Checks stats and classes?)
        protected ResourceBarValue characterGearDurability;

        public int Grade { get; set; }

        //Each piece of gear has a weight class 1-5. Every 4 points in str subtracts 1 point from a gears weight penalty.
        //    20 points to remove penalties at all weights.Each point of penalty is a 1% movement and cast speed bonus
        protected ResourceBarValue weightValue;
        public ResourceBarValue CharacterGearDurability
        {
            get => characterGearDurability;
            set
            {
                characterGearDurability = value;
                if (CharacterGearDurability.CurrentValue <= 0)
                {
                    ////break gear
                    // startcoroutine to reform gear
                }

            }
        }

        public bool GearBroken
        {
            get
            {
                return CharacterGearDurability.CurrentValue <= 0;
            }
        }

        public virtual bool CanEquip => throw new System.NotImplementedException();

        public bool IsBroken => characterGearDurability.CurrentValue < 0;

        public void DamageGear(float damage, float gradeDiff)
        {
            if (gradeDiff < -5)
            {
                CharacterGearDurability.CurrentValue -= damage;
            }
            else if (gradeDiff > 5)
            {
                CharacterGearDurability.CurrentValue -= damage / 10;
            }
            else
            {
                CharacterGearDurability.CurrentValue -= damage / 3;
            }
        }

        public virtual void OnEquip(Character character)
        {
            
        }

        public virtual void OnUnEquip(Character character)
        {
           
        }
    }
}
