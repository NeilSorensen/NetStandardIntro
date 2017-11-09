using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    public class Person
    {
        public string Name { get; set; }
        public string BirthYear { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Url { get; set; }

        public int Id
        {
            get
            {
                var identifierStart = Url.LastIndexOf("/", Url.Length - 2) + 1;
                var idString = Url.Substring(identifierStart, (Url.Length - 1) - identifierStart);
                return int.Parse(idString);
            }
        }
    }
}
