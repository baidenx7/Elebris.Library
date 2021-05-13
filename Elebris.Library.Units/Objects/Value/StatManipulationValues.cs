using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Rpg.Library.Units.Values.Models
{
    //the model by which a value-per-level is calculated
    public class StatManipulationValues
    {

        internal ValueHandler _handler;

        internal StatManipulationValues(ValueHandler handler)
        {
            _handler = handler;

        }


    }
}
