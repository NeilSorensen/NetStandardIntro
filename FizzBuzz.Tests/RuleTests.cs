using System;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    class RuleTests
    {
        [Test]
        public void RulesShouldDeserialize()
        {
            var random = new Random();
            int number = random.Next(2, 100);

            var word = Guid.NewGuid().ToString("N");
            var rule = Rule.Parse($"{number}=>{word}");
            Assert.That(rule.Word, Is.EqualTo(word));
            Assert.That(rule.MatchChecker(number), Is.True);
            Assert.That(rule.MatchChecker(number*2), Is.True);
            Assert.That(rule.MatchChecker(number+1), Is.False);
        }
    }
}
