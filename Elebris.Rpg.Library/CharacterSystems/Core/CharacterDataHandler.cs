using Elebris.Core.Library.Enums;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.Actions.ActionValues;
using System;
using Elebris.Rpg.Library.StatGeneration;

namespace Elebris.Rpg.Library.CharacterSystems.Core
{
    /// <summary>
    /// Sits on a character and acts as a pass-through for any actions used on a character. All value calculations are handled before this
    /// in the ActionCalculationController so values that make it this far should not need to have any further calculations run on them
    /// </summary>
    public class CharacterDataHandler
    {
        CharacterValueContainer container;
        public CharacterDataHandler(CharacterValueContainer container)
        {
            this.container = container;
            
        }
       

        public void ModifyValue(ResourceStats resources, float value)
        {
            container.StoredResourceBars[resources].CurrentValue += value;
        }

        //series of overloaded fucntions for specific purposes
        public void InsertValue()
        {
            //Unit to insert into
            //type of value
            //if its a value modifier, what type of modifier
            //if i need knowledge about a specific piece of gear, what piece, and what value. might need a special return type to grab multiple relevant values at once

            //in some isntances of Insert,if a value already exists i can decide per-item how to handle it (ignore/replace or add to the current value)

        }

        public void InsertValue(string name, BaseStatValue baseVal)
        {
            container.StoredBaseValues.Add(name, baseVal);//These values will 
            container.StoredStats[name].BaseValue = container.StoredBaseValues[name].Get;
        }

        public void RemoveStat(string name)
        {
            //unsubscribe necessary before removing the stat?
            if (!container.StoredStats.ContainsKey(name)) return;
           
            container.StoredStats.Remove(name);
        }


        //unit to retreive from (or more specifically CharacterValueContainer)
        //type of value to retrieve (attribute, stat, progression value, resource)
        //

        //Once this is satisfactory turn it into an interface so I can create a mock class to start testing with
        public object RetrieveValue(Elements element)
        {
            return container.StoredWeaknesses[element];
        }
        public object RetrieveValue(ResourceStats value)
        {
            return container.StoredResourceBars[value].CurrentValue;
        }
        public object RetrieveValue(Attributes value)
        {
            return container.StoredAttributes[value];
        }
        public object RetrieveValue(ProgressionValues value)
        {
            return container.StoredProgressionValues[value].GetCurrentPoints();
        }
        public object RetrieveValue(string value)
        {
            CheckOrCreateStat(value);
            StatValue cur = container.StoredStats[value];

            return cur.TotalValue;
        }

        private void CheckOrCreateStat(string value)
        {
            if (container.StoredStats[value] == null)
            {
                container.StoredStats.Add(value, new StatValue());
            }
        }

        public StatValue CopyStat(string value)
        {
            CheckOrCreateStat(value);
            StatValue cur = container.StoredStats[value];
            StatValue val = new StatValue(cur.BaseValue);
            foreach (var modifier in cur.ValueModifiers)
            {
                val.AddModifier(modifier);
            }

            return val;
        }

        /// <summary>
        /// Call Once at start, and then whenever an attribute or level changes
        /// </summary>
       


        public ResourceBarValue RetrieveResourceData(ResourceStats value)
        {
            return container.StoredResourceBars[value];
        }

        public float RetrieveCritChance(ActionDamageType type)
        {

            float value = (float)container.DataHandler.RetrieveValue(Stats.GlobalCritChance.ToString());
            switch (type)
            {
                case ActionDamageType.Physical:
                    value += (float)container.DataHandler.RetrieveValue(Stats.PhysicalCritChance.ToString());
                    break;
                case ActionDamageType.Ranged:
                    value += (float)container.DataHandler.RetrieveValue(Stats.SpellCritChance.ToString());
                    break;
                case ActionDamageType.Spell:
                    value += (float)container.DataHandler.RetrieveValue(Stats.RangedCritChance.ToString());
                    break;
                default:
                    break;
            }
            return value;
        }
        public float RetrieveCritMultiplier(ActionDamageType type)
        {

            float value = (float)container.DataHandler.RetrieveValue(Stats.GlobalCritDamage.ToString());
            switch (type)
            {
                case ActionDamageType.Physical:
                    value += (float)container.DataHandler.RetrieveValue(Stats.PhysicalCritDamage.ToString());
                    break;
                case ActionDamageType.Ranged:
                    value += (float)container.DataHandler.RetrieveValue(Stats.SpellCritDamage.ToString());
                    break;
                case ActionDamageType.Spell:
                    value += (float)container.DataHandler.RetrieveValue(Stats.RangedCritDamage.ToString());
                    break;
                default:
                    break;
            }
            return value;
        }

        public float RetrieveArmorValue(ActionDamageType type)
        {
            switch (type)
            {
                case ActionDamageType.Physical:
                    string pval = type.ToString() + BaseStatType.Armor.ToString();
                    return (float)container.DataHandler.RetrieveValue(pval);
                case ActionDamageType.Ranged:
                    string rval = type.ToString() + BaseStatType.Armor.ToString();
                    return (float)container.DataHandler.RetrieveValue(rval);
                case ActionDamageType.Spell:
                    string sval = type.ToString() + BaseStatType.Armor.ToString();
                    return (float)container.DataHandler.RetrieveValue(sval);
                default:
                    return 0;
            }

        }
        public float RetrieveMitigation(ActionDamageType type)
        {
            switch (type)
            {
                case ActionDamageType.Physical:
                    string pval = type.ToString() + BaseStatType.Mitigation.ToString();
                    return (float)container.DataHandler.RetrieveValue(pval);
                case ActionDamageType.Ranged:
                    string rval = type.ToString() + BaseStatType.Mitigation.ToString();
                    return (float)container.DataHandler.RetrieveValue(rval);
                case ActionDamageType.Spell:
                    string sval = type.ToString() + BaseStatType.Mitigation.ToString();
                    return (float)container.DataHandler.RetrieveValue(sval);
                default:
                    return 0;
            }

        }


        internal void PairEvents()
        {
            //Link attributes to leveling up as a firing event
            foreach (var item in container.StoredAttributes)
            {
                container.StoredProgressionValues[ProgressionValues.CharacterExperience].onLevelUpGeneric += item.Value.CharacterValuesChanged;
            }
            //link base values (that change with attributes) to attributes, when theyre modified
            foreach (var item in container.StoredBaseValues)
            {
                container.StoredAttributes[item.Value.GoverningAttribute].SubjectModified += item.Value.SubjectUpdated;
            }
            //Link stats to base values that share a string (or enum if I switch)
            foreach (var item in container.StoredBaseValues.Keys)
            {
                if (container.StoredStats.ContainsKey(item))
                {
                    container.StoredBaseValues[item].OnBaseUpdated += container.StoredStats[item].UpdateBaseValue;
                }
            }

            container.StoredProgressionValues[ProgressionValues.CharacterExperience].IncreaseLevel();
            //ResourceBars are currently set at Generation Time
            //Inititalize 

        }
    }
}
