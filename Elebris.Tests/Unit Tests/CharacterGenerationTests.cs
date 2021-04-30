using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{

    public class CharacterGenerationTests
    {
        private readonly ITestOutputHelper _output;
        private readonly Character _characterContainer;

        public CharacterGenerationTests(ITestOutputHelper output, CharacterFactory factory)
        {
            _output = output;
            _characterContainer = factory.CreateCharacter();
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
        public void Character_ExternalInteractionHandlerNotNull()
        {
            //Arrange:Prepare test

            //Act: 
            Assert.NotNull(_characterContainer.ExternalInteractionHandler);


            //Assert: "This should be the outcome"
        }

      

    }
}
