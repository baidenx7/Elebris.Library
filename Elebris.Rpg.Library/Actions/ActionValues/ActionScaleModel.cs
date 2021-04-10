using Elebris.Core.Library.CharacterValues;
using Elebris.Core.Library.Components;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Enums;
using Elebris.UnitCreation.Library.StatGeneration;

namespace Elebris.Actions.Library.Actions.Core
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

        public float ReturnValue(Character container)
        {
            if(scaleStat != null)
            {
                return flat + (scale * (float)container.ValueHandler.RetrieveValue(scaleStat));
            }
            return 0;
        }
        public float ReturnValue(Character container, float value)
        {
            return flat + (scale * value);
          
        }
    }
}
