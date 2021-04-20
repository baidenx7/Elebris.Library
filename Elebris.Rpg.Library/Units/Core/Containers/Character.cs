using Elebris.Rpg.Library.Units.Data;
using Elebris.Rpg.Library.Units.Data.Handlers;
using Elebris.Rpg.Library.Units.Equipment;
using Elebris.Rpg.Library.Units.Equipment.Handlers;
using Elebris.Rpg.Library.Units.Progression;
using Elebris.Rpg.Library.Units.Progression.Handlers;
using Elebris.Rpg.Library.Units.Resources;
using Elebris.Rpg.Library.Units.Resources.Handlers;
using Elebris.Rpg.Library.Units.Values.Creation;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Rpg.Library.Unit.Core.Containers
{

    public class Character
    {
        //Create a EnemyConstructorModel and CharacterConstructorModel that replaces all these individual calls?
        public Character(IValueHandlerFactory valueBuilder, IResourceHandlerFactory resourceBuilder, IProgressionHandlerFactory progressionBuilder,
             IDataHandlerFactory dataBuilder, IEquipmentBuilder equipmentBuilder)
        {

            ValueHandler = valueBuilder.ReturnHandler(this);
            //ResourceHandler = resourceBuilder.ReturnHandler(this);
            //ProgressionHandler = progressionBuilder.ReturnHandler(this);
            //DataHandler = dataBuilder.ReturnHandler(this);
            //EquipmentHandler = equipmentBuilder.ReturnHandler(this);

            //UpdateManipulators
        }

        public ICharacterValueHandler ValueHandler { get; set; }
        //public UnitResourceHandler ResourceHandler { get; set; }
        //public UnitProgressionHandler ProgressionHandler { get; set; }
        //public UnitDataHandler DataHandler { get; set; }
        //public UnitEquipmentHandler EquipmentHandler { get; set; }

        //InputResponseHandler controls AI, button/Hotbar use, menu navigation etc. 
    }
}
