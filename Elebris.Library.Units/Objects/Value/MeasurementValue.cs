
using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Rpg.Library.Units.Resources.Models
{
    public class MeasurementValue
    {
        private float currentValue;
        private float maxValue;
        private readonly string _observedValue;

        public MeasurementValue(string observedValue, float missingValue = 0)
        {
            //observedValue; use this to hook up an event
            MaxValue = 1;
            CurrentValue = MaxValue - missingValue;
            _observedValue = observedValue;
        }

        public void WireUp(IValueHandler handler)
        {
            MaxValue= handler.RetrieveValue(_observedValue).TotalValue;
            //Add Event Listener
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
