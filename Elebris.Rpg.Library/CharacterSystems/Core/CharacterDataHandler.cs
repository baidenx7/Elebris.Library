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

namespace Elebris.Rpg.Library.CharacterSystems.Core
{
    public class CharacterDataHandler : CharacterHandler
    {
        internal Dictionary<Attributes, StatValue> StoredAttributes { get; set; }
        internal Dictionary<Stats, StatValue> StoredStats { get; set; }
        internal List<IManipulationValue> StoredManipulationValues { get; set; }
        internal Dictionary<Elements, WeaknessValue> StoredWeaknesses { get; set; }
        internal List<DamageModel> DamageModels { get; set; } //Link these to Stored Stats
        public CharacterDataHandler(CharacterValueContainer container) : base(container)
        {
            //init dicts and lists?
        }

        public float RetrieveStatValue(Stats stat)
        {
            CheckOrCreateStat(stat);
            StatValue cur = StoredStats[stat];

            return cur.TotalValue;
        }

        private void CheckOrCreateStat(Stats stat)
        {
            if (StoredStats[stat] == null)
            { //replace this with a call to a factory that knows what "default" values to return
                StoredStats.Add(stat, new StatValue());
            }
        }

        public StatValue CopyStat(Stats stat)
        {
            CheckOrCreateStat(stat);
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
