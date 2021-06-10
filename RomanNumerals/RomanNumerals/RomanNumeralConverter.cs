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

            romanNumeral = integerToRomanNumeral(arabicNumber);

            return romanNumeral;
        }

        public string integerToRomanNumeral(int number)
        {
            if (number >= 1000)
            {
                return "M";
            }

            else if (number >= 500)
            {
                return "D";
            }

            else if (number >= 100)
            {
                return "C";
            }

            else if (number >= 50)
            {
                return "L";
            }

            else if (number >= 10)
            {
                return "X";
            }

            else if (number >= 5)
            {
                return "V";
            }
            else if(number >= 1)
            {
                return "I";
            }
            else
            {
                return "I";
            }
        }
    }
}
