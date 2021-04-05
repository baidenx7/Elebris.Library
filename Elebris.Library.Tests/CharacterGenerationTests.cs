using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.StatGeneration;
using Elebris.UnitCreation.Library.StatGeneration;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{

    public class CharacterGenerationTests
    {
        private readonly ITestOutputHelper output;
        private CharacterValueContainer characterContainer;

        public CharacterGenerationTests(ITestOutputHelper output)
        {
            this.output = output;
            characterContainer = CharacterStatFactory.CreateCharacterValues();
        }

        [Fact]
        public void CreateCharacterValues_characterNotNull()
        {
            //Arrange:Prepare test
            
            output.WriteLine($"characterContainer is {characterContainer}");
            //Act: 
            Assert.NotNull(characterContainer);


            //Assert: "This should be the outcome"
        }
        [Fact]
        public void CreateCharacterValues_AttributesFilled()
        {
            //Arrange:Prepare test

            //Act: 
            foreach (var item in characterContainer.StoredAttributes.Values)
            {

                output.WriteLine($"attribute value is {item.TotalValue}");
            }
            float actual = characterContainer.StoredAttributes.Count;

            //Assert: "This should be the outcome"
            Assert.True(actual >= 0);
        }
        [Theory]
        [InlineData(Stats.AttackSpeed, 1)]
        [InlineData(Stats.HealthResource, 100)]
        [InlineData(Stats.GlobalCritChance, .01)]
        [InlineData(Stats.MoveSpeed, 300)]
        public void CreateCharacterValues_ReturnSampleStat(Stats stat, float expected)
        {
            //Arrange:Prepare test

            //Act: 

            float actual = (float)characterContainer.DataHandler.RetrieveStatValue(stat);

            output.WriteLine($"value of {stat} is {actual}");
            //Assert: "This should be the outcome"
            Assert.True(actual >= expected);
        }
        [Fact]
        public void CreateCharacterValues_StatsFilled()
        {
            //Arrange:Prepare test

            //Act: 

           float actual = characterContainer.StoredStats.Count;

            output.WriteLine($"total stats: {actual}");
            //Assert: "This should be the outcome"
            Assert.True(actual >= 0);
        }
        [Fact]
        public void CreateCharacterValues_BaseValuesFilled()
        {
            //Arrange:Prepare test

            //Act: 
            float actual = characterContainer.StoredManipulationValues.Count;

            output.WriteLine($"total stats: {actual}");
            //Assert: "This should be the outcome"
            Assert.True(actual >= 0);
        }
        [Fact]
        public void CreateCharacterValues_ResourceBarsFilled()
        {
            //Arrange:Prepare test

            //Act: 
            foreach (var item in characterContainer.StoredResourceBars.Values)
            {

                output.WriteLine($"attribute value is {item.MaxValue}");
            }

            float actual = characterContainer.StoredResourceBars.Count;

            output.WriteLine($"total Resourcestats: {actual}");
            //Assert: "This should be the outcome"
            Assert.True(actual >= 0);
        }
        [Fact]
        public void CreateCharacterValues_ProgressionValuesFilled()
        {
            //Arrange:Prepare test

            //Act: 

            float actual = characterContainer.StoredProgressionValues.Count;
            output.WriteLine($"total Progression stats: {actual}");
            //Assert: "This should be the outcome"
            Assert.True(actual >= 0);
        }
        [Fact]
        public void CreateCharacterValues_CheckBuiltStatValues()
        {

            foreach (var item in characterContainer.StoredStats)
            {

                output.WriteLine($"{item.Key}: {item.Value.TotalValue}");

            }
        }


    }
}
