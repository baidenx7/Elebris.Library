using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Rpg.Library.Units.Values.Models
{
    //the model by which a value-per-level is calculated
    public class StatManipulationValues
    {

        internal CharacterValueHandler _handler;

        internal StatManipulationValues(CharacterValueHandler handler)
        {
            _handler = handler;

        }


    }
}
