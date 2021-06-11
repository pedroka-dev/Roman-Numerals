
using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanToArabicNumber
    {
        private const string temporaryRoman1Thousands = "O";
        private const string temporaryRoman5Thousands = "P";
        private const string temporaryRoman10Thousands = "Q";

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
                {temporaryRoman1Thousands,1000},
                {temporaryRoman5Thousands,5000},
                {temporaryRoman10Thousands,10000}
             };
        }

        public int Convert()
        {
            var result = 0;

            AddTemporaryNumerals();

            foreach (char letter in RomanNumeral)
            {
                if (RomanArabicPairs.TryGetValue(letter.ToString(), out int value))
                    result += value;
            }

            RemoveTemporaryNumerals();

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

        private void RemoveTemporaryNumerals()
        {
            RomanNumeral = RomanNumeral.Replace(temporaryRoman1Thousands, "Ī");
            RomanNumeral = RomanNumeral.Replace(temporaryRoman5Thousands, "V̄");
            RomanNumeral = RomanNumeral.Replace(temporaryRoman10Thousands, "X̄");
        }

        private void AddTemporaryNumerals()
        {
            RomanNumeral = RomanNumeral.Replace("Ī", temporaryRoman1Thousands);
            RomanNumeral = RomanNumeral.Replace("V̄", temporaryRoman5Thousands);
            RomanNumeral = RomanNumeral.Replace("X̄", temporaryRoman10Thousands);
        }
    }
}
