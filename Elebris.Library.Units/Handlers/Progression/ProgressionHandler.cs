using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Elebris.Library.Units.Objects.Progression;
using Elebris.Rpg.Library.Units.Core.Handlers;
using Elebris.Rpg.Library.Units.Data.Containers;
using Elebris.Rpg.Library.Units.UnitClasses.Containers;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Data.Handlers
{
    /// <summary>
    /// Sits on a character and acts as a pass-through for any actions used on a character. All value calculations are handled before this
    /// in the ActionCalculationController so values that make it this far should not need to have any further calculations run on them
    /// </summary>
    /// 

    public class ProgressionHandler : CharacterHandler, IProgressionHandler
    {
        private Dictionary<string, CharacterClassModel> StoredClasses { get; set; }
        private Dictionary<string, CharacterProfessionModel> StoredProfessions { get; set; }
        private ProgressionValue CharacterExperience { get; set; }
        public ProgressionHandler(Character character, Dictionary<string, CharacterClassModel> classSet, Dictionary<string, CharacterProfessionModel> professionSet) : base(character)
        {
            StoredClasses = classSet;
            StoredProfessions = professionSet;

        }

    }
}
