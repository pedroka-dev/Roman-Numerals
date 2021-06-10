using NUnit.Framework;

namespace RomanNumerals.UnitTest
{
    public class Tests
    {
        [TestCase]
        public void Should_ReturnNumeral_I()
        {
            int inputNumber = 1;
            string expectedText = "I";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_V()
        {
            int inputNumber = 5;
            string expectedText = "V";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_X()
        {
            int inputNumber = 10;
            string expectedText = "X";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_L()
        {
            int inputNumber = 50;
            string expectedText = "L";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_C()
        {
            int inputNumber = 100;
            string expectedText = "C";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_D()
        {
            int inputNumber = 500;
            string expectedText = "D";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_M()
        {
            int inputNumber = 1000;
            string expectedText = "M";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_IV()
        {
            int inputNumber = 4;
            string expectedText = "IV";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_IX()
        {
            int inputNumber = 9;
            string expectedText = "IX";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_XC()
        {
            int inputNumber = 90;
            string expectedText = "XC";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_III()
        {
            int inputNumber = 3;
            string expectedText = "III";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_XXX()
        {
            int inputNumber = 30;
            string expectedText = "XXX";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_CCC()
        {
            int inputNumber = 300;
            string expectedText = "CCC";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_MMM()
        {
            int inputNumber = 3000;
            string expectedText = "MMM";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_VIII()
        {
            int inputNumber = 8;
            string expectedText = "VIII";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_LXII()
        {
            int inputNumber = 62;
            string expectedText = "LXII";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_CLVIII()
        {
            int inputNumber = 158;
            string expectedText = "CLVIII";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }

        [TestCase]
        public void Should_ReturnNumeral_MCXX()
        {
            int inputNumber = 1120;
            string expectedText = "MCXX";

            RomanNumeralConverter romanConverter = new RomanNumeralConverter(inputNumber);
            string outputText = romanConverter.Convert();

            Assert.AreEqual(expectedText, outputText);
        }
    }
}