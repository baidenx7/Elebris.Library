using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Values.Enforcing;

namespace Elebris.Rpg.Library.Units.Actions.Models
{

    public struct ActionScaleModel
    {
        public readonly Stats name;
        public readonly Stats scaleStat;
        public readonly float flat;
        public readonly float scale;

        public ActionScaleModel(Stats name, Stats scalingStat = Stats.MoveSpeed, float flat = 0, float scale = 0)
        {
            this.name = name;
            scaleStat = scalingStat; //ugly
            this.flat = flat;
            this.scale = scale;
        }

        public float ReturnValue(Character character)
        {
            if (scaleStat != null)
            {
                return flat + scale * (float)character.ValueHandler.RetrieveValue(scaleStat);
            }
            return 0;
        }
        public float ReturnValue(Character character, float value)
        {
            return flat + scale * value;

        }
    }
}
