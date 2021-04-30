

namespace Elebris.Rpg.Library.Config
{

    //Switch to Environment file?
    public static class ConstantValues
    {
        public const int DEFAULT_ATTRIBUTE_VALUE = 5;
        public const int DEFAULT_MAX_TOTAL_VALUE = 60;
        public const int DEFAULT_MAX_ATTRIBUTE_VALUE = 20; // this is the naturally reachable value, classes and gear can exceed this value.
        public const int DEFAULT_BIAS_VALUE = 12;
        public const int DEFAULT_CLASS_BIAS = 9;

        public const int DEFAULT_IMMUNE_VALUE = 15;
        public const int DEFAULT_RESIST_VALUE = 5;
        public const int DEFAULT_NEUTRAL_VALUE = -5;
        public const int DEFAULT_WEAK_VALUE = -15;


        public const float WEAKNESS_MULTIPLER = 0.5f; //I dont want to change this without seeing what it touches, but currently its additive,, should probably be cahnged to 1.5 (multiplicative)

        public const float SUBTYPE_MULTIPLIER = 0.5f;

        public const float REDUCE_CHARGE_MULTIPLIER = 0.8f; //every level of charge reached reduces the time needed to reach the next level.

        public const float GLOBAL_MIN_ATTACK_COOLDOWN = .05f; //use the greater of attack cooldown or this cooldown before next attack is usable

        public const float GLOBAL_MIN_Action_COOLDOWN = .5f;  //use the greater of action cooldown or this cooldown before next action is usable


    }
    //The below code is probably never going to see the light of day. but I dont want to delete it quite yet sicne it makes for a good reference
    public static class ConstantStatPopulator
    {

        public static void PopulateStats()
        {

            ////pass in the string (from enum), base value (what you would have at lvl 0), the scale
            ////per point in x stat, and the scale regardless of points in x stat, and finally the governing attribute(x)
            //AddValues(Stats.HealthResource, 300, .5f, 10, Attributes.Constitution);
            //AddValues(Stats.ManaResource, 10, .3f, 1, Attributes.Wisdom);
            //AddValues(Stats.SpiritResource, 10, .3f, 1, Attributes.Constitution);
            //AddValues(Stats.StaminaResource, 10, .3f, 1, Attributes.Expertise);
            //AddValues(Stats.BarrierResource, 10, .3f, 1, Attributes.None);

            //AddValues(Stats.HealthRegeneration, 1, .01f, .1f, Attributes.Strength);
            //AddValues(Stats.ManaRegeneration, 1, .01f, .1f, Attributes.Intelligence);
            //AddValues(Stats.SpiritRegeneration, 1, .01f, .1f, Attributes.Strength);
            //AddValues(Stats.StaminaRegeneration, 1, .01f, .1f, Attributes.Agility);
            //AddValues(Stats.BarrierResource, 0, 0, 0, Attributes.None);
            //AddValues(Stats.MoveSpeed, 20, .01f, .05f, Attributes.Agility);
            //AddValues(Stats.AttackSpeed, 3, .01f, 0, Attributes.Expertise);
            //AddValues(Stats.MaxAttackSpeed, 5, .2f, 0, Attributes.Agility);
            //AddValues(Stats.OverBurdenedPenaltyScale, .2f, .02f, 0, Attributes.Constitution);
            //AddValues(Stats.WeightLimit, 20, .3f, .5f, Attributes.Strength);
            //AddValues(Stats.WorkSkill, 0, .2f, .5f, Attributes.Expertise);
            //AddValues(Stats.WorkRefreshSpeed, 0, .3f, .2f, Attributes.Constitution);
            //AddValues(Stats.WorkResourcesRecovered, .1f, .02f, .01f, Attributes.Wisdom);
            //AddValues(Stats.GlobalCritChance, 1f, 0, .001f, Attributes.None);
            //AddValues(Stats.PhysicalCritChance, 0, 0, 0, Attributes.None);
            //AddValues(Stats.RangedCritChance, 0, 0, 0, Attributes.None);
            //AddValues(Stats.SpellCritChance, 0, 0, 0, Attributes.None);
            //AddValues(Stats.GlobalCritDamage, 1.25f, 0, 0, Attributes.None);
            //AddValues(Stats.PhysicalCritDamage, 0, 0, 0, Attributes.None);
            //AddValues(Stats.RangedCritDamage, 0, 0, 0, Attributes.None);
            //AddValues(Stats.SpellCritDamage, 0, 0, 0, Attributes.None);
            //AddValues(Stats.PhysicalResistance, 0, .01f, 0.005f, Attributes.Strength);
            //AddValues(Stats.SpellResistance, 0, .01f, 0.005f, Attributes.Strength);
            //AddValues(Stats.RangedResistance, 0, .01f, 0.005f, Attributes.Strength);
            //AddValues(Stats.MaxResistance, 3, .01f, .005f, Attributes.Constitution);
            //AddValues(Stats.OutgoingHealShieldEffectScale, 0, .2f, 0, Attributes.Wisdom);
            //AddValues(Stats.IncomingHealShieldScale, 0, .2f, 0, Attributes.Constitution);
            //AddValues(Stats.WeaponDurabilityLossChance, 20, .001f, .001f, Attributes.Expertise);
            //AddValues(Stats.ArmorDurabilityLossChance, 20, .001f, .001f, Attributes.Constitution);
            //AddValues(Stats.IncreasedDurabilityDamage, 0, 0, 0, Attributes.Strength); //Int or ext?
            //AddValues(Stats.MaxCastSpeed, 0, .002f, 0, Attributes.Intelligence); // lowers the time locked in place after using a skill?
            //AddValues(Stats.MaxChannelSpeed, 1, .002f, 1, Attributes.Wisdom); // bar fills quicker
            //AddValues(Stats.ItemCooldownReduction, 0, .3f, 0, Attributes.Intelligence);
            //AddValues(Stats.CurrentCooldownReduction, 0, 0, 0, Attributes.None);
            //AddValues(Stats.MaxCooldownReductionCap, 0, 0, 0, Attributes.None);
            //AddValues(Stats.StatusEffectReduction, 0, .02f, 0, Attributes.Constitution);
            //AddValues(Stats.StatusTimeReduction, 0, .03f, 0, Attributes.Strength); //may result in dramatically lwoered damage taken if you can skip a few ticks on a DoT
            //AddValues(Stats.MaxSummonCapacity, 1, .03f, .02f, Attributes.Intelligence);
        }

    }

}
