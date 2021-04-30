using Elebris.Rpg.Library.Units.Core.Models;

namespace Elebris.Rpg.Library.Units.Resources.Models
{
    public class ResourceBarValue
    {
        private float currentValue;
        private float maxValue;

        public ResourceBarValue(float maxValue, float missingValue = 0)
        {
            MaxValue = maxValue;
            CurrentValue = MaxValue - missingValue;
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
                float missing = MissingValue;
                maxValue = value;
                currentValue = maxValue - missing;
            }
        }

        public float CurrentValuePercent => currentValue / maxValue;
        public float MissingValuePercent => (maxValue - currentValue) / maxValue;
        public float MissingValue => maxValue - currentValue;

    }
}
