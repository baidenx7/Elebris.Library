
using System;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Library.Calculations
{
        public static class AttributeHandler
    {
        private static float DEFAULT_ATTRIBUTE_VALUE = 6;
        private static float MAX_TOTAL_VALUE = 60;
        private static float MAX_ATTRIBUTE_VALUE = 15; //May also have this change

        private static float DEFAULT_BIAS_VALUE = 12;
        private static float DEFAULT_CLASS_BIAS = 9;


        public static List<AttributeObject> GenerateAttributes(HeroClassContainer heroClasses)
        {
            //attributeObjectList.Clear();
            //biasList.Clear();
            InitialiseStats();
            InititalizeClassBias(heroClasses);
            //TODO: pass in rarity to change default value and max value
            return RollAttributeSet();
        }
        public static void InitialiseStats()
        {
            foreach (AttributeData item in attributeContainer.ValueDataArray)
            {
                attributeObjectList.Add(new AttributeObject(item, DEFAULT_ATTRIBUTE_VALUE));//create items for each attribute from a container
            }

            foreach (AttributeData item in attributeContainer.ValueDataArray)
            {
                biasList.Add(new AttributeObject(item, DEFAULT_BIAS_VALUE));// do the same for the bias list
            }
        }
        private void InititalizeClassBias(HeroClassContainer heroClasses)
        {
            AddToClassAttributes(heroClasses.classOne.primaryAttribute);
            AddToClassAttributes(heroClasses.classTwo.primaryAttribute);
            AddToClassAttributes(heroClasses.classThree.primaryAttribute);

        }

        public static void AddToClassAttributes(AttributeData classPrimaryAttribute)
        {
            for (int i = 0; i < biasList.Count; i++)
            {
                if (biasList[i].attributeType == classPrimaryAttribute)
                {
                    biasList[i].attributeValue += DEFAULT_CLASS_BIAS;

                    break;
                }
            }
        }
        public static List<AttributeObject> RollAttributeSet()
        {
            AttributeData[] convertedBiasList = GenerateBiasArray();//Converts object to Data since we only need type
            //Attempting to deal out Attribute points until the total value of all stats combined is
            //equal to the total value allowed.
            while (attributeObjectList.Sum(item => item.attributeValue) < MAX_TOTAL_VALUE)
            {
                int randomRoll = UnityEngine.Random.Range(0, convertedBiasList.Length);

                for (int i = 0; i < attributeObjectList.Count; i++)
                {
                    if (attributeObjectList[i].attributeType == convertedBiasList[randomRoll])
                    {
                        IncreaseStatValue(ref attributeObjectList[i].attributeValue);
                        break;
                    }
                }

            }

            return new List<AttributeObject>(attributeObjectList);
        }
        public static AttributeData[] GenerateBiasArray()
        {
            List<AttributeData> biasDataList = new List<AttributeData>();

            foreach (AttributeObject item in biasList)
            {
                biasDataList.Add(item.attributeType);
            }
            if (biasList != null)
            {
                for (int i = 0; i < biasList.Count; i++)//for each "Attribute slot"
                {
                    for (int j = 0; j < biasList[i].attributeValue; j++)// add a number of AttributeData values to a list, typically totaling around 100  by the end
                    {
                        biasDataList.Add(biasList[i].attributeType);
                    }
                }
            }
            return biasDataList.ToArray();
        }
        public static void IncreaseStatValue(ref float attributeValue)
        {
            attributeValue = attributeValue + 1 > MAX_ATTRIBUTE_VALUE ? MAX_ATTRIBUTE_VALUE : attributeValue + 1;

            /* The code above is effectivly the same as this, I just find it tidier. 

        if(stat + 1 > MAX_STAT_VALUE) 
        {
            stat = MAX_STAT_VALUE;
        } 
        else
        {
            stat += 1;
        }

        */
        }

    }

}

