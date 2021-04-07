using Elebris.Rpg.Library.CharacterSystems.Core.UnitTriggers;
using Elebris.Rpg.Library.Enums;
using System;

namespace Elebris.Core.Library.CharacterValues.Mutable
{
    public class ResourceBarValue 
    {
        private float currentValue = 10;
        private float maxValue = 10;
        private float missingValue = 0;

        public ResourceBarValue(float maxValue, float missingValue = 0) 
        {
            MaxValue = maxValue;
            this.missingValue = missingValue;
        }
      
       
        public float CurrentValue
        {
            get => currentValue;
            set
            {
                if (currentValue >= MaxValue)
                {
                    currentValue = MaxValue;
                }
                else if (currentValue <= 0)
                {
                    currentValue = 0;
                }
               
                currentValue = value;
            }
        }
        public float MaxValue
        {
            get
            {
                return maxValue;
            }

            set
            {
                maxValue = value;
            }
        }

        public void AlterMax(float maxVal)
        {
            float missing = MissingValue;
            float MaxValue = maxVal;
            currentValue = MaxValue - missing;
        }

        public float CurrentValuePercent => currentValue / maxValue;

        public float MissingValuePercent => (maxValue - currentValue) / maxValue;
        public float MissingValue => maxValue - currentValue;

    }
}
