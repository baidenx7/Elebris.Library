namespace Elebris.UnitCreation.Library.StatGeneration
{
    //Anything functioning off chance will be between 0-100 not 0-1
    //multipliers however are much smaller since their calculation is 1 + multiplier * baseValue
    public enum Stats
    {
        //Separated these out.

        //Do these need their own Enum since the'yre combo values?
      
        //MaxBuffCapacity,
        //BarrierRegeneration,
        //BarrierDelay
        //Overheal?
        //Leech
        //PercentMitigation
        ChargeReduction,
        ChargeMoveSpeedModifier,
        //ChargeValueIncrease,

        ReserveCost,
        GlobalResourceRegeneration,
        GlobalResourceRegenerationRate,

        MoveSpeed,
        OverBurdenedPenaltyScale,
        WeightLimit,
        //Replace with capacity + slot like Idleon?
    
        AttackSpeed,
        MaxAttackSpeed,

        MaxResistance,


        ActionLockScale,
        
        MaxSummonCapacity,
        BoostedMinionDamage,
        BoostedMinionDuration,
        WorkSkill,
        WorkRefreshSpeed,
        WorkResourcesRecovered,
        ItemCooldownReduction,

        MaxCastSpeed,
        MaxChannelSpeed,

        CurrentCooldownReduction,
        MaxCooldownReductionCap,

        ProjectileSpeed,

        ActionRange,
        WeaponRange,

        SkillDuration,
        //ActionDamage,
        CostReduction,

        Brawn,
        Ability,
        Dexterity
    }

}