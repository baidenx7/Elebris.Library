using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.Units.Actions.Models;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Combat.Creation
{
    public interface IDamageModelBuilder
    {
        List< DamageModel> Retrieve();
    }
}