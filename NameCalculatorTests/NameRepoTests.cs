using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using NameCalculator;
using NUnit.Framework;
namespace NameCalculatorTests
{
    [TestFixture]
    public class NameRepoTests
    {
        [TearDown]
        public void TearDown()
        {
            File.Delete("test.txt");
        }

        [Test]
        public void NameRepoShouldReturnAList()
        {
            //Arrange
            string lines = "JOHN,DILBERT,HAROLD";
            File.WriteAllText("test.txt", lines);
            
            //Act
            List<string> names = NameRepo.ReadNameList("test.txt");
            
            //Assert
            names.Should().NotBeNull();
            names.Should().HaveCount(3);
            names[0].Should().Be("JOHN");
            names[1].Should().Be("DILBERT");
            names[2].Should().Be("HAROLD");
        }
    }
}
