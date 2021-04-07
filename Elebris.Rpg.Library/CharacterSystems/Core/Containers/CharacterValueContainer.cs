using Elebris.Core.Library.CharacterValues.Mutable;
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

    public class CharacterValueContainer
    {
        public CharacterValueContainer()
        {
            DataHandler = new CharacterDataHandler(this);
            TriggerHandler = new CharacterEventAggregator();
            ResourceHandler = new CharacterResourceHandler(this);
            ProgressionHandler = new CharacterProgressionHandler(this);
            BioHandler = new CharacterBioHandler(this);


        }

        public CharacterDataHandler DataHandler { get; set; }
        public CharacterEventAggregator TriggerHandler { get; set; }

        public CharacterResourceHandler ResourceHandler { get; set; }
        public CharacterProgressionHandler ProgressionHandler { get; set; }
        public CharacterBioHandler BioHandler { get; set; }
      


    }
}
