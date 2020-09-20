using Elebris.Library.Saving;
using System;

namespace Elebris.Library.Units
{
    public class Experience :ISaveable
    {
        private float experiencePoints = 0;

        public float ExperiencePoints { get => experiencePoints; }

        public int GetTotalExperience()
        {
            return (int)ExperiencePoints;
        }
        public event Action onExperienceGained;

        public void GainExperience(float experience)
        {
            experiencePoints += experience;
            onExperienceGained();
        }

        public float GetPoints()
        {
            return ExperiencePoints;
        }

        public object CaptureState()
        {
            return ExperiencePoints;
        }

        public void RestoreState(object state)
        {
            experiencePoints = (float)state;
        }
    }
    
}