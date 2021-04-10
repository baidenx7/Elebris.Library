using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Rpg.Library.Factories
{
    public static class ValueGenerator
    {
        private static Dictionary<Stats, StatValue> _storedDefaultBaseStats = new Dictionary<Stats, StatValue>(); 
        public static void PopulateStatBaseDefault(Character container)
        {
            PopulateInternalStatDict();
            container.ValueHandler.StoredStats = _storedDefaultBaseStats.ToDictionary(entry => entry.Key,
                entry => entry.Value);
        }

        private static void PopulateInternalStatDict()
        {
            if (_storedDefaultBaseStats.Count > 0) return;
            Console.WriteLine("Populating Base Default Stats");
            //Threshold values
            AddDefaultBase(Stats.MaxAttackSpeed, 2);
            AddDefaultBase(Stats.MaxResistance, 1);

            //Multiplicative modifiers
            AddDefaultBase(Stats.OverBurdenedPenaltyScale, .5f);
            AddDefaultBase(Stats.ChargeReduction, 1);
            AddDefaultBase(Stats.ChargeMoveSpeedModifier, .5f);
            AddDefaultBase(Stats.ReserveCost, 1);
            AddDefaultBase(Stats.GlobalResourceRegeneration, 1);

            AddDefaultBase(Stats.BoostedMinionDamage, 1);
            AddDefaultBase(Stats.BoostedMinionDuration, 1);

            AddDefaultBase(Stats.WorkSkill, 1);
            AddDefaultBase(Stats.WorkRefreshSpeed, 1);
            AddDefaultBase(Stats.WorkResourcesRecovered, .2f);
            //Flat values
            AddDefaultBase(Stats.AttackSpeed, 1);
            AddDefaultBase(Stats.MoveSpeed, 5); //add max?
            AddDefaultBase(Stats.GlobalResourceRegenerationRate, 1);
            AddDefaultBase(Stats.WeightLimit, 50);
            AddDefaultBase(Stats.MaxSummonCapacity, 3);

            AddDefaultBase(Stats.ItemCooldownReduction, 1);
            AddDefaultBase(Stats.MaxCastSpeed, 1);
            AddDefaultBase(Stats.CurrentCooldownReduction, 1);
            AddDefaultBase(Stats.MaxCooldownReductionCap, 1);
            AddDefaultBase(Stats.ProjectileSpeed, 1);
            AddDefaultBase(Stats.ActionRange, 1);
            AddDefaultBase(Stats.WeaponRange, 1);
            AddDefaultBase(Stats.SkillDuration, 1);
            AddDefaultBase(Stats.CostReduction, 1);

            AddDefaultBase(Stats.Brawn, 1);
            AddDefaultBase(Stats.Ability, 1);
            AddDefaultBase(Stats.Dexterity, 1);

            //MaxBuffCapacity,
            //BarrierRegeneration,
            //BarrierDelay
            //Overheal?
            //Leech
            //PercentMitigation
            //ChargeValueIncrease,

            //ActionDamage,
        }
        private static void AddDefaultBase(Stats stat, float val)
        {
            _storedDefaultBaseStats.Add(stat,new StatValue(val));
        }
    }
}
//Each stat could really have its own struct containing flat, multiplicative and max, rather than using pure statvalues for 2 out of 3 and a separate "max"