using Elebris.Rpg.Library.Saving;
using Elebris.Rpg.Library.Units.Values.Enforcing.MutableValues;
using System;

namespace Elebris.Library.Units.Objects.Progression
{
    public class ProgressionValue : ISaveable
    {

        private float _storedExperience, _experiencePoints, _threshold, _fraction; //min and max range
        public float ExperiencePoints { get => _experiencePoints; }

        private int _level;
        public int Level { get => _level; set => _level = value; }

        public int GetTotalExperience()
        {
            return (int)ExperiencePoints;
        }
        public event Action OnExperienceGained;
        public event Action<int> OnLevelGained;


        public void GainExperience(float experience)
        {
            _experiencePoints += experience;
            UpdateStoredValue(experience);
            OnExperienceGained();
        }
        public void IncreaseLevel()
        {
            Level++;
            OnLevelGained?.Invoke(Level);
        }
        public float GetCurrentPoints()
        {
            return ExperiencePoints;
        }
        public float GetStoredPoints()
        {
            return _storedExperience;
        }
        public void AlterModifier(float flatThreshold, float fractionalThreshold)
        {
            _threshold = flatThreshold;
            _fraction = fractionalThreshold;
        }

        public object CaptureState()
        {
            SerializableProgressionData data = new(_storedExperience, _experiencePoints);

            return data;
        }

        public void RestoreState(object state)
        {
            SerializableProgressionData data = (SerializableProgressionData)state;
            data.currentValue = _experiencePoints;
            data.storedValue = _storedExperience;
        }

        private void UpdateStoredValue(float value)
        {
            if (value < _threshold) return; //you need at least x in order to gain any stored XP
            float current = value / _fraction; // you gain a fraction of your current xp as stored
            //some progressionValues may scale between a positive and negative number, and at some point I may need to add a min and max cap (-100 to 100 for sanity as an example)
            _storedExperience += current;
        }
    }

}
