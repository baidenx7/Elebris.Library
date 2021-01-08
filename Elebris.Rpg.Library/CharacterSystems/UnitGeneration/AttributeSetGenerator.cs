using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.Config;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    //internal or public?
    public static class AttributeSetGenerator
    {
        public static Dictionary<string, int> GenerateClassAttributeSet()
        {
            Dictionary<string, int> characterBiasAttributes = new Dictionary<string, int>();
            PopulateDictionary(ref characterBiasAttributes, Constants.DEFAULT_BIAS_VALUE);
            Dictionary<string, int> characterAttributes = RollAttributes(characterBiasAttributes);
            Dictionary<string, int> modifiedAttributes = new Dictionary<string, int>();
            foreach (var item in characterAttributes.Keys)
            {
                modifiedAttributes.Add(item, characterAttributes[item]);
            }
            return modifiedAttributes;
        }
        public static Dictionary<string, int> GenerateClassAttributeSet(params string[] classAttributes)
        {
            //Set default values
            Dictionary<string, int> characterBiasAttributes = new Dictionary<string, int>();
            PopulateDictionary(ref characterBiasAttributes, Constants.DEFAULT_BIAS_VALUE);

            //add modifiers by class to values
            GenerateCharacterBias(ref characterBiasAttributes, classAttributes);
            //Take the values, create a biaslist to be randomly selected from
            //then roll until (max) values are assigned
            Dictionary<string, int> characterAttributes = RollAttributes(characterBiasAttributes);
            Dictionary<string, int> modifiedAttributes = new Dictionary<string, int>();
            foreach (var item in characterAttributes.Keys)
            {
                modifiedAttributes.Add(item, characterAttributes[item]);
            }
            return modifiedAttributes;
        }

        private static void PopulateDictionary(ref Dictionary<string, int> characterBiasAttributes, int value)
        {
            characterBiasAttributes.Add(Attributes.Agility.ToString(), value);
            characterBiasAttributes.Add(Attributes.Expertise.ToString(), value);
            characterBiasAttributes.Add(Attributes.Intelligence.ToString(), value);
            characterBiasAttributes.Add(Attributes.Wisdom.ToString(), value);
            characterBiasAttributes.Add(Attributes.Strength.ToString(), value);
            characterBiasAttributes.Add(Attributes.Constitution.ToString(), value);
        }

        private static void GenerateCharacterBias(ref Dictionary<string, int> characterBiasAttributes, params string[] classAttributes)
        {
            //For each matching attribute
            foreach (string charItem in characterBiasAttributes.Keys.ToList())
            {
                foreach (string classItem in classAttributes)
                {
                    if (charItem == classItem)
                    {
                        characterBiasAttributes[charItem] += Constants.DEFAULT_CLASS_BIAS;
                    }
                }
            }
        }

        private static Dictionary<string, int> RollAttributes(Dictionary<string, int> attributeBias)
        {
            Random rand = new Random();
            Dictionary<string, int> attributes = new Dictionary<string, int>(); //what does this do

            PopulateDictionary(ref attributes, Constants.DEFAULT_ATTRIBUTE_VALUE);

            string[] convertedBiasList = GenerateBiasArray(attributeBias);
            while (attributes.Sum(item => item.Value) < Constants.DEFAULT_MAX_TOTAL_VALUE)
            {
                //for each attribute check if the random roll returned value matches, if it does add one to that particular attribute
                int randomRoll = rand.Next(0, convertedBiasList.Length);
                for (int i = 0; i < attributes.Count; i++)
                {
                    if (attributes.ElementAt(i).Key == convertedBiasList[randomRoll])
                    {
                        string current = convertedBiasList[randomRoll];
                        attributes[current] = attributes[current] + 1 > Constants.DEFAULT_MAX_ATTRIBUTE_VALUE ? Constants.DEFAULT_MAX_ATTRIBUTE_VALUE : attributes[current] + 1;
                        break;
                    }
                }
            }
            return attributes;
        }

        private static string[] GenerateBiasArray(Dictionary<string, int> biasList)
        {
            List<string> biasDataList = new List<string>();

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


    public static class StatCreator
    {

    }



}
