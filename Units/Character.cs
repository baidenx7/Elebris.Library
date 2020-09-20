
using Elebris.Library.Calculations;
using RPG.CharacterValues;
using RPG.Events;
using RPG.SceneManagement.Saving;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Library.Units
{
    //move to .Unity
    //Every other component should be pure C#
    [RequireComponent(typeof(CharacterResourceSystem))]
    //[RequireComponent(typeof(TurnBasedCharacter))]

    public class Character : MonoBehaviour, ISaveable, IPointerDownHandler
    {
        [NonSerialized]public int currentLevel;
        public BioContainer bioContainer;
        #region Events
      
        public event EventHandler<ValuesChangedEventArgs> OnAllValuesUpdated;
        [SerializeField] private GameObjectEvent characterObjectEvent;
        //event To be raised On levelup, Or if a Attribute is changed
                    public event Action onLevelUp;
        #endregion
        #region Initializers and ScriptableObjects
        [SerializeField] private int startingLevel = 1;
        [SerializeField] private HeroClassContainer heroClasses = null;
        [SerializeField] private AttributeHandler attributeSet = null;
        [SerializeField] private StatHandler statSet = null;
        [SerializeField] private NamesDataContainer nameContainer = null;
        [SerializeField] private Progression levelProgression = null;
        #endregion
        #region Components
        [SerializeField] private CharacterResourceSystem characterResources= null;
        [SerializeField] private CharacterGear characterGear = null;
        //[SerializeField] private TurnBasedCharacter turnBasedCharacter = null;
        [SerializeField] private Experience characterExperience = null;

        public int GetTotalExperience() => characterExperience.GetTotalExperience();

        public Progression LevelProgression { get => levelProgression; set => levelProgression = value; }
        #endregion

        #region Unity Callbacks
        private void Awake()
        {
            if (characterExperience == null) characterExperience = GetComponent<Experience>();
            if (characterExperience == null) currentLevel = startingLevel;
            else currentLevel = CalculateLevel();

            if (characterResources == null) characterResources = this.GetComponent<CharacterResourceSystem>();

            if (characterGear == null) characterGear = GetComponent<CharacterGear>();

            //if (turnBasedCharacter == null) turnBasedCharacter = GetComponent<TurnBasedCharacter>();
            //load attributes etc through the saveable entity system

        }
        private void OnEnable()
        {
            if (characterExperience != null) characterExperience.onExperienceGained += UpdateLevel;
        }

        private void OnDisable()
        {

            if (characterExperience != null) characterExperience.onExperienceGained -= UpdateLevel;
        }
        public void OnPointerDown(PointerEventData eventData)
        {
            characterObjectEvent.Raise(this.gameObject);


        }
        #endregion
        #region Inititalize
        public void InitializeHero()
        {
            GenerateStatSet(heroClasses);
            bioContainer = new BioContainer(nameContainer.ReturnName());
        }
        private void GenerateStatSet(HeroClassContainer heroClasses)
        {
            characterResources.InititalizeResourceLists();
            characterResources.StoredAttributes = CheckForSave(heroClasses);
            characterResources.StoredStats = statSet.InitializeStatValues(characterResources.StoredAttributes, currentLevel);
            SetStatLevels();
        }

        #endregion
        #region UpdateComponents
        private void SetStatLevels()
        {
            foreach (StatObject statObject in characterResources.StoredStats)
            {
                statObject.unitLevel = currentLevel;//replace this will a get call from the stats themselves? is that really a dependancy issue if stats NEED a character?
            }
        }

        private void UpdateLevel()
        {
            //is this ever actually called? Should experience be received through the resource system?
            int newLevel = CalculateLevel();
            if (newLevel > currentLevel)
            {
                currentLevel = newLevel;
                //LevelUpEffect();
                onLevelUp();
                SetStatLevels();
            }
        }
        private int CalculateLevel()
        {
            Experience experience = GetComponent<Experience>();
            if (experience == null) return startingLevel;

            float currentXP = experience.GetPoints();
            int penultimateLevel = LevelProgression.maxLevel;//highest level you can reach
            for (int level = 1; level <= penultimateLevel; level++)
            {
                float XPToLevelUp = LevelProgression.experienceTable[level];
                if (XPToLevelUp > currentXP)
                {
                    return level;
                }
            }
            //check this carefully, might be off by 1
            return penultimateLevel + 1;
        }
        #endregion

        #region SaveRelated
        private List<AttributeObject> CheckForSave(HeroClassContainer heroClasses)
        {
            //Tp:Do Check for save first
            return attributeSet.GenerateAttributes(heroClasses);
           
            //else
            //{
            //    //load attributes
            //}

            //may switch to bool if I need to separate new characters from saved easily
        }

        private bool SaveFound()
        {
            return false;
        }
        //public void UpdateAllValues()
        //{
        //    //Call when Attributes, Gear, Levels
        //    OnAllValuesUpdated?.Invoke(this, new ValuesChangedEventArgs
        //    {
        //        CharacterAttributes = GetComponent<CharacterResourceSystem>().StoredAttributes,
        //        CharacterStats = GetComponent<CharacterResourceSystem>().StoredStats,
        //    });
        //}

        
        public object CaptureState()
        {
            CharacterSaveData saveData = new CharacterSaveData();
            return saveData;
        }

        public void RestoreState(object state)
        {
            CharacterSaveData saveData = (CharacterSaveData)state;
        }
        #endregion

        //attack targets from turnbasedmanager? receive damage from resourceSystem?
    }
}