using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class ClassicFizzBuzzTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void BasicNumbersShouldReturn(int input, string expectedOutput)
        {
            var buzzer = new FizzBuzz();
            var result = buzzer.Translate(input);
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void MultiplesOfThreeShouldFizz(int input)
        {
            var buzzer = new FizzBuzz();
            var result = buzzer.Translate(input);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void MultiplesOfFiveShouldFizz(int input)
        {
            var buzzer = new FizzBuzz();
            var result = buzzer.Translate(input);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        public void MultiplesOfBothThreeAndFiveShouldFizzBuzz(int input)
        {
            var buzzer = new FizzBuzz();
            var result = buzzer.Translate(input);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
    }
}
