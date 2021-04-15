using Elebris.Core.Library.Components;
using Elebris.Core.Library.Saving;
using System;

namespace Elebris.Core.Library.CharacterValues.Mutable
{
    /// <summary>
    /// This is a very Elebris-Specific class. 
    /// </summary>
    public class ProgressionValue : ISaveable
    {
        //stored and temporary experience, sanity, Profession Skill

        private float storedExperience, experiencePoints, threshold, fraction; //min and max range
        public float ExperiencePoints { get => experiencePoints; }

        private int level;
        public int Level { get => level; set => level = value; }

        public int GetTotalExperience()
        {
            return (int)ExperiencePoints;
        }
        public event Action onExperienceGained;
        public event Action<int> onLevelGained;


        public void GainExperience(float experience)
        {
            experiencePoints+= experience;
            UpdateStoredValue(experience);
            onExperienceGained();
        }
        public void IncreaseLevel()
        {
            Level++;
            if(onLevelGained != null)onLevelGained(Level);
        }
        public float GetCurrentPoints()
        {
            return ExperiencePoints;
        }
        public float GetStoredPoints()
        {
            return storedExperience;
        }
        public void AlterModifier(float flatThreshold, float fractionalThreshold)
        {
            threshold = flatThreshold;
            fraction = fractionalThreshold;
        }

        public object CaptureState()
        {
            SerializableProgressionData data = new SerializableProgressionData(storedExperience, experiencePoints);

            return data;
        }

        public void RestoreState(object state)
        {
            SerializableProgressionData data = (SerializableProgressionData)state;
            data.currentValue = experiencePoints;
            data.storedValue = storedExperience;
        }

        private void UpdateStoredValue(float value)
        {
            if (value < threshold) return; //you need at least x in order to gain any stored XP
            float current = value / fraction; // you gain a fraction of your current xp as stored
            //some progressionValues may scale between a positive and negative number, and at some point I may need to add a min and max cap (-100 to 100 for sanity as an example)
            storedExperience += current;
        }
    }

}
