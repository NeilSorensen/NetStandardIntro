using System;

namespace FizzBuzz
{
    public class Rule
    {
        public Rule(Func<int, bool> rule, string matchingWord)
        {
            Word = matchingWord;
            MatchChecker = rule;
        }
        public Func<int, bool> MatchChecker { get; }
        public string Word { get; }

        public static Rule Parse(string serialized)
        {
            var parts = serialized.Split(new[] {"=>", ","}, StringSplitOptions.RemoveEmptyEntries);
            var factor = int.Parse(parts[0]);
            return new Rule(x => x % factor == 0 , parts[1]);
        }
    }
}