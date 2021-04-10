using Elebris.Core.Library.Enums;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.Actions.ActionValues;
using System;
using Elebris.Rpg.Library.StatGeneration;
using System.Collections.Generic;
using Elebris.Core.Library.Objects;
using Elebris.Rpg.Library.CharacterSystems.Core.Models;
using Elebris.Rpg.Library.Enums;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;

namespace Elebris.Rpg.Library.CharacterSystems.Core
{

    public class CharacterValueHandler : CharacterHandler
    {
        public Dictionary<Attributes, StatValue> StoredAttributes { get; set; }
        public Dictionary<Stats, StatValue> StoredStats { get; set; }
        public List<IManipulationValue> StoredManipulationValues { get; set; }
        public Dictionary<Elements, WeaknessValue> StoredWeaknesses { get; set; }
        public List<DamageModel> DamageModels { get; set; } //Link these to Stored Stats
        public CharacterValueHandler(Character container) : base(container)
        {
            StoredAttributes = new Dictionary<Attributes, StatValue>();
            StoredStats = new Dictionary<Stats, StatValue>();
            StoredManipulationValues = new List<IManipulationValue>();
            DamageModels = new List<DamageModel>();

        }

        public float RetrieveValue(Stats stat)
        {
            StatValue cur = StoredStats[stat];

            return cur.TotalValue;
        }
        public float RetrieveValue(Attributes attribute)
        {
            if (attribute == Attributes.None) return 0;
            StatValue cur = StoredAttributes[attribute];

            return cur.TotalValue;
        }

        public WeaknessValue RetrieveWeaknessValue(Elements element)
        {
            return StoredWeaknesses[element];
        }
        
        public StatValue CopyStat(Stats stat)
        {
            StatValue cur = StoredStats[stat];
            StatValue val = new StatValue(cur.BaseValue);
            foreach (var modifier in cur.ValueModifiers)
            {
                val.AddModifier(modifier);
            }
            return val;
        }

        public float RetrieveCritChance(DamageModel model)
        {

            foreach (var item in DamageModels)
            {
                if (item.damageType == model.damageType && item.statType == model.statType)
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
                if (item.damageType == model.damageType && item.statType == model.statType)
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
                if(item.damageType == model.damageType && item.statType == model.statType)
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
                if (item.damageType == model.damageType && item.statType == model.statType)
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
                if (item.damageType == model.damageType && item.statType == model.statType)
                {
                    return item.DamageValue.TotalValue;
                }
            }
            return 0;
        }



    }
}
