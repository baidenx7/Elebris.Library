using Elebris.Library.Units.Containers;

namespace Elebris.Rpg.Library.Units.Actions.Models
{

    public struct ActionScaleValue
    {
        public readonly string name;
        public readonly string _scaleStat;
        public readonly float flat;
        public readonly float scale;

        public ActionScaleValue(string name, string scalingStat = null, float flat = 0, float scale = 0)
        {
            this.name = name;
            _scaleStat = scalingStat;
            this.flat = flat;
            this.scale = scale;
        }

        public float ReturnValue(Character character)
        {
            if (_scaleStat != null)
            {
                return flat + scale * character.ValueHandler.RetrieveValue(_scaleStat).TotalValue;
            }
            return flat;
        }
        public float ReturnValue(float value)
        {
            return flat + scale * value;

        }
    }
}
