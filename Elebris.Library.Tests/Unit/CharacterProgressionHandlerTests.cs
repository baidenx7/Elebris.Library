using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Core.Creation;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{
    public class CharacterProgressionHandlerTests
    {
        private readonly ITestOutputHelper _output;
        private Character _characterContainer;

        public CharacterProgressionHandlerTests(ITestOutputHelper output)
        {
            _output = output;
            _characterContainer = CharacterFactory.CreateUnit();
        }

        [Fact]
        public void CreateCharacterValues_ProgressionValuesFilled()
        {
            //Arrange:Prepare test

            //Act: 

            float actual = _characterContainer.ProgressionHandler.StoredProgressionValues.Count;
            _output.WriteLine($"total Progression stats: {actual}");
            //Assert: "This should be the outcome"
            Assert.True(actual >= 1);
        }
    }
}
