using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private List<Rule> _rules;

        public FizzBuzz()
        {
            _rules = new List<Rule>
            {
                new Rule(x => x % 3 == 0, "Fizz"),
                new Rule(x => x % 5 == 0, "Buzz")
            };
        }

        public FizzBuzz(List<Rule> list)
        {
            _rules = list;
        }

        public string Translate(int input)
        {
            string result = "";
            foreach (var rule in _rules)
            {
                if (rule.MatchChecker(input)) result += rule.Word;
            }

            if (string.IsNullOrEmpty(result))
            {
                result = input.ToString();
            }
            return result;
        }
    }
}
