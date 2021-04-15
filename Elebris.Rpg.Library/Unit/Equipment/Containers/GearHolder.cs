using Elebris.Core.Library.Items;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Core.Library.Components
{
    public class GearHolder
    {
        public EquippedGear gear;

        public Unit container;

        public GearHolder(Unit container)
        {
            this.container = container;
        }
    }
}
