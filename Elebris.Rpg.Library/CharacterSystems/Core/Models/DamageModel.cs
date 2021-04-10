using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.CharacterSystems.Core.Models
{
    public struct DamageModel
    {

        public ActionDamageType damageType;
        public BaseStatType statType;

        public DamageModel(ActionDamageType damageType, BaseStatType statType)
        {
            this.damageType = damageType;
            this.statType = statType;
            ArmorValue = new StatValue();
            MitigationValue = new StatValue();
            DamageValue = new StatValue();
            CritDamage = new StatValue();
            CritChance = new StatValue();
        }

        public StatValue ArmorValue { get; set; }
        public StatValue MitigationValue { get; set; }

        //ArmorReduction
        //ArmorPierce/Penetration
        public StatValue DamageValue { get; set; }

        public StatValue CritDamage { get; set; }
        public StatValue CritChance { get; set; }


    }


}
