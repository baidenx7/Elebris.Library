using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.Enums
{
    public enum TriggerEventType
    {
        ResourceEmpty,
        ResourceFull,
        ResourceIncreased,
        ResourceReduced,

        CombatEntered,
        CombatExited,

        LevelUp,
    }
}
