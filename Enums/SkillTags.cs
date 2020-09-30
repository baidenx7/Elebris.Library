public enum SkillTags
{
    //tags that denote how a skill acts
    AreaOfEffect,
    SingleTarget,
    Line,
    Cone,
    Aura,
    WeaponSkill, //modifies next autoattack
    Passive,


    
}

public enum SkillSubTags
{
    //denotes what a skill does
    Heal,
    DamageOverTime,
    Affliction, //replaceable by individual afflictions under a parent reference
    Elemental, // replaceable by individual elements under a parent reference
    Boon,
    Bane,
}