using FluentAssertions;
using NameCalculator;
using NUnit.Framework;

namespace NameCalculatorTests
{
    [TestFixture]
    public class NameCalculatorTests
    {
        [Test]
        public void CalculateNameShouldReturnANumber()
        {
            var nameValue = Calculator.CalculateName("ABC", 2);
            nameValue.ShouldBeEquivalentTo(12);
        }

        [Test]
        public void AlphabetLettersShouldMatchTheirPosition()
        {
            Calculator.CalculateName("A", 1).ShouldBeEquivalentTo(1);
            Calculator.CalculateName("B", 1).ShouldBeEquivalentTo(2);
            Calculator.CalculateName("C", 1).ShouldBeEquivalentTo(3);
            Calculator.CalculateName("D", 1).ShouldBeEquivalentTo(4);
            Calculator.CalculateName("E", 1).ShouldBeEquivalentTo(5);
            Calculator.CalculateName("F", 1).ShouldBeEquivalentTo(6);
            Calculator.CalculateName("G", 1).ShouldBeEquivalentTo(7);
            Calculator.CalculateName("H", 1).ShouldBeEquivalentTo(8);
            Calculator.CalculateName("I", 1).ShouldBeEquivalentTo(9);
            Calculator.CalculateName("J", 1).ShouldBeEquivalentTo(10);
            Calculator.CalculateName("K", 1).ShouldBeEquivalentTo(11);
            Calculator.CalculateName("L", 1).ShouldBeEquivalentTo(12);
            Calculator.CalculateName("M", 1).ShouldBeEquivalentTo(13);
            Calculator.CalculateName("N", 1).ShouldBeEquivalentTo(14);
            Calculator.CalculateName("O", 2).ShouldBeEquivalentTo(30);
            Calculator.CalculateName("P", 1).ShouldBeEquivalentTo(16);
            Calculator.CalculateName("Q", 1).ShouldBeEquivalentTo(17);
            Calculator.CalculateName("R", 1).ShouldBeEquivalentTo(18);
            Calculator.CalculateName("S", 1).ShouldBeEquivalentTo(19);
            Calculator.CalculateName("T", 1).ShouldBeEquivalentTo(20);
            Calculator.CalculateName("U", 1).ShouldBeEquivalentTo(21);
            Calculator.CalculateName("V", 1).ShouldBeEquivalentTo(22);
            Calculator.CalculateName("W", 1).ShouldBeEquivalentTo(23);
            Calculator.CalculateName("X", 1).ShouldBeEquivalentTo(24);
            Calculator.CalculateName("Y", 1).ShouldBeEquivalentTo(25);
            Calculator.CalculateName("Z", 1).ShouldBeEquivalentTo(26);
            Calculator.CalculateName("z", 1).ShouldBeEquivalentTo(26);
        }
    }
}
