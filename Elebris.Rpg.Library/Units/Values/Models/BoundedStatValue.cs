using Elebris.Rpg.Library.Units.Core.Models;

namespace Elebris.Rpg.Library.Units.Values.Models
{
    public class BoundedStatValue : StatValue
    {
        private float _min;
        private float _max;
        public BoundedStatValue(float start, float min = float.MinValue, float max = float.MaxValue): base(start)
        {

        }

        public override float TotalValue
        {
            get
            {
                float val = base.TotalValue;
                if (val > _max) val = _max;
                if (val < _min) val = _min;
                return val;
            }
        }
    }
}
