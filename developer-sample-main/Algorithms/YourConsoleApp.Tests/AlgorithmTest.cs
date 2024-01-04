using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        // Test cases for GetFactorial
        [Fact]
        public void CanGetFactorial()
        {
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }

        [Fact]
        public void FactorialOfZeroIsOne()
        {
            Assert.Equal(1, Algorithms.GetFactorial(0));
        }

        [Fact]
        public void FactorialOfOneIsOne()
        {
            Assert.Equal(1, Algorithms.GetFactorial(1));
        }

        [Fact]
        public void ThrowsExceptionForNegativeFactorial()
        {
            Assert.Throws<ArgumentException>(() => Algorithms.GetFactorial(-1));
        }

        // Test cases for FormatSeparators
        [Fact]
        public void CanFormatSeparators()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
        }

        [Fact]
        public void SingleItemFormat()
        {
            Assert.Equal("a", Algorithms.FormatSeparators("a"));
        }

        [Fact]
        public void TwoItemsFormat()
        {
            Assert.Equal("a and b", Algorithms.FormatSeparators("a", "b"));
        }

        [Fact]
        public void EmptyArrayReturnsEmptyString()
        {
            Assert.Equal("", Algorithms.FormatSeparators());
        }

        [Fact]
        public void NullArrayReturnsEmptyString()
        {
            Assert.Equal("", Algorithms.FormatSeparators(null));
        }
    }
}
