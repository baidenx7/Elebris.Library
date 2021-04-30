using Elebris.Library.Units.Creation;
using Elebris.Rpg.Library.Units.Data.Handlers;
using Elebris.Rpg.Library.Units.Resources.Handlers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Library.Units.Containers
{

    public class Character
    {
        //Create a EnemyConstructorModel and CharacterConstructorModel that replaces all these individual calls?
        public Character(IValueHandlerFactory valuefactory, IExternalInteractionHandlerFactory resourcefactory,
            IProgressionHandlerFactory progressionfactory)
        {

            ValueHandler = valuefactory.ReturnHandler(this);
            ExternalInteractionHandler = resourcefactory.ReturnHandler(this);
            ProgressionHandler = progressionfactory.ReturnHandler(this);

            //UpdateManipulators
        }

        public IExternalInteractionHandler ExternalInteractionHandler { get; set; } //updated by valuehandlers values, but provides additional info
        internal ICharacterValueHandler ValueHandler { get; set; } //contains a focal point for all stat requests
        internal IProgressionHandler ProgressionHandler { get; set; } //updated by valuehandlers values, but provides additional info

        //InputResponseHandler controls AI, button/Hotbar use, menu navigation etc. 
    }
}
