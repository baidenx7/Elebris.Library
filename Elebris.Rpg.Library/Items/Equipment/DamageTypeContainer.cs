using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.Items.Equipment
{
    public class DamageTypeContainer
    {
        public readonly ActionDamageType type;
        public StatValue Value { get; set; } = new StatValue(0);

        public DamageTypeContainer(ActionDamageType type)
        {
            this.type = type;
        }
    }
}
