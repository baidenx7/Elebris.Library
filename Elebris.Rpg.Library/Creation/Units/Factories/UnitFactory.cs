using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.Rpg.Library.CharacterSystems.UnitGeneration;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Enums;
using Elebris.Rpg.Library.Utils;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.Factories
{

    public class UnitFactory
    {
        public Unit CreateUnit()
        {
            Unit container = new Unit();
            return container;

        }
        public Unit CreateUnit(Guid guid)
        {
            Unit container = new Unit();
            //load rather than create
            return container;
        }


    
    }

}
