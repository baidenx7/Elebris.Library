using System;

namespace Elebris.Core.Library.CharacterValues.Mutable
{
    /// <summary>
    /// Used primarily for values that have a max, minimum and need to be tracked
    /// </summary>
    public class ResourceBarValue
    {
        private float currentValue = 10;
        private float maxValue = 10;
        private float missingValue = 0;
        public string type; // not type-safe at the moment, get from the dictionary on a unit


        //Other characters should not have access to these four actions.
        //these are for the controlling characters own triggers (ex. When healed do x or heal by an additional x, when damaged gain movespeed)
        public event Action<float> valueModifed;
        public event Action<float> valueEmpty;
        public event Action<float> valueFull;
        public float CurrentValue
        {
            get => currentValue;
            set
            {
                if (currentValue >= MaxValue)
                {
                    currentValue = MaxValue;
                    //trigger valueFull event?
                }
                if (currentValue <= 0)
                {
                    //trigger valueEmpty event?
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

        public ResourceBarValue(float maxValue, float missingValue = 0)
        {
            MaxValue = maxValue;
            this.missingValue = missingValue;
        }

        public float CurrentValuePercent => currentValue / maxValue;

        public float MissingValuePercent => (maxValue - currentValue) / maxValue;
        public float MissingValue => maxValue - currentValue;

    }
}
