﻿using Elebris.Core.Library.Enums;
using Elebris.Core.Library.Objects;
using Elebris.Rpg.Library.CharacterSystems.Core.Models;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.CharacterValues
{
    public class UnitCombatHandler : CharacterHandler
    {
        public UnitCombatHandler(Unit container) : base(container)
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
                if (item.damageType == model.damageType && item.interactionType == model.interactionType)
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
                if (item.damageType == model.damageType && item.interactionType == model.interactionType)
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
                if (item.damageType == model.damageType && item.interactionType == model.interactionType)
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
                if (item.damageType == model.damageType && item.interactionType == model.interactionType)
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
                if (item.damageType == model.damageType && item.interactionType == model.interactionType)
                {
                    return item.DamageValue.TotalValue;
                }
            }
            return 0;
        }
    }
}
