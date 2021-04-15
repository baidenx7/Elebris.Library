using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Enums;
using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.Actions.ActionValues;
using Elebris.Rpg.Library.Actions.Calculations;
using Elebris.Rpg.Library.CharacterSystems.Core.Models;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;

namespace Elebris.Actions.Library.Actions.Core
{
    public class DamageAction : ICoreAction
    {
        public float value;

        public StatValue PreparedValue;
        ActionScaleModel calc;
        public Unit User { get; set; }

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
        
        public void Execute(Unit target)
        {
            value = PreparedValue.TotalValue;
            ActionCalculationController.CalculateDamageAction(target, this);
        }

        public void DefineAction(Unit user)
        {
            User = user;
            PreparedValue.BaseValue = calc.ReturnValue(User);
            ActionCritChance.AddModifier(new ValueModifier( user.ValueHandler.RetrieveCritChance(Type), ValueModEnum.Flat));
            ActionCritMultipler.AddModifier(new ValueModifier(user.ValueHandler.RetrieveCritMultiplier(Type), ValueModEnum.Flat));
        }

    }


}

