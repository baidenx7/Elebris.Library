using Elebris.Actions.Library.Actions.Component;
using Elebris.Actions.Library.Actions.Core;
using Elebris.Core.Library.Components;
using Elebris.Core.Library.Enums;
using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.Actions.ActionValues;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Core.Library.Items
{
    public class EquippedWeapon : EquippedGear
    {
        public EquippedWeapon(DamageType type, ActionSubtype subtype, Elements element, float actionCritChance, 
            float actionCritMultipler, float weaponRange, float weaponDamage, float weaponSpeed, WeaponCategory category)
        {
            Type = type;
            Subtype = subtype;
            Element = element;
            ActionCritChance = actionCritChance;
            ActionCritMultipler = actionCritMultipler;
            WeaponRange = weaponRange;
            WeaponDamage = weaponDamage;
            WeaponSpeed = weaponSpeed;
            Category = category;
        }

        public DamageType Type { get; set; }
        public ActionSubtype Subtype { get; set; }
        public Elements Element { get; set; }

        public float ActionCritChance { get; set; } //constructed by character using the action
        public float ActionCritMultipler { get; set; } //constructed by character using the action
        public float WeaponRange { get; set; }
        public float WeaponDamage { get; set; }
        public float WeaponSpeed { get; set; }
        public WeaponCategory Category {get;set;}

        public enum WeaponCategory {Sword, Axe, Bow, Dagger, Staff, Fist  } //Later populate this via scriptableobject or database instead


        public override void OnEquip(Unit character)
        {

        }

        public override void OnUnEquip(Unit character)
        {

        }
    }
}
