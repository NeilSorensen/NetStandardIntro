using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StarWars.Tests
{
    [TestFixture]
    public class PersonRepositoryTests
    {
        private PersonRepository _classUnderTest;

        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new PersonRepository("https://swapi.co/api", new JsonApiWrapper());
        }

        [Test]
        public void When_finding_a_real_person()
        {
            var result = _classUnderTest.FindByName("luke");
            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.Name, Is.EqualTo("Luke Skywalker"));
        }

        [Test]
        public void When_finding_a_person_who_is_NOT_in_star_wars()
        {
            var result = _classUnderTest.FindByName("hamlet");
            Assert.That(result, Is.Null);
        }
    }
}
