using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Social.Models
{
    public class CharacterTraits
    {
        private List<CharacterTrait> traits = new List<CharacterTrait>();

        public List<CharacterTrait> Traits { get => traits; set => traits = value; }
    }
}