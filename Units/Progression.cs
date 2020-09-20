using System.Collections.Generic;
using UnityEngine;

namespace RPG.Unit
{
    [CreateAssetMenu(fileName = "Progression", menuName = "Stats/New Progression", order = 0)]
    public class Progression : ScriptableObject
    {
        public int requiredExperienceBase = 100;
        public float scalingExperienceMultiplier = 0;
        public int additiveExperience = 0;// 

        public int maxLevel = 20;

        public List<int> experienceTable;
        //initialize here, reference from characters. make sure they DONT overlap in any way

        public void PopulateTable()
        {
            experienceTable.Clear();//cleared between sessions
            experienceTable.Add(requiredExperienceBase);
            for (int i = 1; i < maxLevel; i++)
            {
                experienceTable.Add(RequiredExperience(experienceTable[i-1],i));
            }
        }

        private int RequiredExperience(int previousValue, int currentLevel)
        {
            float finalValue = previousValue;
            if (additiveExperience > 0)
            {
                finalValue += additiveExperience;
            }
            if (scalingExperienceMultiplier > 0)
            {
                finalValue *= scalingExperienceMultiplier;
            }


            return  (int)finalValue;
        }
    }


}