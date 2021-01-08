using Elebris.Core.Library.CharacterValues;
using Elebris.Core.Library.Components;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;

namespace Elebris.Actions.Library.Actions.Core
{
    
    public struct ActionScaleModel
    {
        public readonly string name;
        public readonly string scaleStat;
        public readonly float flat;
        public readonly float scale; 

        public ActionScaleModel(string name, string scalingStat = null, float flat = 0, float scale = 0)
        {
            this.name = name;
            scaleStat = scalingStat;
            this.flat = flat;
            this.scale = scale;
        }
        public ActionScaleModel(Attributes name, string scalingStat = null, float flat = 0, float scale = 0)
        {
            this.name = name.ToString();
            scaleStat = scalingStat;
            this.flat = flat;
            this.scale = scale;
        }
        public ActionScaleModel(Stats name, string scalingStat = null, float flat = 0, float scale = 0)
        {
            this.name = name.ToString();
            scaleStat = scalingStat;
            this.flat = flat;
            this.scale = scale;
        }

        public float ReturnValue(CharacterValueContainer container)
        {
            if(scaleStat != null)
            {
                return flat + (scale * (float)container.DataHandler.RetrieveValue(scaleStat));
            }
            return 0;
        }
        public float ReturnValue(CharacterValueContainer container, float value)
        {
            return flat + (scale * value);
          
        }
    }
}
