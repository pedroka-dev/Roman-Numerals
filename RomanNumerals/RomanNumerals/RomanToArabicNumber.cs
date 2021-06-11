
using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanToArabicNumber
    {
        private string RomanNumeral;
        private Dictionary<string, int> RomanArabicPairs;

        public RomanToArabicNumber(string romanNumeral)
        {
            RomanNumeral = romanNumeral;
            RomanArabicPairs = new Dictionary<string, int>
            {
                {"I",1},
                {"V",5},
                {"X",10},
                {"L",50},
                {"C",100},
                {"D",500},
                {"M",1000},
                {"Ī",1000},
                {"V̄",5000},
                {"X̄",10000}
             };
        }

        public int Convert()
        {
            var result = 0;

            foreach (var letter in RomanNumeral)
            {
                if(RomanArabicPairs.TryGetValue(letter.ToString(), out int value))
                result += value;
            }

            if (RomanNumeral.Contains("IV") || RomanNumeral.Contains("IX"))
                result -= 2;

            if (RomanNumeral.Contains("XL") || RomanNumeral.Contains("XC"))
                result -= 20;

            if (RomanNumeral.Contains("CD") || RomanNumeral.Contains("CM"))
                result -= 200;

            if (RomanNumeral.Contains("ĪV̄") || RomanNumeral.Contains("ĪX̄"))
                result -= 2000;


                return result;
        }
    }
}
