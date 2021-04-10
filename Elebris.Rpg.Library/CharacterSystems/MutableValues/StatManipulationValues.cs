using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System;

namespace Elebris.Core.Library.CharacterValues.Mutable
{
    //the model by which a value-per-level is calculated
    public class StatManipulationValues
    {

        internal Character _container;

        internal StatManipulationValues(Character container)
        {
            _container = container;

        }


    }
}
