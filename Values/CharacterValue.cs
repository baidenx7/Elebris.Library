using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RPG.CharacterValues
{
    public class CharacterValue
    {
        public int unitLevel = 1;
        //stat and attribute can have a majority of their code condensed as they perform very similar functions
        protected float BaseValue;
        protected float AddedValue;
        protected float totalValue;

        protected bool isDirty = true;
        protected float lastBaseValue = float.MinValue;

        public Action<int> ValueModifiedEvent;

        protected readonly List<ValueModifier> valueModifiers;
        public readonly ReadOnlyCollection<ValueModifier> ValueModifiers;
        public CharacterValue()
        {
            valueModifiers = new List<ValueModifier>();
            ValueModifiers = valueModifiers.AsReadOnly();
        }


        protected virtual int CompareModifierOrder(ValueModifier a, ValueModifier b)
        {
            if (a.Order < b.Order)
                return -1;
            else if (a.Order > b.Order)
                return 1;
            return 0; // if (a.Order == b.Order)
        }
        public virtual void AddModifier(ValueModifier mod)
        {
            isDirty = true;
            valueModifiers.Add(mod);

            valueModifiers.Sort(CompareModifierOrder);
        }

        public bool RemoveModifier(ValueModifier mod)
        {
            if (valueModifiers.Remove(mod))
            {

                isDirty = true;
                return true;
            }
            return false;
        }

        public virtual float TotalValue
        {
            //create an event in attributes that is called when the corresponding attribute is "dirty", setting this to dirty
            get
            {
                if (isDirty || lastBaseValue != BaseValue)
                {
                    lastBaseValue = BaseValue;
                    totalValue = CalculateFinalValue();
                    AddedValue = totalValue = BaseValue;
                    isDirty = false;
                    //ValueModifiedEvent(unitLevel);
                }
                return totalValue;
            }
        }
        
        public virtual bool RemoveAllModifiersFromSource(object source)
        {
            bool didRemove = false;

            for (int i = valueModifiers.Count - 1; i >= 0; i--)
            {
                if (valueModifiers[i].Source == source)
                {
                    isDirty = true;
                    didRemove = true;
                    valueModifiers.RemoveAt(i);
                }
            }
            return didRemove;
        }

        public virtual void RemoveModifiersByDuration()
        {//check at the end of each characters round, every tick, depends on the game
            for (int i = 0; i < valueModifiers.Count; i++)
            {
                if (valueModifiers[i].HasDuration)
                {
                    valueModifiers[i].Duration -= 1;
                    if (valueModifiers[i].Duration <= 0)
                    {
                        valueModifiers.RemoveAt(i);
                    }
                }
            }
        }
        public virtual float CalculateFinalValue()
        {
            float finalValue = BaseValue;
            float sumPercentAdd = 0;

            for (int i = 0; i < valueModifiers.Count; i++)
            {
                ValueModifier mod = valueModifiers[i];

                if (mod.Type == ValueModEnum.Flat)
                {
                    finalValue += mod.Value;
                }
                else if (mod.Type == ValueModEnum.PercentAdd) // When we encounter a "PercentAdd" modifier
                {
                    sumPercentAdd += mod.Value; // Start adding together all modifiers of this type

                    // If we're at the end of the list OR the next modifer isn't of this type
                    if (i + 1 >= valueModifiers.Count || valueModifiers[i + 1].Type != ValueModEnum.PercentAdd)
                    {
                        finalValue *= 1 + sumPercentAdd; // Multiply the sum with the "finalValue", like we do for "PercentMult" modifiers
                        sumPercentAdd = 0; // Reset the sum back to 0
                    }
                }
                //last, if there are multiplicative values (which need to be calculated separately from eachother) they are calculated here.
                else if (mod.Type == ValueModEnum.PercentMult)
                {
                    finalValue *= 1 + mod.Value;
                }
            }
            // Rounding gets around dumb float calculation errors (like getting 12.0001f, instead of 12f)
            // 4 significant digits is usually precise enough, but feel free to change this to fit your needs
            return (float)Math.Round(finalValue, 4);
        }

        public virtual void DependantEventCalled(int level)
        {// when this event is called (by a value this depends on being modified) set this to true so it can be recalculated as well
            isDirty = true;
        }
       
    }
}
