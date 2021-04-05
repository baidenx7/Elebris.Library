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
        private CharacterValueContainer container;
        public CharacterDataHandler(CharacterValueContainer container)
        {
            this.container = container;
        }
       

        public void ModifyResourceValue(ResourceStats resources, float value)
        {
            container.StoredResourceBars[resources].CurrentValue += value;
        }

        //series of overloaded fucntions for specific purposes
        
        public float RetrieveStatValue(Stats value)
        {
            CheckOrCreateStat(value);
            StatValue cur = container.StoredStats[value];

            return cur.TotalValue;
        }

        private void CheckOrCreateStat(Stats value)
        {
            if (container.StoredStats[value] == null)
            { //replace this with a call to a factory that knows what "default" values to return
                container.StoredStats.Add(value, new StatValue());
            }
        }

        public StatValue CopyStat(Stats value)
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



        public ResourceBarValue RetrieveResourceData(ResourceStats value)
        {
            return container.StoredResourceBars[value];
        }

        public float RetrieveCritChance(ActionDamageType type)
        {

            float value = (float)container.DataHandler.RetrieveStatValue(Stats.GlobalCritChance);
            switch (type)
            {
                case ActionDamageType.Physical:
                    value += (float)container.DataHandler.RetrieveStatValue(Stats.PhysicalCritChance);
                    break;
                case ActionDamageType.Ranged:
                    value += (float)container.DataHandler.RetrieveStatValue(Stats.SpellCritChance);
                    break;
                case ActionDamageType.Spell:
                    value += (float)container.DataHandler.RetrieveStatValue(Stats.RangedCritChance);
                    break;
                default:
                    break;
            }
            return value;
        }
        public float RetrieveCritMultiplier(ActionDamageType type)
        {

            float value = (float)container.DataHandler.RetrieveStatValue(Stats.GlobalCritDamage);
            switch (type)
            {
                case ActionDamageType.Physical:
                    value += (float)container.DataHandler.RetrieveStatValue(Stats.PhysicalCritDamage);
                    break;
                case ActionDamageType.Ranged:
                    value += (float)container.DataHandler.RetrieveStatValue(Stats.SpellCritDamage);
                    break;
                case ActionDamageType.Spell:
                    value += (float)container.DataHandler.RetrieveStatValue(Stats.RangedCritDamage);
                    break;
                default:
                    break;
            }
            return value;
        }

        public float RetrieveArmorValue(ActionDamageType type)
        {
            //TODO fix up these
            switch (type)
            {
                //case ActionDamageType.Physical:
                //    string pval = type.ToString() + BaseStatType.Armor.ToString();
                //    return (float)container.DataHandler.RetrieveStatValue(pval);
                //case ActionDamageType.Ranged:
                //    string rval = type.ToString() + BaseStatType.Armor.ToString();
                //    return (float)container.DataHandler.RetrieveStatValue(rval);
                //case ActionDamageType.Spell:
                //    string sval = type.ToString() + BaseStatType.Armor.ToString();
                //    return (float)container.DataHandler.RetrieveStatValue(sval);
                default:
                    return 0;
            }

        }
        public float RetrieveMitigation(ActionDamageType type)
        {
            switch (type)
            {
                //case ActionDamageType.Physical:
                //    string pval = type.ToString() + BaseStatType.Mitigation.ToString();
                //    return (float)container.DataHandler.RetrieveValue(pval);
                //case ActionDamageType.Ranged:
                //    string rval = type.ToString() + BaseStatType.Mitigation.ToString();
                //    return (float)container.DataHandler.RetrieveValue(rval);
                //case ActionDamageType.Spell:
                //    string sval = type.ToString() + BaseStatType.Mitigation.ToString();
                //    return (float)container.DataHandler.RetrieveValue(sval);
                default:
                    return 0;
            }

        }


    }
}
