using Elebris.Rpg.Library.CharacterValues;
using Elebris.Core.Library.CharacterValues.Mutable;
using System.Collections.Generic;
using Elebris.Rpg.Library.CharacterSystems.Core.Containers;

namespace Elebris.Rpg.Library.CharacterSystems.Core
{
    /// <summary>
    /// Sits on a character and acts as a pass-through for any actions used on a character. All value calculations are handled before this
    /// in the ActionCalculationController so values that make it this far should not need to have any further calculations run on them
    /// </summary>
    /// 

    public class UnitDataHandler : CharacterHandler
    {

        private Dictionary<string, CharacterClassHolder> StoredClasses { get; set; }
        private Dictionary<string, CharacterProfessionHolder> StoredProfessions { get; set; }
        public UnitDataHandler(Unit container) : base(container)
        {
            StoredClasses = new Dictionary<string, CharacterClassHolder>();
            StoredProfessions = new Dictionary<string, CharacterProfessionHolder>();
        }

    }
}
