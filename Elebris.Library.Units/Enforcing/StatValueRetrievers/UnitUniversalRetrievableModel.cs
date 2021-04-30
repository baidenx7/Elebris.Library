namespace Elebris.Rpg.Library.Units.Actions.Models
{
    public struct ResourceRetrievableModel : IRetrievableValue
    {

        public enum Type
        {
            
            Spirit,
            Stamina,
            Mana,
            Health,
            Barrier
        }
        public enum Category
        {
            Max,
            Regeneration,
            Leech,
            CostReduction,
            ReserveMultiplier
        }


        public string FormattedString => throw new System.NotImplementedException();
    }
    public struct UnitUniversalRetrievableModel : IRetrievableValue
    {

        public enum Type
        {

            MoveSpeed,
            OverBurdenedPenaltyScale,
            WeightLimit,
            AttackSpeed,
            MaxAttackSpeed,

            Brawn,
            Ability,
            Dexterity,
            WorkSkill,
            WorkRefreshSpeed,
            WorkResourcesRecovered,
            ItemCooldownReduction,
            ProjectileSpeed,
            ActionLockScale,

            MaxCastSpeedMultiplier,
            MaxChannelSpeedMultiplier,

            CurrentCooldownReduction,
            MaxCooldownReductionCap,

            GlobalResourceRegenerationMultiplier,
            GlobalResourceRegenerationRate,

            ActionRange,
            WeaponRange,
            CriticalArmor,

            //LifeLeech


        }
        public string FormattedString => throw new System.NotImplementedException();
    }
}

//Replace with capacity + slot like Idleon?
//


//MaxResistance,

//        SkillDuration,
//        //ActionDamage,
//        CostReduction,
