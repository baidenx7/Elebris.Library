using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterSystems.UnitGeneration;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Utils;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elebris.Rpg.Library.StatGeneration
{
    public static class CharacterGenerationHandler
    {
        private static Dictionary<string, BaseStatValue> storedDefaultBaseStats;
        private static Dictionary<string, StatValue> storedDefaultStats;
        public static CharacterValueContainer CreateCharacterValues() //
        {
            CharacterValueContainer container = new CharacterValueContainer();
            SetCharacterValues(ref container);
            return container;

        }
        public static CharacterValueContainer CreateCharacterValues(Guid guid)
        {
            CharacterValueContainer container = new CharacterValueContainer();
            SetCharacterValues(ref container, guid);
            return container;
        }

        private static void SetCharacterValues(ref CharacterValueContainer container)
        {
            //split container into components to be updated by the requester?
            Dictionary<string, int> attributeSet = GenerateAttributeSet();
            foreach (var item in attributeSet.Keys)
            {
                Attributes attrib = item.ToEnum<Attributes>();
                container.StoredAttributes.Add(attrib, new StatValue(attributeSet[item]));
            }

            container.StoredBaseValues = PopulateScalingStats(container);
            container.StoredStats = PopulateDefaultStats();
            GenerateResourceBars(container);
            GenerateProgressionValues(container);
            container.DataHandler.PairEvents();
        }

        private static void GenerateResourceBars(CharacterValueContainer container)
        {
            PopulateResource(container, ResourceStats.HealthResource, Stats.HealthResource);
            PopulateResource(container, ResourceStats.ManaResource, Stats.ManaResource);
            PopulateResource(container, ResourceStats.SpiritResource, Stats.SpiritResource);
            PopulateResource(container, ResourceStats.StaminaResource, Stats.StaminaResource);
            PopulateResource(container, ResourceStats.BarrierResource, Stats.BarrierResource);
        }

        private static void PopulateResource(CharacterValueContainer container, ResourceStats observer, Stats subject)
        {
            container.StoredResourceBars[observer] = new ResourceBarValue(1);
            container.StoredStats[subject.ToString()].SubjectModified += container.StoredResourceBars[observer].AlterMax;
        }
        private static void GenerateProgressionValues(CharacterValueContainer container)
        {
            container.StoredProgressionValues.Add(ProgressionValues.CharacterExperience, new ProgressionValue());
            
            container.StoredProgressionValues.Add(ProgressionValues.SanityLevel, new ProgressionValue());
        }

        //GenerateGear

        //GenerateClasses
        //container.StoredClasses.Add(filler, new ProgressionValue()); //separate dict for EACH class they have?

        private static void SetCharacterValues(ref CharacterValueContainer container, Guid charId)
        {
            //Load Classes
            //Retrieve Attributes and set string attributes back to enums
            //populate stats
            //set gear (to equipped)
           
        }
        private static Dictionary<string, int> GenerateAttributeSet()
        {
            //randomly generated
            Random rand = new Random();
            List<string> classAttributes = new List<string>();
            int count = Enum.GetNames(typeof(Attributes)).Length;
            for (int i = 0; i < 3; i++)
            {
                //3 random "classes" (just their governing attributes)
                int value = rand.Next(1, count); //Ignores "none"
                string current = ((Attributes)value).ToString();
                classAttributes.Add(current);
            }

            return AttributeSetGenerator.GenerateClassAttributeSet(classAttributes.ToArray());
        }


        private static Dictionary<string, int> GenerateAttributeSet(List<string> classAttributes)
        {
            //generated based on a bias towards classes. later I'll change it from just 3 attributes(as determined by the generator)
            //to as many as I want via  to include more dynamic bias-results for other factors (late game character generation methods? race-specific methods?
            return AttributeSetGenerator.GenerateClassAttributeSet(classAttributes.ToArray());
        }

        private static Dictionary<string, StatValue> PopulateDefaultStats()
        {

            if (storedDefaultStats != null && storedDefaultStats.Count > 0)
            {
                return storedDefaultStats;
            }
            storedDefaultStats = new Dictionary<string, StatValue>();
            foreach (var item in Enum.GetValues(typeof(Stats)))
            {
                storedDefaultStats.Add(item.ToString(), new StatValue(0));
            }
            return storedDefaultStats;
        }

        private static Dictionary<string, BaseStatValue> PopulateScalingStats(CharacterValueContainer container)
        {
            if (storedDefaultBaseStats != null && storedDefaultBaseStats.Count > 0)
            {
                return storedDefaultBaseStats;
            }

            storedDefaultBaseStats = new Dictionary<string, BaseStatValue>();
            storedDefaultBaseStats.Add(Stats.StaminaRegeneration.ToString(), new BaseStatValue(container, Attributes.Agility, 1, .005f, .005f, .1f));
            storedDefaultBaseStats.Add(Stats.ManaRegeneration.ToString(), new BaseStatValue(container, Attributes.Intelligence, 1, .005f, .005f, .1f));
            storedDefaultBaseStats.Add(Stats.SpiritRegeneration.ToString(), new BaseStatValue(container, Attributes.Expertise, 1, .005f, .005f, .1f));
            storedDefaultBaseStats.Add(Stats.HealthRegeneration.ToString(), new BaseStatValue(container, Attributes.Constitution, 1, .005f, .005f, .1f));

            storedDefaultBaseStats.Add(Stats.HealthResource.ToString(), new BaseStatValue(container, Attributes.Constitution, 100, 1, .2f, .5f));
            storedDefaultBaseStats.Add(Stats.BarrierResource.ToString(), new BaseStatValue(container, Attributes.Wisdom, 0, 1, .2f, .5f));

            storedDefaultBaseStats.Add(Stats.ManaResource.ToString(), new BaseStatValue(container, Attributes.Intelligence, 1, 0, .03f, .1f));
            storedDefaultBaseStats.Add(Stats.SpiritResource.ToString(), new BaseStatValue(container, Attributes.Constitution, 1, 0, .03f, .1f));
            storedDefaultBaseStats.Add(Stats.StaminaResource.ToString(), new BaseStatValue(container, Attributes.Expertise, 1, 0, .03f, .1f));

            storedDefaultBaseStats.Add(Stats.MaxAttackSpeed.ToString(), new BaseStatValue(container, Attributes.Agility, 1, .003f, .002f, .01f));
            storedDefaultBaseStats.Add(Stats.ActionLockScale.ToString(), new BaseStatValue(container, Attributes.Agility, 1, 0, 0, -.01f));

            storedDefaultBaseStats.Add(Stats.ProjectileSpeed.ToString(), new BaseStatValue(container, Attributes.Agility, 1, 0, .001f, .01f));

            storedDefaultBaseStats.Add(Stats.OverBurdenedPenaltyScale.ToString(), new BaseStatValue(container, Attributes.Constitution, .5f, 0, .001f, 0));
            storedDefaultBaseStats.Add(Stats.IncomingHealShieldScale.ToString(), new BaseStatValue(container, Attributes.Constitution, 1, 0, .003f, .005f));

            storedDefaultBaseStats.Add(Stats.AttackSpeed.ToString(), new BaseStatValue(container, Attributes.Expertise, 1, 0, .003f, .005f));
            storedDefaultBaseStats.Add(Stats.ChargeMoveSpeedIncrease.ToString(), new BaseStatValue(container, Attributes.Expertise, .35f, 0, .001f, .01f));
            storedDefaultBaseStats.Add(Stats.GlobalCritChance.ToString(), new BaseStatValue(container, Attributes.Expertise, .01f, 0, .0001f, 0));

            storedDefaultBaseStats.Add(Stats.MaxCastSpeed.ToString(), new BaseStatValue(container, Attributes.Intelligence, 1, 0, -.001f, -.002f));
            storedDefaultBaseStats.Add(Stats.ReserveCost.ToString(), new BaseStatValue(container, Attributes.Intelligence, 1, 0, -.0005f, -.001f));

            storedDefaultBaseStats.Add(Stats.WeightLimit.ToString(), new BaseStatValue(container, Attributes.Strength, 10, 0.3f, .08f, .1f));
            storedDefaultBaseStats.Add(Stats.StatusEffectReduction.ToString(), new BaseStatValue(container, Attributes.Strength, 1, 0, -.001f, -.002f));

            storedDefaultBaseStats.Add(Stats.WorkResourcesRecovered.ToString(), new BaseStatValue(container, Attributes.Wisdom, .1f, 0, -.001f, -.002f));
            storedDefaultBaseStats.Add(Stats.OutgoingHealShieldEffectScale.ToString(), new BaseStatValue(container, Attributes.Wisdom, 1, 0, .003f, .005f));
            storedDefaultBaseStats.Add(Stats.ChargeReduction.ToString(), new BaseStatValue(container, Attributes.Wisdom, 1, 0, -.001f, -.001f));



            return storedDefaultBaseStats;

        }


    }

}
