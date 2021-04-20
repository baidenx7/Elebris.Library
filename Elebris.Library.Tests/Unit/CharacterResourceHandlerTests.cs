using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Core.Creation;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{

    public class CharacterResourceHandlerTests
    {
        private readonly ITestOutputHelper _output;
        private Character _characterContainer;

        public CharacterResourceHandlerTests(ITestOutputHelper output)
        {
            _output = output;
            _characterContainer = CharacterFactory.CreateUnit();
        }
        [Fact]
        public void CreateCharacterValues_ResourceBarsFilled()
        {
            //Arrange:Prepare test

            //Act: 
            foreach (var item in _characterContainer.ResourceHandler.StoredResourceBars.Values)
            {

                _output.WriteLine($"attribute value is {item.MaxValue}");
            }

            float actual = _characterContainer.ResourceHandler.StoredResourceBars.Count;

            _output.WriteLine($"total Resourcestats: {actual}");
            //Assert: "This should be the outcome"
            Assert.True(actual >= 0);
        }
    }
}
