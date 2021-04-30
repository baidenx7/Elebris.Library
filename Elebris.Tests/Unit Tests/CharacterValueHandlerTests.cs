using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Xunit.Abstractions;

namespace Elebris.Library.Tests
{

    public class CharacterValueHandlerTests
    {

        private readonly ITestOutputHelper _output;
        private readonly Character _character;

        public CharacterValueHandlerTests(ITestOutputHelper output, CharacterFactory factory)
        {
            this._output = output;
            _character = factory.CreateCharacter();
            _output.WriteLine($"Created Character {_character}");
        }
        //[Theory]
        //[InlineData(Parameter)]
        //[InlineData(Parameter)]
        //[InlineData(Parameter)]
        //[InlineData(Parameter)]
        //[InlineData(Parameter)]
        //public void MethodTesting_ExpectedResult(ParameterType value)
        //{
        //    Assert.True(actual);
        //}


        //[Fact]
        //public void MethodTesting_ExpectedResult()
        //{
        //    //Arrange:Prepare test

        //    //Act: 

        //    //Assert: "This should be the outcome"
        //}

    }
}
