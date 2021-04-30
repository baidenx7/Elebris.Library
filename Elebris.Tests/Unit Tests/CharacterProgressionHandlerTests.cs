using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{
    public class CharacterProgressionHandlerTests
    {
        private readonly ITestOutputHelper _output;
        private readonly Character _characterContainer;

        public CharacterProgressionHandlerTests(ITestOutputHelper output, CharacterFactory factory)
        {
            _output = output;
            _characterContainer = factory.CreateCharacter();
        }

        //[Fact]
        //public void CreateCharacterValues_ProgressionValuesFilled()
        //{
        //    //Arrange:Prepare test

        //    //Act: 

        //    float actual = _characterContainer.ProgressionHandler.StoredProgressionValues.Count;
        //    _output.WriteLine($"total Progression stats: {actual}");
        //    //Assert: "This should be the outcome"
        //    Assert.True(actual >= 1);
        //}
    }
}
