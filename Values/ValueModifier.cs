namespace Elebris.Library.Values
{
    public class ValueModifier
    {
        public readonly float Value;
        public readonly ValueModEnum Type;
        public readonly int Order;
        public readonly object Source;
        public float Duration;
        public bool HasDuration;

        public ValueModifier(float value, ValueModEnum type, int order, object source, float duration, bool hasDuration = false)
        {
            Value = value;
            Type = type;
            Order = order;
            Source = source; // Assign Source to our new input parameter
            Duration = duration;
            HasDuration = hasDuration;
        }
        // Requires Value and Type. Calls the "Main" constructor and sets Order and Source to their default values: (int)type and null, respectively.
        public ValueModifier(float value, ValueModEnum type) : this(value, type, (int)type, null, 1) { }

        // Requires Value, Type and Order. Sets Source to its default value: null
        public ValueModifier(float value, ValueModEnum type, int order) : this(value, type, order, null, 1) { }

        // Requires Value, Type and Source. Sets Order to its default value: (int)Type
        public ValueModifier(float value, ValueModEnum type, object source) : this(value, type, (int)type, source, 1) { }
        // Requires Value, Type and Order, Duration. Sets Source to its default value: null
        public ValueModifier(float value, ValueModEnum type, int order, int duration) : this(value, type, order, null, duration) { }

        // Requires Value, Type and Source, Duration. Sets Order to its default value: (int)Type
        public ValueModifier(float value, ValueModEnum type, object source, int duration) : this(value, type, (int)type, source, duration) { }
    }

}