using Elebris.Core.Library.Components;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Core.Library.Items.Equipment
{
    public interface IEquippable
    {
        bool CanEquip { get; }

        void OnEquip(Unit character);//pass in all values to the character
        void OnUnEquip(Unit character); // remove any values that were added
        int Grade
        {
            get;
        }

    }
}