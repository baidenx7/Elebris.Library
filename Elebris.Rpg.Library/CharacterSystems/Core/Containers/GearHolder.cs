using Elebris.Core.Library.Enums.Tags;
using Elebris.Core.Library.Items;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Core.Library.Components
{
    public class GearHolder
    {
        public EquippedGear gear;

        public Character container;

        public GearHolder(Character container)
        {
            this.container = container;
        }
    }
}
