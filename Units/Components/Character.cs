using System.Text;

namespace Elebris.Library.Units
{
    public class Character
    {
        private CharacterResourceSystem characterResources = null;
        private CharacterGear characterGear = null;
        private Experience characterExperience = null;

        public CharacterResourceSystem CharacterResources { get => characterResources; set => characterResources = value; }
        public CharacterGear CharacterGear { get => characterGear; set => characterGear = value; }
        public Experience CharacterExperience { get => characterExperience; set => characterExperience = value; }
    }

}
