using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Components;
using Elebris.Core.Library.Enums;
using Elebris.Core.Library.Objects;
using Elebris.Rpg.Library.CharacterSystems.Core;
using Elebris.Rpg.Library.CharacterSystems.Core.UnitEvents;
using Elebris.Rpg.Library.StatGeneration;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.CharacterValues
{

    public class Character
    {
        public Character()
        {
            //Should my factories be directly hooked up here?
            ValueHandler = new CharacterValueHandler(this);
            EventHandler = new CharacterEventAggregator();
            ResourceHandler = new CharacterResourceHandler(this);
            ProgressionHandler = new CharacterProgressionHandler(this);
            DataHandler = new CharacterDataHandler(this);
            GearHandler = new CharacterGearHandler(this);

            //UpdateManipulators
        }

        public CharacterValueHandler ValueHandler { get; set; }
        public CharacterEventAggregator EventHandler { get; set; }
        public CharacterResourceHandler ResourceHandler { get; set; }
        public CharacterProgressionHandler ProgressionHandler { get; set; }
        public CharacterDataHandler DataHandler { get; set; }
        public CharacterGearHandler GearHandler { get; set; }
    }
}
