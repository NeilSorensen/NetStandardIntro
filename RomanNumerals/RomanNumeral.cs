using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        private List<Tuple<int, string>> romanTokens = new List<Tuple<int, string>>
        {
            new Tuple<int, string>(50, "L"),
            new Tuple<int, string>(40, "XL"),
            new Tuple<int, string>(10, "X"),
            new Tuple<int, string>(9, "IX"),
            new Tuple<int, string>(5, "V"),
            new Tuple<int, string>(4, "IV"),
            new Tuple<int, string>(1, "I"),
        };

        public string Convert(int value)
        {
            StringBuilder roman = new StringBuilder();
            foreach (var token in romanTokens)
            {
                while (token.Item1 <= value)
                {
                    roman.Append(token.Item2);
                    value -= token.Item1;
                }
            }
            return roman.ToString();
        }
    }
}
