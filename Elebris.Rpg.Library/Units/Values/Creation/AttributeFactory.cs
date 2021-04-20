using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Enforcing;
using Elebris.Rpg.Library.Units.Values.Models;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Values.Creation
{
    public class AttributeFactory : IAttributeFactory
    {
        public Dictionary<Attributes, StatValue> Retrieve()
        {
            return AttributeSetBuilder.GenerateClassAttributeSet();
        }
    }
}
