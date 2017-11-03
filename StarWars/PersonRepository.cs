using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    public class PersonRepository
    {
        private readonly string _baseUrl;
        private readonly JsonApiWrapper _jsonWrapper;

        public PersonRepository(string baseUrl, JsonApiWrapper jsonWrapper)
        {
            _baseUrl = baseUrl;
            _jsonWrapper = jsonWrapper;
        }

        public Person FindByName(string name)
        {
            var url = $"{_baseUrl}/people?search={name}";
            var searchResults = _jsonWrapper.Get<ApiCollection<Person>>(url);
            if (searchResults.Count >= 1)
            {
                return searchResults.Results[0];
            }
            return null;
        }
    }

    class ApiCollection<T>
    {
        public int Count { get; set; }
        public T[] Results { get; set; }
    }
}
