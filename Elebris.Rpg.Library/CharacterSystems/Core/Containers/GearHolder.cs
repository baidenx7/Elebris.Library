using Elebris.Core.Library.Enums.Tags;
using Elebris.Core.Library.Items;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Core.Library.Components
{
    public class GearHolder
    {
        public EquippedGear gear;

        public CharacterValueContainer container;

        public GearHolder(CharacterValueContainer container)
        {
            this.container = container;
        }
    }
}
