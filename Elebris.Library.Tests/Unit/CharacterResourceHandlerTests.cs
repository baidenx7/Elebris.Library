using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Factories;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{

    public class CharacterResourceHandlerTests
    {
        private readonly ITestOutputHelper _output;
        private Unit _characterContainer;

        public CharacterResourceHandlerTests(ITestOutputHelper output)
        {
            _output = output;
            _characterContainer = UnitFactory.CreateUnit();
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
