using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System;

namespace Elebris.Core.Library.CharacterValues.Mutable
{
    //the model by which a value-per-level is calculated
    public class StatManipulationValues
    {

        internal CharacterValueContainer _container;

        internal StatManipulationValues(CharacterValueContainer container)
        {
            _container = container;

        }


    }
}
