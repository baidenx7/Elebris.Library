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
        ChargeMoveSpeedIncrease,
        //ChargeValueIncrease,
        ReserveCost,
        HealthRegeneration,
        StaminaRegeneration,
        SpiritRegeneration,
        ManaRegeneration,
        MoveSpeed,
        OverBurdenedPenaltyScale,
        WeightLimit,
    
        AttackSpeed,
        MaxAttackSpeed,

        GlobalCritChance,
        RangedCritChance,
        SpellCritChance,
        PhysicalCritChance,

        GlobalCritDamage,
        RangedCritDamage,
        SpellCritDamage,
        PhysicalCritDamage,

        RangedDamage,
        SpellDamage,
        PhysicalDamage,

        RangedArmor,
        SpellArmor,
        PhysicalArmor,

        RangedResistance,
        SpellResistance,
        PhysicalResistance,

        MaxResistance,

        OutgoingHealShieldEffectScale,
        IncomingHealShieldScale,

        ActionLockScale,
        WeaponDurabilityLossChance,
        ArmorDurabilityLossChance,
        IncreasedDurabilityDamage,
        MaxSummonCapacity,
        BoostedMinionDamage,
        BoostedMinionDuration,
        WorkSkill,
        WorkRefreshSpeed,
        WorkResourcesRecovered,
        ItemCooldownReduction,

        StatusEffectReduction,
        StatusTimeReduction,
        MaxCastSpeed,
        MaxChannelSpeed,

        CurrentCooldownReduction,
        MaxCooldownReductionCap,

        ProjectileSpeed,

        SkillAreaSize,
        AttackRange,

        SkillDuration,
        //ActionDamage,
        CostReduction,
        SpiritResource,
        StaminaResource,
        ManaResource,
        HealthResource,
        BarrierResource,
    }

    public enum DerivedStats
    {
        Brawn,
        Ability,
        Dexterity
    }

    //For specification not inserting

    public enum BaseStatType
    {
        Damage,
        Armor,
        Resource,
        Chance,
        Mitigation
    }

}