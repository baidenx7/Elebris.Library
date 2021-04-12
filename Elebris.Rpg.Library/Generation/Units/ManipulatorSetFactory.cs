using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Enums;
using Elebris.UnitCreation.Library.StatGeneration;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Factories.UnitGeneration
{
    public static class ManipulatorSetFactory
    {

        //public static void PopulateManipulationValues(Unit container)
        //{
        //    List<IManipulationValue> ManipulationList = container.ValueHandler.StoredManipulationValues;
        //    if (ManipulationList != null && ManipulationList.Count > 0)
        //    {
        //        //List is already populated in some way
        //        return;
        //    }

        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.StaminaRegeneration, Attributes.Agility, 1f, .005f, .005f, .1f));
        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.ManaRegeneration, Attributes.Intelligence, 1, .005f, .005f, .1f));
        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.SpiritRegeneration, Attributes.Expertise, 1, .005f, .005f, .1f));
        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.HealthRegeneration, Attributes.Constitution, 1, .005f, .005f, .1f));


        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.MaxAttackSpeed, Attributes.Agility, 1, .003f, .002f, .01f));
        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.ActionLockScale, Attributes.Agility, 1, 0, 0, -.01f));

        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.ProjectileSpeed, Attributes.Agility, 1, 0, .001f, .01f));

        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.OverBurdenedPenaltyScale, Attributes.Constitution, .5f, 0, .001f, 0));
        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.IncomingHealShieldScale, Attributes.Constitution, 1, 0, .003f, .005f));

        //    ManipulationList.Add(new LevelScalingStatValue(container, Stats.AttackSpeed, Attributes.Expertise, 0, 0, .003f, .005f));
        //    ManipulationList.Add(new LevelScalingStatValue(container, Stats.MoveSpeed, Attributes.None, 0, 0, .003f, .005f));
        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.ChargeMoveSpeedIncrease, Attributes.Expertise, .35f, 0, .001f, .01f));

        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.MaxCastSpeed, Attributes.Intelligence, 1, 0, -.001f, -.002f));
        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.ReserveCost, Attributes.Intelligence, 1, 0, -.0005f, -.001f));

        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.WeightLimit, Attributes.Strength, 10, 0.3f, .08f, .1f));
        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.StatusEffectReduction, Attributes.Strength, 1, 0, -.001f, -.002f));

        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.WorkResourcesRecovered, Attributes.Wisdom, .1f, 0, -.001f, -.002f));
        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.OutgoingHealShieldEffectScale, Attributes.Wisdom, 1, 0, .003f, .005f));
        //    //ManipulationList.Add(new LevelScalingStatValue(container, Stats.ChargeReduction, Attributes.Wisdom, 1, 0, -.001f, -.001f));


        //}
    }



}
