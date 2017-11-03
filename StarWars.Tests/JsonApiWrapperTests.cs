using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StarWars.Tests
{
    [TestFixture]
    class JsonApiWrapperTests
    {
        [Test]
        public void SimpleGetTest()
        {
            var url = "https://swapi.co/api/people/1";
            var apiWrapper = new JsonApiWrapper();

            var person = apiWrapper.Get<Person>(url);

            Assert.That(person.Name, Is.EqualTo("Luke Skywalker"));
            Assert.That(person.Id, Is.EqualTo(1));
        }
    }
}
