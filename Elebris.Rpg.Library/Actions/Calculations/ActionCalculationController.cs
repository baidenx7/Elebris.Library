using Elebris.Actions.Library.Actions.Core;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Text;
using Elebris.Rpg.Library.Actions.ActionValues;
using Elebris.Rpg.Library.Config;
using Elebris.Core.Library.Enums.Tags;
using Elebris.Core.Library.Objects;

namespace Elebris.Rpg.Library.Actions.Calculations
{
    public static partial class ActionCalculationController
    {
        public static void CalculateDamageAction(CharacterValueContainer target, DamageAction action)
        {

            //get the value here, 
            if(!ExceededBarrier(ref action.value, (float)target.DataHandler.RetrieveValue(ResourceStats.BarrierResource), action.Subtype == ActionSubtype.Energy))
            {
                target.DataHandler.ModifyResourceValue(ResourceStats.BarrierResource, -action.value);
            }
            else
            {
                target.DataHandler.ModifyResourceValue(ResourceStats.BarrierResource, -(float)target.DataHandler.RetrieveValue(ResourceStats.BarrierResource));
            }
            CheckCritical(ref action.value, action.ActionCritChance.TotalValue, action.ActionCritMultipler.TotalValue);

            CheckDamageReductionPercent(ref action.value, target.DataHandler.RetrieveArmorValue(action.Type)); //deal damage agains the relevant armor type

            CheckUnprotected(ref action.value); //if targetted armor is broken deal more dmg

            DamageReductionFlat(ref action.value, target.DataHandler.RetrieveMitigation(action.Type));

            CheckWeakness(ref action.value, (WeaknessValue)target.DataHandler.RetrieveValue(action.Element));

            //modify armor durability
            target.DataHandler.ModifyResourceValue(ResourceStats.HealthResource, -action.value);
        }


        private static bool ExceededBarrier(ref float damage, float barrier, bool dealsEnergyDamage = false)
        {
            float currentDamage = dealsEnergyDamage ? damage * Constants.SUBTYPE_MULTIPLIER : damage;

            if(currentDamage > barrier)
            {
                damage = currentDamage - barrier;
                return true;
            }
            else
            {
                damage = barrier - currentDamage;
                return false;
            }
        }

        private static void damageArmor()
        {
            // worry about this way later. for now durability is backburner entirely
        }

        private static void CheckDamageReductionPercent(ref float damage, float defense)
        {
            float remVal = damage * (100 / (100 + defense));
            damage = damage - remVal;

        }

        private static void CheckCritical(ref float damage,float chance, float damageMulti)
        {
            Random rand = new Random();
            damage = rand.Next(0, 100) > chance ? damage * damageMulti : damage;
            //later add event tie in?
        }

        private static void DamageReductionFlat(ref float damage, float mitigation)
        {
            damage = Math.Max(0, damage - mitigation);
        }

        private static void CheckUnprotected(ref float damage, bool isUnprotected = true)
        {
            damage = isUnprotected ? damage * Constants.SUBTYPE_MULTIPLIER : damage;
        }

        private static void CheckWeakness(ref float damage, WeaknessValue value)
        {
            damage *= value.DamageMultiplier;
        }
    }
    public static partial class ActionCalculationController
    {

        public static void CalculateHealAction()
        {

        }
    }
}
