using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    class DatabaseFizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;
        [OneTimeSetUp]
        public void SetUp()
        {
            var factory = new FizzBuzzRuleFactory(@"c:\dev\NetStandardIntro\FizzBuzz.Tests\FizzBuzzRules.db");
            var rules = factory.GetRules();
            _fizzBuzz = new FizzBuzz(rules); 
        }

        [TestCase(1, "1")]
        [TestCase(2, "code")]
        [TestCase(7, "camp")]
        [TestCase(14, "codecamp")]
        public void FizzBuzzShouldWork(int input, string expectedOutput)
        {
            Assert.That(_fizzBuzz.Translate(input), Is.EqualTo(expectedOutput));
        }
    }
}
