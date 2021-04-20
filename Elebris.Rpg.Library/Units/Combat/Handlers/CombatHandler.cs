using Elebris.Core.Library.Enums;
using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Actions.Models;
using Elebris.Rpg.Library.Units.Combat.Models;
using Elebris.Rpg.Library.Units.Core.Handlers;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Combat.Handlers
{
    public class CombatHandler : CharacterHandler
    {
        public CombatHandler(Character container) : base(container)
        {

            DamageModels = new List<DamageModel>();
        }
        private Dictionary<Elements, WeaknessValue> StoredWeaknesses { get; set; }
        private List<DamageModel> DamageModels { get; set; } //Link these to Stored Stats

        public WeaknessValue RetrieveWeaknessValue(Elements element)
        {
            return StoredWeaknesses[element];
        }

        public float RetrieveCritChance(DamageModel model)
        {

            foreach (var item in DamageModels)
            {
                if (item._damageType == model._damageType && item._interactionType == model._interactionType)
                {
                    return item.CritChance.TotalValue;
                }
            }
            return 0;
        }
        public float RetrieveCritMultiplier(DamageModel model)
        {

            foreach (var item in DamageModels)
            {
                if (item._damageType == model._damageType && item._interactionType == model._interactionType)
                {
                    return item.CritDamage.TotalValue;
                }
            }
            return 1;
        }

        public float RetrieveArmorValue(DamageModel model)
        {
            foreach (var item in DamageModels)
            {
                if (item._damageType == model._damageType && item._interactionType == model._interactionType)
                {
                    return item.ArmorValue.TotalValue;
                }
            }
            return 0;

        }
        public float RetrieveMitigation(DamageModel model)
        {
            foreach (var item in DamageModels)
            {
                if (item._damageType == model._damageType && item._interactionType == model._interactionType)
                {
                    return item.ArmorValue.TotalValue;
                }
            }
            return 0;
        }
        public float RetrieveDamage(DamageModel model)
        {
            foreach (var item in DamageModels)
            {
                if (item._damageType == model._damageType && item._interactionType == model._interactionType)
                {
                    return item.DamageValue.TotalValue;
                }
            }
            return 0;
        }
    }
}
