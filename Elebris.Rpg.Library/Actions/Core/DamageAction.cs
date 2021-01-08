using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Enums;
using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.Actions.ActionValues;
using Elebris.Rpg.Library.Actions.Calculations;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Actions.Library.Actions.Core
{
    public class DamageAction : ICoreAction
    {
        public float value;

        public StatValue PreparedValue;
        ActionScaleModel calc;
        public CharacterValueContainer User { get; set; }

        public DamageAction(ActionScaleModel valueCalculator, ActionDamageType type, ActionSubtype subtype, Elements element, float actionCritChance, float actionMultipler = 0)
        {
            calc = valueCalculator;
            Type = type;
            Subtype = subtype;
            Element = element;
            ActionCritChance = new StatValue(actionCritChance);
            ActionCritMultipler = new StatValue(actionMultipler);
        }

        public ActionDamageType Type { get; set; }
        public ActionSubtype Subtype { get; set; }
        public Elements Element { get; set; }

        public StatValue ActionCritChance { get; set; } //constructed by character using the action + any base from the DamageActionBehaviour
        public StatValue ActionCritMultipler { get; set; } //constructed by character using the action
        
        public void Execute(CharacterValueContainer target)
        {
            value = PreparedValue.TotalValue;
            ActionCalculationController.CalculateDamageAction(target, this);
        }

        public void DefineAction(CharacterValueContainer user)
        {
            User = user;
            PreparedValue.BaseValue = calc.ReturnValue(User);
            ActionCritChance.AddModifier(new ValueModifier( user.DataHandler.RetrieveCritChance(Type), ValueModEnum.Flat));
            ActionCritMultipler.AddModifier(new ValueModifier(user.DataHandler.RetrieveCritMultiplier(Type), ValueModEnum.Flat));
        }

    }

    public class HealAction : ICoreAction
    {
        public float value;

        public void Execute(CharacterValueContainer target)
        {

        }
        public void DefineAction(CharacterValueContainer user)
        {

        }
    }
    public class BuffAction : ICoreAction
    {

        public void Execute(CharacterValueContainer target)
        {

        }
        public void DefineAction(CharacterValueContainer user)
        {

        }
    }
    public class DebuffAction : ICoreAction
    {

        public void Execute(CharacterValueContainer target)
        {

        }
        public void DefineAction(CharacterValueContainer user)
        {

        }
    }

    public interface ICoreAction
    {
        void Execute(CharacterValueContainer target);
        void DefineAction(CharacterValueContainer user);
        //check if any passives apply to the particular action-type based on what action type it is, what kind of damage it deals etc


    }


}

