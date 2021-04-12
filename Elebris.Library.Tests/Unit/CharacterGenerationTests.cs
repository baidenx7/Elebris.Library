using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Factories;
using Elebris.Rpg.Library.StatGeneration;
using Elebris.UnitCreation.Library.StatGeneration;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{

    public class CharacterGenerationTests
    {
        private readonly ITestOutputHelper _output;
        private Unit _characterContainer;

        public CharacterGenerationTests(ITestOutputHelper output)
        {
            _output = output;
            _characterContainer = UnitFactory.CreateUnit();
        }

        [Fact]
        public void Character_CharacterNotNull()
        {
            //Arrange:Prepare test

            _output.WriteLine($"characterContainer is {_characterContainer}");
            //Act: 
            Assert.NotNull(_characterContainer);


            //Assert: "This should be the outcome"
        }
        [Fact]
        public void Character_CharacterValueHandlerNotNull()
        {
            //Arrange:Prepare test

            //Act: 
            Assert.NotNull(_characterContainer.ValueHandler);


            //Assert: "This should be the outcome"
        }
        [Fact]
        public void Character_CharacterEventAggregatorNotNull()
        {
            //Arrange:Prepare test

            //Act: 
            Assert.NotNull(_characterContainer.EventHandler);


            //Assert: "This should be the outcome"
        }
        [Fact]
        public void Character_CharacterResourceHandlerNotNull()
        {
            //Arrange:Prepare test

            //Act: 
            Assert.NotNull(_characterContainer.ResourceHandler);


            //Assert: "This should be the outcome"
        }
        
        [Fact]
        public void Character_CharacterProgressionHandlerNotNull()
        {
            //Arrange:Prepare test

            //Act: 
            Assert.NotNull(_characterContainer.ProgressionHandler);


            //Assert: "This should be the outcome"
        }
        [Fact]
        public void Character_CharacterDataHandlerNotNull()
        {
            //Arrange:Prepare test

            //Act: 
            Assert.NotNull(_characterContainer.DataHandler);


            //Assert: "This should be the outcome"
        }
        [Fact]
        public void Character_CharacterGearHandlerNotNull()
        {
            //Arrange:Prepare test

            //Act: 
            Assert.NotNull(_characterContainer.EquipmentHandler);


            //Assert: "This should be the outcome"
        }

    }
}
