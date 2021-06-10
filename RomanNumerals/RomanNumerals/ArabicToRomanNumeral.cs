
namespace RomanNumerals
{
    public class ArabicToRomanNumeral
    {
        private int ArabicNumber;

        public ArabicToRomanNumeral(int arabicNumber)
        {
            this.ArabicNumber = arabicNumber;
        }

        public string Convert()
        {
            if (ArabicNumber >= 4000)
                return ConvertToRomanThousands(ArabicNumber);

            return ConverToRomanNumeral(ArabicNumber);
        }

        private string ConvertToRomanThousands(int number)
        {
            if (number >= 10000)
                return "X̄" + ConvertToRomanThousands(number - 10000);

            else if (number >= 9000)
                return "ĪX̄" + ConvertToRomanThousands(number - 9000);

            else if (number >= 5000)
                return "V̄" + ConvertToRomanThousands(number - 5000);

            else if (number >= 4000)
                return "ĪV̄" + ConvertToRomanThousands(number - 4000);

            else if (number >= 1000)
                return "Ī" + ConvertToRomanThousands(number - 1000);

            else
                return ConverToRomanNumeral(number);
        }

        private string ConverToRomanNumeral(int number)
        {
            if (number >= 1000)
                return "M" + ConverToRomanNumeral(number - 1000);

            else if (number >= 900)
                return "CM" + ConverToRomanNumeral(number - 900);

            else if (number >= 500)
                return "D" + ConverToRomanNumeral(number - 500);

            else if (number >= 400)
                return "CD" + ConverToRomanNumeral(number - 400);

            else if (number >= 100)
                return "C" + ConverToRomanNumeral(number - 100);

            else if (number >= 90)
                return "XC" + ConverToRomanNumeral(number - 90);

            else if (number >= 50)
                return "L" + ConverToRomanNumeral(number - 50);

            else if (number >= 40)
                return "XL" + ConverToRomanNumeral(number - 40);

            else if (number >= 10)
                return "X" + ConverToRomanNumeral(number - 10);

            else if (number >= 9)
                return "IX" + ConverToRomanNumeral(number - 9);

            else if (number >= 5)
                return "V" + ConverToRomanNumeral(number - 5);

            else if (number >= 4)
                return "IV" + ConverToRomanNumeral(number - 4);

            else if (number >= 1)
                return "I" + ConverToRomanNumeral(number - 1);

            else
                return "";
        }
    }
}
