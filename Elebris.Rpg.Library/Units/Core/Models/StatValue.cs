using Elebris.Rpg.Library.Units.Values.Enforcing.MutableValues;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Elebris.Rpg.Library.Units.Core.Models
{
    /// <summary>
    /// https://forum.unity.com/threads/tutorial-character-stats-aka-attributes-system.504095/
    /// will this class bieing serializable ina  DLL allow Unity to also see it in the inspector?
    /// </summary>
    [Serializable]
    public class StatValue
    {
        protected float baseValue;
        protected float AddedValue;
        protected float totalValue;

        protected bool isDirty = true;
        protected float lastBaseValue = float.MinValue;


        protected readonly List<ValueModifier> valueModifiers;
        public readonly ReadOnlyCollection<ValueModifier> ValueModifiers;
        public StatValue()
        {
            valueModifiers = new List<ValueModifier>();
            ValueModifiers = valueModifiers.AsReadOnly();
        }
        public StatValue(float baseValue) : this()
        {
            BaseValue = baseValue;
          
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
            get
            {
                if (isDirty || lastBaseValue != BaseValue)
                {
                    lastBaseValue = BaseValue;
                    totalValue = CalculateFinalValue();
                    AddedValue = totalValue = BaseValue;
                    isDirty = false;
                }
                return totalValue;
            }
        }
        //if you are not sure what counts as a base value remember:
        //the only values that should be assigned to base value are (true base, attribute-modified/class-increased(not passives in a class))
        //this should only update when initializing or leveling, not otherwise.
        public float BaseValue { get => baseValue; set => baseValue = value; }

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
        {
            //check at the end of each characters round, every tick, depends on the game
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


    }
}
