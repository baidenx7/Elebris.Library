using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Config;
using Elebris.Rpg.Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    //internal ?
    internal static class AttributeSetGenerator
    {
        public static Dictionary<Attributes, StatValue> GenerateClassAttributeSet()
        {
            Attributes[] arr = { }; //pass no bias arguments
           return GenerateClassAttributeSet(arr);

        }
        public static Dictionary<Attributes, StatValue> GenerateClassAttributeSet(params Attributes[] classAttributes)
        {
            //Set default values
            Dictionary<Attributes, int> characterBiasAttributes = new Dictionary<Attributes, int>();
            PopulateDictionary(ref characterBiasAttributes, Constants.DEFAULT_BIAS_VALUE);

            //add modifiers by class to values
            GenerateCharacterBias(ref characterBiasAttributes, classAttributes);
            //Take the values, create a biaslist to be randomly selected from
            //then roll until (max) values are assigned
            Dictionary<Attributes, int> characterAttributes = RollAttributes(characterBiasAttributes);
            Dictionary<Attributes, StatValue> attributeDict = new Dictionary<Attributes, StatValue>();
            foreach (var item in characterAttributes.Keys)
            {
                StatValue val = new StatValue(characterAttributes[item]);
                attributeDict.Add(item, val);
            }

            return attributeDict;

        }

        private static void PopulateDictionary(ref Dictionary<Attributes, int> characterBiasAttributes, int value)
        {
            characterBiasAttributes.Add(Attributes.Agility, value);
            characterBiasAttributes.Add(Attributes.Expertise, value);
            characterBiasAttributes.Add(Attributes.Intelligence, value);
            characterBiasAttributes.Add(Attributes.Wisdom, value);
            characterBiasAttributes.Add(Attributes.Strength, value);
            characterBiasAttributes.Add(Attributes.Constitution, value);
        }

        private static void GenerateCharacterBias(ref Dictionary<Attributes, int> characterBiasAttributes, params Attributes[] classAttributes)
        {
            //For each matching attribute
            foreach (var charItem in characterBiasAttributes.Keys.ToList())
            {
                foreach (var classItem in classAttributes)
                {
                    if (charItem == classItem)
                    {
                        characterBiasAttributes[charItem] += Constants.DEFAULT_CLASS_BIAS;
                    }
                }
            }
        }

        private static Dictionary<Attributes, int> RollAttributes(Dictionary<Attributes, int> attributeBias)
        {
            Random rand = new Random();
            Dictionary<Attributes, int> attributes = new Dictionary<Attributes, int>(); //what does this do

            PopulateDictionary(ref attributes, Constants.DEFAULT_ATTRIBUTE_VALUE);

            Attributes[] convertedBiasList = GenerateBiasArray(attributeBias);
            while (attributes.Sum(item => item.Value) < Constants.DEFAULT_MAX_TOTAL_VALUE)
            {
                //for each attribute check if the random roll returned value matches, if it does add one to that particular attribute
                int randomRoll = rand.Next(0, convertedBiasList.Length);
                for (int i = 0; i < attributes.Count; i++)
                {
                    if (attributes.ElementAt(i).Key == convertedBiasList[randomRoll])
                    {
                        Attributes current = convertedBiasList[randomRoll];
                        attributes[current] = attributes[current] + 1 > Constants.DEFAULT_MAX_ATTRIBUTE_VALUE ? Constants.DEFAULT_MAX_ATTRIBUTE_VALUE : attributes[current] + 1;
                        break;
                    }
                }
            }
            return attributes;
        }

        private static Attributes[] GenerateBiasArray(Dictionary<Attributes, int> biasList)
        {
            List<Attributes> biasDataList = new List<Attributes>();

            if (biasList != null)
            {
                for (int i = 0; i < biasList.Count; i++)//for each "Attribute slot"
                {
                    for (int j = 0; j < biasList.ElementAt(i).Value; j++)// add a number of AttributeData values to a list, typically totaling around 100  by the end
                    {
                        biasDataList.Add(biasList.ElementAt(i).Key);
                    }
                }
            }
            //returns a large list filled with different enum values
            return biasDataList.ToArray();
        }

    }



}
