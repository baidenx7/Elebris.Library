using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Data.Handlers;

namespace Elebris.Rpg.Library.Units.Data
{
    public interface IDataHandlerFactory
    {
        DataHandler ReturnHandler(Character character);
    }
}