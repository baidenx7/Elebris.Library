using Elebris.Rpg.Library.Units.Data.Containers;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Data.Creation
{
    public class ProfessionBuilder : IProfessionBuilder
    {
        public Dictionary<string, CharacterProfessionHolder> Retrieve()
        {
            Dictionary<string, CharacterProfessionHolder> dict = new Dictionary<string, CharacterProfessionHolder>();
            return dict;
        }
    }
}
