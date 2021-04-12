using Elebris.Core.Library.Components;
using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Items.Equipment;

namespace Elebris.Core.Library.Items
{
    public class EquippedArmor : EquippedGear
    {
        //statdata needs to be passed in to this, but dont use a scriptableobject directly
        public DamageTypeContainer SpellValue = new DamageTypeContainer(ActionDamageType.Spell);
        public DamageTypeContainer PhysicalValue = new DamageTypeContainer(ActionDamageType.Physical);
        public DamageTypeContainer RangedValue = new DamageTypeContainer(ActionDamageType.Ranged);

        public EquippedArmor(DamageTypeContainer spellValue, DamageTypeContainer physicalValue, DamageTypeContainer rangedValue)
        {
            SpellValue = spellValue;
            PhysicalValue = physicalValue;
            RangedValue = rangedValue;
        }
        //if value <= 0 hide it

        public override void OnEquip(Unit container)
        {
            //container.StoredStats.UpsertFlatValue(SpellValue.type.ToString() + "Armor", SpellValue.Value.TotalValue);
            //container.CharacterDefensiveResources.UpsertFlatValue(PhysicalValue.type.ToString() + "Armor", PhysicalValue.Value.TotalValue);
            //container.CharacterDefensiveResources.UpsertFlatValue(RangedValue.type.ToString() + "Armor", RangedValue.Value.TotalValue);
        }

        public override void OnUnEquip(Unit container)
        {
            //container.CharacterDefensiveResources.RemoveAllModsFromSource(this);
        }

    }
}
