using Elebris.Rpg.Library.Config;
using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Enforcing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Library.Units.Creation
{
    //internal ?
    public class AttributeSetBuilder : IAttributeSetBuilder
    {
        public Dictionary<string, CharacterStatValue> GenerateClassAttributeSet()
        {
            CharacterAttributes[] arr = Array.Empty<CharacterAttributes>(); //pass no bias arguments
            return GenerateClassAttributeSet(arr);

        }
        public Dictionary<string, CharacterStatValue> GenerateClassAttributeSet(params CharacterAttributes[] classAttributes)
        {
            //Set default values
            Dictionary<CharacterAttributes, int> characterBiasAttributes = new();
            PopulateDictionary(ref characterBiasAttributes, ConstantValues.DEFAULT_BIAS_VALUE);

            //add modifiers by class to values
            GenerateCharacterBias(ref characterBiasAttributes, classAttributes);
            //Take the values, create a biaslist to be randomly selected from
            //then roll until (max) values are assigned
            Dictionary<CharacterAttributes, int> characterAttributes = RollAttributes(characterBiasAttributes);
            Dictionary<string, CharacterStatValue> attributeDict = new();
            foreach (var item in characterAttributes.Keys)
            {
                CharacterStatValue val = new(characterAttributes[item]);
                attributeDict.Add(item.ToString(), val);
            }

            return attributeDict;

        }

        private static void PopulateDictionary(ref Dictionary<CharacterAttributes, int> characterBiasAttributes, int value)
        {
            characterBiasAttributes.Add(CharacterAttributes.Agility, value);
            characterBiasAttributes.Add(CharacterAttributes.Expertise, value);
            characterBiasAttributes.Add(CharacterAttributes.Intelligence, value);
            characterBiasAttributes.Add(CharacterAttributes.Wisdom, value);
            characterBiasAttributes.Add(CharacterAttributes.Strength, value);
            characterBiasAttributes.Add(CharacterAttributes.Constitution, value);
        }

        private void GenerateCharacterBias(ref Dictionary<CharacterAttributes, int> characterBiasAttributes, params CharacterAttributes[] classAttributes)
        {
            //For each matching attribute
            foreach (var charItem in characterBiasAttributes.Keys.ToList())
            {
                foreach (var classItem in classAttributes)
                {
                    if (charItem == classItem)
                    {
                        characterBiasAttributes[charItem] += ConstantValues.DEFAULT_CLASS_BIAS;
                    }
                }
            }
        }

        private Dictionary<CharacterAttributes, int> RollAttributes(Dictionary<CharacterAttributes, int> attributeBias)
        {
            Random rand = new();
            Dictionary<CharacterAttributes, int> attributes = new(); //what does this do

            PopulateDictionary(ref attributes, ConstantValues.DEFAULT_ATTRIBUTE_VALUE);

            CharacterAttributes[] convertedBiasList = GenerateBiasArray(attributeBias);
            while (attributes.Sum(item => item.Value) < ConstantValues.DEFAULT_MAX_TOTAL_VALUE)
            {
                //for each attribute check if the random roll returned value matches, if it does add one to that particular attribute
                int randomRoll = rand.Next(0, convertedBiasList.Length);
                for (int i = 0; i < attributes.Count; i++)
                {
                    if (attributes.ElementAt(i).Key == convertedBiasList[randomRoll])
                    {
                        CharacterAttributes current = convertedBiasList[randomRoll];
                        attributes[current] = attributes[current] + 1 > ConstantValues.DEFAULT_MAX_ATTRIBUTE_VALUE ? ConstantValues.DEFAULT_MAX_ATTRIBUTE_VALUE : attributes[current] + 1;
                        break;
                    }
                }
            }
            return attributes;
        }

        private CharacterAttributes[] GenerateBiasArray(Dictionary<CharacterAttributes, int> biasList)
        {
            List<CharacterAttributes> biasDataList = new();

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
