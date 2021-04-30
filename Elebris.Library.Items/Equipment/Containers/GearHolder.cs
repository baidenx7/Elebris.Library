using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Equipment.Models;

namespace Elebris.Rpg.Library.Units.Equipment.Containers
{
    public class GearHolder
    {
        public EquippedGear gear;

        public Character character;

        public GearHolder(Character character)
        {
            this.character = character;
        }
    }
}
