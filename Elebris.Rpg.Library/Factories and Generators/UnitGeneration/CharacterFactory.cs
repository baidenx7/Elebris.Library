using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.Rpg.Library.CharacterSystems.UnitGeneration;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Enums;
using Elebris.Rpg.Library.Factories.UnitGeneration;
using Elebris.Rpg.Library.Utils;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.Factories
{
    public static class CharacterFactory
    {
        public static Character CreateCharacter()
        {
            Character container = new Character();
            SetCharacterValues( container);
            return container;

        }
        public static Character CreateCharacter(Guid guid)
        {
            Character container = new Character();
            SetCharacterValues( container, guid);
            return container;
        }

        private static void SetCharacterValues(Character container)
        {
            AttributeGenerator.GenerateClassAttributeSet(container);
            ProgressionGenerator.PopulateProgressionValues(container); //referenced by manipulators, needs to be created early
            ResourceGenerator.PopulateFactoryResources(container);
            ValueGenerator.PopulateStatBaseDefault(container);
            ManipulatorGenerator.PopulateManipulationValues(container);
        }

        private static void SetCharacterValues( Character container, Guid charId)
        {
            //Load Classes
            //Retrieve Attributes and set string attributes back to enums
            //populate stats
            //set gear (to equipped)
        }
      

        //GenerateGear

        //GenerateClasses/ professions

    }
}
