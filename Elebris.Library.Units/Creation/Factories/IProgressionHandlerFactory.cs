using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Data.Handlers;


namespace Elebris.Library.Units.Creation
{
    public interface IProgressionHandlerFactory
    {
        IProgressionHandler ReturnHandler(Character character);
    }

}