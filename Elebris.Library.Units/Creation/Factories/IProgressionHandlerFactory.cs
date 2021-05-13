using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Data.Handlers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Library.Units.Creation
{
    public interface IProgressionHandlerFactory
    {
        IProgressionHandler ReturnHandler(IValueHandler valuehandler);
    }

}