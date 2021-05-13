using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Rpg.Library.Units.Core.Handlers
{
    public class ValueHandlerInteractor
    {
        internal readonly IValueHandler _valuehandler;

        public ValueHandlerInteractor(IValueHandler valuehandler)
        {
            _valuehandler = valuehandler;
        }
    }
}
