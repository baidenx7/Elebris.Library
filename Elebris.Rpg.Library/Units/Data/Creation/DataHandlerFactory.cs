using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Data.Creation;
using Elebris.Rpg.Library.Units.Data.Handlers;
using Elebris.Rpg.Library.Units.UnitClasses.Creation;

namespace Elebris.Rpg.Library.Units.Data
{
    public class DataHandlerFactory : IDataHandlerFactory
    {
        ICharacterClassBuilder _classFactory;
        IProfessionBuilder _progressionFactory;

        public DataHandlerFactory(ICharacterClassBuilder defaultClassFactory, IProfessionBuilder defaultProgressionFactory)
        {
            this._classFactory = defaultClassFactory;
            this._progressionFactory = defaultProgressionFactory;
        }
        public DataHandler ReturnHandler(Character character)
        {
            DataHandler handler = new DataHandler(character, _classFactory, _progressionFactory);
            
            return handler;
        }
      
    }
}
