using Elebris.Library.Units.Creation;
using Elebris.Rpg.Library.Units.Core.Models;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public class CharacterStatFactory : ICharacterStatFactory
    {
        private readonly IStatSetBuilder _builder;

        public CharacterStatFactory(IStatSetBuilder builder)
        {
            _builder = builder;
        }
        public Dictionary<string, StatValue> Retrieve()
        {
            return _builder.GenerateStatSet();
        }
    }
}