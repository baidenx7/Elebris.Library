using Elebris.Actions.Library.Actions.Core;
using Elebris.Rpg.Library.Actions.ActionValues;
using Elebris.Rpg.Library.Config;
using Elebris.Rpg.Library.Units.Combat.Models;
using Elebris.Rpg.Library.Units.Resources.Enforcing;
using System;

namespace Elebris.Rpg.Library.Units.Actions.Processing.Calculations
{
    public static partial class ActionCalculationController
    {
        public static void CalculateDamageAction(Unit target, DamageAction action)
        {

            //get the value here, 
            if (!ExceededBarrier(ref action.value, target.ResourceHandler.StoredResourceBars[Resource.Barrier].CurrentValue, action.Subtype == ActionSubtype.Energy))
            {
                target.ResourceHandler.ModifyResourceValue(Resource.Barrier, -action.value);
            }
            else
            {
                target.ResourceHandler.ModifyResourceValue(Resource.Barrier, -target.ResourceHandler.StoredResourceBars[Resource.Barrier].CurrentValue);
            }
            CheckCritical(ref action.value, action.ActionCritChance.TotalValue, action.ActionCritMultipler.TotalValue);

            CheckDamageReductionPercent(ref action.value, target.ValueHandler.RetrieveArmorValue(action.Type)); //deal damage agains the relevant armor type

            CheckUnprotected(ref action.value); //if targetted armor is broken deal more dmg

            DamageReductionFlat(ref action.value, target.ValueHandler.RetrieveMitigation(action.Type));

            CheckWeakness(ref action.value, target.ValueHandler.RetrieveWeaknessValue(action.Element));

            //modify armor durability
            target.ResourceHandler.ModifyResourceValue(Resource.Health, -action.value);
        }


        private static bool ExceededBarrier(ref float damage, float barrier, bool dealsEnergyDamage = false)
        {
            float currentDamage = dealsEnergyDamage ? damage * Constants.SUBTYPE_MULTIPLIER : damage;

            if (currentDamage > barrier)
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

        private static void CheckCritical(ref float damage, float chance, float damageMulti)
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
        public static void CalculateHealAction()
        {

        }
    }
    public class ActionCalculation
    {
        public virtual int Order { get; set; } = 10;

        public virtual void Calculate()
        {

        }

    }

}
