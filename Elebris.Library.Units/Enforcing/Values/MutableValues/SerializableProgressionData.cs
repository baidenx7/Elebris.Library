﻿namespace Elebris.Rpg.Library.Units.Values.Enforcing.MutableValues
{
    public struct SerializableProgressionData
    {
        public float storedValue;
        public float currentValue;

        public SerializableProgressionData(float storedValue, float currentValue)
        {
            this.storedValue = storedValue;
            this.currentValue = currentValue;
        }
    }

}
