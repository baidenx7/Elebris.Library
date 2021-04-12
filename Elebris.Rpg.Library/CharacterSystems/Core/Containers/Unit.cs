using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Components;
using Elebris.Core.Library.Enums;
using Elebris.Core.Library.Objects;
using Elebris.Rpg.Library.CharacterSystems.Core;
using Elebris.Rpg.Library.CharacterSystems.Core.UnitEvents;
using Elebris.Rpg.Library.CharacterSystems.UnitGeneration;
using Elebris.Rpg.Library.StatGeneration;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.CharacterValues
{

    public class Unit
    {
        public Unit(IValueBuilder valueBuilder, IResourceBuilder resourceBuilder, IProgressionBuilder progressionBuilder, 
             IDataBuilder dataBuilder, IEquipmentBuilder equipmentBuilder)
        {
            //AttributeSetFactory.GenerateClassAttributeSet(container);
            //ProgressionGenerator.PopulateProgressionValues(container); //referenced by manipulators, needs to be created early
            //ResourceGenerator.PopulateFactoryResources(container);
            //ValueGenerator.PopulateStatBaseDefault(container);
            //ManipulatorGenerator.PopulateManipulationValues(container);
            ValueHandler = valueBuilder.ReturnHandler(this);
            ResourceHandler = resourceBuilder.ReturnHandler(this);
            ProgressionHandler = progressionBuilder.ReturnHandler(this);
            DataHandler = dataBuilder.ReturnHandler(this);
            EquipmentHandler = equipmentBuilder.ReturnHandler(this);

            //UpdateManipulators
        }

        public UnitValueHandler ValueHandler { get; set; }
        public UnitEventHandler EventHandler { get; set; }
        public UnitResourceHandler ResourceHandler { get; set; }
        public UnitProgressionHandler ProgressionHandler { get; set; }
        public UnitDataHandler DataHandler { get; set; }
        public UnitEquipmentHandler EquipmentHandler { get; set; }
    }
}
