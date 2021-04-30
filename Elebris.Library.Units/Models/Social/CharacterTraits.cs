using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Social.Models
{
    public class CharacterTraits
    {
        private List<CharacterTraitValue> _traits = new();

        public List<CharacterTraitValue> Traits { get => _traits; set => _traits = value; }
    }
}