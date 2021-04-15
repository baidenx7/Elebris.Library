using Elebris.Core.Library.CharacterValues.Mutable;

namespace Elebris.Core.Library.Items.Equipment
{
    public interface IDurable
    {
        ResourceBarValue CharacterGearDurability { get; set; }

        bool IsBroken { get; }
    }
}
