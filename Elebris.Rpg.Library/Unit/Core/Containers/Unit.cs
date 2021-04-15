using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Components;
using Elebris.Rpg.Library.CharacterSystems.Core;
using Elebris.Rpg.Library.CharacterSystems.UnitGeneration;

namespace Elebris.Rpg.Library.CharacterValues
{

    public class Unit
    {
        //Create a EnemyConstructorModel and CharacterConstructorModel that replaces all these individual calls?
        public Unit(IValueBuilder valueBuilder, IResourceBuilder resourceBuilder, IProgressionBuilder progressionBuilder, 
             IDataBuilder dataBuilder, IEquipmentBuilder equipmentBuilder)
        {
          
            ValueHandler = valueBuilder.ReturnHandler(this);
            ResourceHandler = resourceBuilder.ReturnHandler(this);
            ProgressionHandler = progressionBuilder.ReturnHandler(this);
            DataHandler = dataBuilder.ReturnHandler(this);
            EquipmentHandler = equipmentBuilder.ReturnHandler(this);

            //UpdateManipulators
        }

        public UnitValueHandler ValueHandler { get; set; }
        public UnitResourceHandler ResourceHandler { get; set; }
        public UnitProgressionHandler ProgressionHandler { get; set; }
        public UnitDataHandler DataHandler { get; set; }
        public UnitEquipmentHandler EquipmentHandler { get; set; }
    }
}
