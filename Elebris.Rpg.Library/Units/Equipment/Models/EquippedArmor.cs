using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.Unit.Core.Containers;

namespace Elebris.Rpg.Library.Units.Equipment.Models
{
    public class EquippedArmor : EquippedGear
    {
      

        public override void OnEquip(Character character)
        {
            //container.StoredStats.UpsertFlatValue(SpellValue.type.ToString() + "Armor", SpellValue.Value.TotalValue);
            //container.CharacterDefensiveResources.UpsertFlatValue(PhysicalValue.type.ToString() + "Armor", PhysicalValue.Value.TotalValue);
            //container.CharacterDefensiveResources.UpsertFlatValue(RangedValue.type.ToString() + "Armor", RangedValue.Value.TotalValue);
        }

        public override void OnUnEquip(Character character)
        {
            //container.CharacterDefensiveResources.RemoveAllModsFromSource(this);
        }

    }
}
