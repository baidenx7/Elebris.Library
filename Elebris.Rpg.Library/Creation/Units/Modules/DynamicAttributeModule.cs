using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.Rpg.Library.CharacterSystems.UnitGeneration;
using Elebris.Rpg.Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.Creation.Units.Modules
{
    public class DynamicAttributeModule : IAttributeModule
    {
        public Dictionary<Attributes, StatValue> Populate()
        {
            return AttributeSetGenerator.GenerateClassAttributeSet();
        }
    }
}
