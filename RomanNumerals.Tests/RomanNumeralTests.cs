using NUnit.Framework;

namespace RomanNumerals.Tests
{
    [TestFixture]
    public class RomanNumeralTests
    {
        [TestCase(1, "I")]  
        [TestCase(2, "II")]  
        [TestCase(3, "III")] 
        [TestCase(4, "IV")] 
        [TestCase(5, "V")]  
        [TestCase(6, "VI")]  
        [TestCase(7, "VII")]  
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(40, "XL")]
        [TestCase(44, "XLIV")]
        [TestCase(50, "L")]
        [TestCase(88, "LXXXVIII")]
        public void NumbersShouldConvert(int value, string expectedRoman)
        {
            var converter = new RomanNumeral();
            string asRoman = converter.Convert(value);
            Assert.That(asRoman, Is.EqualTo(expectedRoman));
        }
    }
}
