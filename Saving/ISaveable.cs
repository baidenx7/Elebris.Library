using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Library.Saving
{
    public interface ISaveable
    {
        object CaptureState();
        void RestoreState(object state);
    }
}
