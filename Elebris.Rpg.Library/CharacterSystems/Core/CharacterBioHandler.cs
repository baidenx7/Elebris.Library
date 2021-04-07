using Elebris.Rpg.Library.CharacterValues;
using Elebris.Core.Library.CharacterValues.Mutable;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.CharacterSystems.Core
{
    /// <summary>
    /// Sits on a character and acts as a pass-through for any actions used on a character. All value calculations are handled before this
    /// in the ActionCalculationController so values that make it this far should not need to have any further calculations run on them
    /// </summary>
    /// 

    public class CharacterBioHandler : CharacterHandler
    {

        public Dictionary<string, CharacterClassHolder> StoredClasses { get; set; }
        public Dictionary<string, CharacterProfessionHolder> StoredProfessions { get; set; }
        public CharacterBioHandler(CharacterValueContainer container) : base(container)
        {

        }

    }
}
