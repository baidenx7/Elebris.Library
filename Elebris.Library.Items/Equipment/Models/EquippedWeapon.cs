using Elebris.Core.Library.Enums;
using Elebris.Library.Units.Enforcing.Combat;
using Elebris.Rpg.Library.Actions.ActionValues;
using Elebris.Rpg.Library.Unit.Core.Containers;

namespace Elebris.Rpg.Library.Units.Equipment.Models
{
    public class EquippedWeapon : EquippedGear
    {
        public EquippedWeapon(DamageType type, ActionSubtype subtype, Elements element, float actionCritChance,
            float actionCritMultipler, float weaponRange, float weaponDamage, float weaponSpeed, WeaponTypeCategory category, WeaponEquipCategory equipcategory)
        {
            Type = type;
            Subtype = subtype;
            Element = element;
            ActionCritChance = actionCritChance;
            ActionCritMultipler = actionCritMultipler;
            WeaponRange = weaponRange;
            WeaponDamage = weaponDamage;
            WeaponSpeed = weaponSpeed;
            TypeCategory = category;
            EquipCategory = equipcategory;
        }

        public DamageType Type { get; set; }
        public ActionSubtype Subtype { get; set; }
        public WeaponTypeCategory TypeCategory { get; set; }
        public WeaponEquipCategory EquipCategory { get; set; }
        public Elements Element { get; set; }

        public float WeaponSpeed { get; set; }
        public float ActionCritChance { get; set; } //constructed by character using the action
        public float ActionCritMultipler { get; set; } //constructed by character using the action
        public float WeaponRange { get; set; }
        public float WeaponDamage { get; set; }

        public override void OnEquip(Character character)
        {

        }

        public override void OnUnEquip(Character character)
        {

        }
    }
}
