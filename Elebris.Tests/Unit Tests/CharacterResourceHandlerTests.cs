
using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{

    public class CharacterResourceHandlerTests
    {
        private readonly ITestOutputHelper _output;
        private readonly Character _characterContainer;

        public CharacterResourceHandlerTests(ITestOutputHelper output, CharacterFactory factory)
        {
            _output = output;
            _characterContainer = factory.CreateCharacter();
        }
        [Fact]
        public void CreateCharacterValues_ResourceBarsFilled()
        {
            ////Arrange:Prepare test

            ////Act: 
            //foreach (var item in _characterContainer.ResourceHandler.StoredResourceBars.Values)
            //{

            //    _output.WriteLine($"attribute value is {item.MaxValue}");
            //}

            //float actual = _characterContainer.ResourceHandler.StoredResourceBars.Count;

            //_output.WriteLine($"total Resourcestats: {actual}");
            ////Assert: "This should be the outcome"
            //Assert.True(actual >= 0);
        }
    }
}
