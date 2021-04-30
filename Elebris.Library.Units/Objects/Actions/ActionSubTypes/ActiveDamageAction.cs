using Elebris.Core.Library.Enums;
using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Enforcing.Combat;
using Elebris.Rpg.Library.Actions.ActionValues;
using Elebris.Rpg.Library.Units.Actions.Models;
using Elebris.Rpg.Library.Units.Values.Enforcing.MutableValues;

namespace Elebris.Actions.Library.Actions.Core
{
    public class ActiveDamageAction : IActiveCoreAction
    {
        public ActionScaleValue Damage;
        public DamageType Type { get; set; }
        public ActionSubtype Subtype { get; set; }
        public Elements Element { get; set; }

        public IRetrievableValue ActionCritChance { get; set; } //constructed by character using the action + any base from the DamageActionBehaviour
        public IRetrievableValue ActionCritMultipler { get; set; } //constructed by character using the action

        public void Execute(Character target)
        {
            //value = PreparedValue.TotalValue;
            //ActionCalculationController.CalculateDamageAction(target, this);
        }

        public void DefineAction(Character user)
        {
          
        }

    }


}

