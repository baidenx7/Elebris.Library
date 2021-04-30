using Elebris.Library.Units.Creation;
using Elebris.Rpg.Library.Units.Core.Models;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public class AttributeFactory : IAttributeFactory
    {
        private readonly IAttributeSetBuilder _builder;

        public AttributeFactory(IAttributeSetBuilder builder)
        {
            _builder = builder;
        }
        public Dictionary<string, StatValue> Retrieve()
        {
            return _builder.GenerateClassAttributeSet();
        }
    }
}
