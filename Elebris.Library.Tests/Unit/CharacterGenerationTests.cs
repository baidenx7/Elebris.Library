using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Core.Creation;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{

    public class CharacterGenerationTests
    {
        private readonly ITestOutputHelper _output;
        private Character _characterContainer;

        public CharacterGenerationTests(ITestOutputHelper output)
        {
            _output = output;
            _characterContainer = CharacterFactory.CreateUnit();
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
