using Elebris.Rpg.Library.Units.Values.Models;

namespace Elebris.Rpg.Library.Units.Resources.Models
{
    public class ResourceBarValue
    {
        private float currentValue = 10;
        private StatValue maxValue = new StatValue(10);
        private float missingValue = 0;

        private StatValue _regenerationValue;
        private StatValue _reserveAmount;

        public ResourceBarValue(float maxValue, float missingValue = 0)
        {
            MaxValue = new StatValue(maxValue);
            this.missingValue = missingValue;
        }


        public float CurrentValue
        {
            get => currentValue;
            set
            {
                if (currentValue >= MaxValue.TotalValue)
                {
                    currentValue = MaxValue.TotalValue;
                }
                else if (currentValue <= 0)
                {
                    currentValue = 0;
                }

                currentValue = value;
            }
        }
        public StatValue MaxValue
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

        public float CurrentValuePercent => currentValue / maxValue.TotalValue;

        public float MissingValuePercent => (maxValue.TotalValue - currentValue) / maxValue.TotalValue;
        public float MissingValue => maxValue.TotalValue - currentValue;

        public StatValue RegenerationValue { get => _regenerationValue; set => _regenerationValue = value; }
        public StatValue ReserveAmount { get => _reserveAmount; set => _reserveAmount = value; }
    }
}
