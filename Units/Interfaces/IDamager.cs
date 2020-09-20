using System.Collections;
using System.Collections.Generic;

namespace Elebris.Library.Units.Interfaces
{
    public interface IDamager
    {
        void AttackTarget(IDamageable target);
    }
}
