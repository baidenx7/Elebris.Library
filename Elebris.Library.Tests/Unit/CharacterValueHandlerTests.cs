
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Config;
using Elebris.Rpg.Library.Enums;
using Elebris.Rpg.Library.Factories;
using Elebris.UnitCreation.Library.StatGeneration;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{
   
    public class CharacterValueHandlerTests
    {

        private readonly ITestOutputHelper _output;
        private Unit _character;

        public CharacterValueHandlerTests(ITestOutputHelper output)
        {
            this._output = output;
            _character = UnitFactory.CreateUnit();
            _output.WriteLine($"Created Character {_character}");
        }
        [Theory]
        [InlineData(Attributes.Agility)]
        [InlineData(Attributes.Expertise)]
        [InlineData(Attributes.Strength)]
        [InlineData(Attributes.Constitution)]
        [InlineData(Attributes.Wisdom)]
        [InlineData(Attributes.Intelligence)]
        public void RetrieveAttributes_ShouldReturnTrue(Attributes attribute)
        {
            bool actual = _character.ValueHandler.StoredAttributes.ContainsKey(attribute);
            Assert.True(actual);
        }
        [Theory]
        [InlineData(Attributes.None)]
        public void RetrieveAttributes_ShouldReturnFalse(Attributes attribute)
        {
            bool actual = _character.ValueHandler.StoredAttributes.ContainsKey(attribute);
            Assert.False(actual);
        }

        [Fact]
        public void CreateCharacterValues_ShouldReturnCount()
        {
            //Arrange:Prepare test

            //Act: 

            float actual = _character.ValueHandler.StoredStats.Count;

            _output.WriteLine($"total stats: {actual}");
            //Assert: "This should be the outcome"
            Assert.True(actual > 0);
        }
        [Theory]
        [InlineData(Stats.MoveSpeed)]
        [InlineData(Stats.MaxSummonCapacity)]
        [InlineData(Stats.AttackSpeed)]
        public void RetrieveStats_ShouldReturnFloat(Stats stat)
        {
            bool actual = _character.ValueHandler.StoredStats.ContainsKey(stat);
            Assert.True(actual);
        }
        [Theory]
        [InlineData(Stats.AttackSpeed, 1)]
        [InlineData(Stats.MoveSpeed, 3)]
        public void CreateCharacterValues_ReturnSampleStat(Stats stat, float expected)
        {
            //Arrange:Prepare test

            //Act: 

            float actual = _character.ValueHandler.RetrieveValue(stat);
            _output.WriteLine($"value of {stat} is {actual}");
            //Assert: "This should be the outcome"
            Assert.True(actual >= expected);
        }
        [Fact]
        public void CreateCharacterValues_ManipulationValuesFilled()
        {
            //Arrange:Prepare test

            //Act: 
            float actual = _character.ValueHandler.StoredManipulationValues.Count;

            _output.WriteLine($"Manipulators: {actual}");
            //Assert: "This should be the outcome"
            Assert.True(actual >= 1);
        }
    }
}
