
using System;
using System.Collections;
using System.Collections.Generic;

namespace RPG.Calculations

{
    //handles all calculations. may need to be split up more effectively later based n relevant use-case
    public static class RPGMath
    {
        public static bool SucceedCheck(float chance, int total = 101)
        {
            
            Random random = new Random();
            return random.Next(0, total) > chance;
        }

        public static float ToPercent(float num)
        {
            return num * 100;
        }

        public static float ToScale(float num)
        {
            return num / 100;
        }

        public static T RetrieveValueFromList<T>(List<T> list, T value) where T : class
        {
            //can be used to retrieve a matching value from the characters stored stats
            foreach (T storedValue in list)
            {
                if (Compare(storedValue, value))
                {
                    return storedValue;
                }
            }
            return null;
        }
        static bool Compare<T>(T x, T y) where T : class
        {
            return x == y;
        }

        public static bool CheckEquality<T>(List<T> x, List<T> y)
        {
            if (x.Count == y.Count)
            {
                foreach (var item in x)
                {
                    if (y.Contains(item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }


}