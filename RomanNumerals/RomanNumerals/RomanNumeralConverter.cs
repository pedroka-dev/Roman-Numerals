using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        private int arabicNumber;

        public RomanNumeralConverter(int arabicNumber)
        {
            this.arabicNumber = arabicNumber;
        }

        public string Convert()
        {
            string romanNumeral = "";

            if (arabicNumber >= 4000)
                romanNumeral = IntegerToRomanNumeralThousands(arabicNumber);

            else
                romanNumeral = IntegerToRomanNumeral(arabicNumber);

            return romanNumeral;
        }


        public string IntegerToRomanNumeralThousands(int number)
        {
            if (number >= 10000)
                return "X̄" + IntegerToRomanNumeralThousands(number - 10000);

            else if (number >= 9000)
                return "ĪX̄" + IntegerToRomanNumeralThousands(number - 9000);

            else if (number >= 5000)
                return "V̄" + IntegerToRomanNumeralThousands(number - 5000);

            else if (number >= 4000)
                return "ĪV̄" + IntegerToRomanNumeralThousands(number - 4000);

            else if (number >= 1000)
                return "Ī" + IntegerToRomanNumeralThousands(number - 1000);

            else
                return IntegerToRomanNumeral(number);
        }

        public string IntegerToRomanNumeral(int number)
        {
            if (number >= 1000)
                return "M" + IntegerToRomanNumeral(number - 1000);

            else if (number >= 900)
                return "CM" + IntegerToRomanNumeral(number - 900);

            else if (number >= 500)
                return "D" + IntegerToRomanNumeral(number - 500);

            else if (number >= 400)
                return "CD" + IntegerToRomanNumeral(number - 400);

            else if (number >= 100)
                return "C" + IntegerToRomanNumeral(number - 100);

            else if (number >= 90)
                return "XC" + IntegerToRomanNumeral(number - 90);

            else if (number >= 50)
                return "L" + IntegerToRomanNumeral(number - 50);

            else if (number >= 40)
                return "XL" + IntegerToRomanNumeral(number - 40);

            else if (number >= 10)
                return "X" + IntegerToRomanNumeral(number - 10);

            else if (number >= 9)
                return "IX" + IntegerToRomanNumeral(number - 9);

            else if (number >= 5)
                return "V" + IntegerToRomanNumeral(number - 5);

            else if (number >= 4)
                return "IV" + IntegerToRomanNumeral(number - 4);

            else if (number >= 1)
                return "I" + IntegerToRomanNumeral(number - 1);

            else
                return "";
        }
    }
}
