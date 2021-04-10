namespace Elebris.Library.Tests
{
    public class CharacterValueFactoryTests
    {
        [Fact]
        public void GenerateClassAttributeSet_ShouldReturnDict()
        {
            //Arrange:Prepare test
            string expected = new Dictionary<string, int>().GetType().ToString();
            //Act: 
            string actual = AttributeSetGenerator.GenerateClassAttributeSet().GetType().ToString();
            //Assert: "This should be the outcome"
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GenerateClassAttributeSet_ShouldReturnAboveMin()
        {
            float min = Constants.DEFAULT_ATTRIBUTE_VALUE;
            var actual = AttributeSetGenerator.GenerateClassAttributeSet();
            foreach (var item in actual.Values)
            {

                Assert.True(item >= min);
            }
        }

        [Fact]
        public void GenerateClassAttributeSet_ShouldReturnBelowMax()
        {
            float max = Constants.DEFAULT_MAX_ATTRIBUTE_VALUE;
            var actual = AttributeSetGenerator.GenerateClassAttributeSet();
            foreach (var item in actual.Values)
            {

                Assert.True(item <= max);
            }


        }
        [Fact]
        public void GenerateClassAttributeSet_ShouldTotalReliably()
        {
            float expected = Constants.DEFAULT_MAX_TOTAL_VALUE;

            var dict = AttributeSetGenerator.GenerateClassAttributeSet();
            float actual = 0;
            foreach (var item in dict.Values)
            {
                actual += item;
            }

            Assert.Equal(expected, actual);
        }
        //[Theory]
        //[InlineData](params)
        //[InlineData](params)
        //[InlineData](params)
        //[InlineData](params)
        //Method(params)}

    }
