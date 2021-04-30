using Elebris.Database.Manager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Elebris.Tests.Unit_Tests
{
    public class DatabaseManagerTests
    {
        private readonly ITestOutputHelper _output;

        public DatabaseManagerTests(ITestOutputHelper output)
        {
            _output = output;
        }


        [Fact]
        public void DataBaseReturnsStats_AssertTrue()
        {

            DefaultCharacterStatData data = new();
            var models = data.GetAllStatModels();
            _output.WriteLine(models.Count.ToString());
            Assert.True(models.Count > 1);
        }

    }
}
