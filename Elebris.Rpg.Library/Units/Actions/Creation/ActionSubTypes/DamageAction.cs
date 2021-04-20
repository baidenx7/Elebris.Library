using Elebris.Core.Library.Enums;
using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.Actions.ActionValues;
using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Actions.Models;
using Elebris.Rpg.Library.Units.Actions.Processing.Calculations;
using Elebris.Rpg.Library.Units.Combat;
using Elebris.Rpg.Library.Units.Values.Enforcing.MutableValues;
using Elebris.Rpg.Library.Units.Values.Models;

namespace Elebris.Actions.Library.Actions.Core
{
    public class DamageAction : ICoreAction
    {
        public float value;

        public StatValue PreparedValue;
        ActionScaleModel calc;
        public Character User { get; set; }

        public DamageAction(ActionScaleModel valueCalculator, DamageType type, ActionSubtype subtype, Elements element, float actionCritChance, float actionMultipler = 0)
        {
            calc = valueCalculator;
            Type = new DamageModel(type, CombatInteractionType.Damage);
            Subtype = subtype;
            Element = element;
            ActionCritChance = new StatValue(actionCritChance);
            ActionCritMultipler = new StatValue(actionMultipler);
        }

        public DamageModel Type { get; set; }
        public ActionSubtype Subtype { get; set; }
        public Elements Element { get; set; }

        public StatValue ActionCritChance { get; set; } //constructed by character using the action + any base from the DamageActionBehaviour
        public StatValue ActionCritMultipler { get; set; } //constructed by character using the action

        public void Execute(Character target)
        {
            value = PreparedValue.TotalValue;
            ActionCalculationController.CalculateDamageAction(target, this);
        }

        public void DefineAction(Character user)
        {
            User = user;
            PreparedValue.BaseValue = calc.ReturnValue(User);
            ActionCritChance.AddModifier(new ValueModifier(user.ValueHandler.RetrieveCritChance(Type), ValueModEnum.Flat));
            ActionCritMultipler.AddModifier(new ValueModifier(user.ValueHandler.RetrieveCritMultiplier(Type), ValueModEnum.Flat));
        }

    }


}

