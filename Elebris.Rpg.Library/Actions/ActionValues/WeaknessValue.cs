﻿using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.Config;

namespace Elebris.Core.Library.Objects
{
    public class WeaknessValue
    {
        public enum WeaknessScale
        {
            //numbers might need to be spaced out... working on that
            //since enums use ints assume these values are /10. they are placeholders and need to be calculated elsewhere but this is approx the damage spread
            Immune = 0,
            Resist = 1,
            Neutral = 2,
            Weak = 4,
            Dire = 6
        }
        public WeaknessValue(float value = 0)
        {
            Value = value;
        }

        public float Value { get; set; }
        public WeaknessScale Resistance
        {
            get
            {
                if (Value >= Constants.DEFAULT_IMMUNE_VALUE) return WeaknessScale.Immune;
                else if (Value >= Constants.DEFAULT_RESIST_VALUE) return WeaknessScale.Resist;
                else if (Value >= Constants.DEFAULT_NEUTRAL_VALUE) return WeaknessScale.Neutral;
                else if (Value >= Constants.DEFAULT_WEAK_VALUE) return WeaknessScale.Weak;
                else return WeaknessScale.Dire;

            }
        }

        public float DamageMultiplier
        {
            get
            {
                int scale = (int)Resistance;
                return scale * Constants.WEAKNESS_MULTIPLER;
            }
        }
    }
}