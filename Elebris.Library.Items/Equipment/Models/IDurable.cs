using Elebris.Rpg.Library.Units.Resources.Models;

namespace Elebris.Rpg.Library.Units.Equipment.Models
{
    public interface IDurable
    {
        ResourceBarValue CharacterGearDurability { get; set; }

        bool IsBroken { get; }
    }
}
