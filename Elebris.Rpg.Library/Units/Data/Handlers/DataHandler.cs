using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Core.Handlers;
using Elebris.Rpg.Library.Units.Data.Containers;
using Elebris.Rpg.Library.Units.Data.Creation;
using Elebris.Rpg.Library.Units.UnitClasses.Containers;
using Elebris.Rpg.Library.Units.UnitClasses.Creation;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Data.Handlers
{
    /// <summary>
    /// Sits on a character and acts as a pass-through for any actions used on a character. All value calculations are handled before this
    /// in the ActionCalculationController so values that make it this far should not need to have any further calculations run on them
    /// </summary>
    /// 

    public class DataHandler : CharacterHandler
    {

        private Dictionary<string, CharacterClassHolder> StoredClasses { get; set; }
        private Dictionary<string, CharacterProfessionHolder> StoredProfessions { get; set; }
        public DataHandler(Character character, ICharacterClassBuilder classfactory, IProfessionBuilder professionfactory) : base(character)
        {
            StoredClasses = classfactory.Retrieve();
            StoredProfessions = professionfactory.Retrieve();
        }

    }
}
