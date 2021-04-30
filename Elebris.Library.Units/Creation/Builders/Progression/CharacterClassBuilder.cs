using Elebris.Rpg.Library.Units.UnitClasses.Containers;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public class CharacterClassBuilder : ICharacterClassBuilder
    {
        public Dictionary<string, CharacterClassModel> Retrieve()
        {
            Dictionary<string, CharacterClassModel> dict = new();

            return dict;
        }
    }
}
