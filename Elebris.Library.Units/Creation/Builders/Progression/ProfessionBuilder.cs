using Elebris.Rpg.Library.Units.Data.Containers;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public class ProfessionBuilder : IProfessionBuilder
    {
        public Dictionary<string, CharacterProfessionModel> Retrieve()
        {
            Dictionary<string, CharacterProfessionModel> dict = new Dictionary<string, CharacterProfessionModel>();
            return dict;
        }
    }
}
