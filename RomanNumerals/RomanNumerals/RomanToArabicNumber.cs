
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
                {"M",100}
             };
        }

        public int Convert()
        {
            if (RomanArabicPairs.TryGetValue(RomanNumeral, out int value))
                return value;

            return 0;
        }
    }
}
