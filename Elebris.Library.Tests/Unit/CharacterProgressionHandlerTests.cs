using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Factories;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{
    public class CharacterProgressionHandlerTests
    {
        private readonly ITestOutputHelper _output;
        private Unit _characterContainer;

        public CharacterProgressionHandlerTests(ITestOutputHelper output)
        {
            _output = output;
            _characterContainer = UnitFactory.CreateUnit();
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
