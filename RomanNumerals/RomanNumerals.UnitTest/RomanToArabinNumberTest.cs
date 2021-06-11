using NUnit.Framework;

namespace RomanNumerals.UnitTest
{
    class RomanToArabinNumberTest
    {
        [TestCase]
        public void Should_ReturnNumber_1()
        {
            string inputText = "I";
            int expcetedNumber = 1;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_5()
        {
            string inputText = "V";
            int expcetedNumber = 5;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_10()
        {
            string inputText = "X";
            int expcetedNumber = 10;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_50()
        {
            string inputText = "L";
            int expcetedNumber = 50;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_100()
        {
            string inputText = "C";
            int expcetedNumber = 100;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_500()
        {
            string inputText = "D";
            int expcetedNumber = 500;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_M()
        {
            string inputText = "M";
            int expcetedNumber = 1000;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_4()
        {
            string inputText = "IV";
            int expcetedNumber = 4;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_9()
        {
            string inputText = "IX";
            int expcetedNumber = 9;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_90()
        {
            string inputText = "XC";
            int expcetedNumber = 90;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_3()
        {
            string inputText = "III";
            int expcetedNumber = 3;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_30()
        {
            string inputText = "XXX";
            int expcetedNumber = 30;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_300()
        {
            string inputText = "CCC";
            int expcetedNumber = 300;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_3000()
        {
            string inputText = "MMM";
            int expcetedNumber = 3000;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_8()
        {
            string inputText = "VIII";
            int expcetedNumber = 8;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_62()
        {
            string inputText = "LXII";
            int expcetedNumber = 62;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_158()
        {
            string inputText = "CLVIII";
            int expcetedNumber = 158;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_1120()
        {
            string inputText = "MCXX";
            int expcetedNumber = 1120;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_4000()
        {
            string inputText = "ĪV̄";
            int expcetedNumber = 4000;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_5000()
        {
            string inputText = "V̄";
            int expcetedNumber = 5000;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_6000()
        {
            string inputText = "V̄Ī";
            int expcetedNumber = 6000;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_7000()
        {
            string inputText = "V̄ĪĪ";
            int expcetedNumber = 7000;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_8000()
        {
            string inputText = "V̄ĪĪĪ";
            int expcetedNumber = 8000;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_9000()
        {
            string inputText = "ĪX̄";
            int expcetedNumber = 9000;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_10000()
        {
            string inputText = "X̄";
            int expcetedNumber = 10000;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_4002()
        {
            string inputText = "ĪV̄II";
            int expcetedNumber = 4002;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }

        [TestCase]
        public void Should_ReturnNumber_4010()
        {
            string inputText = "ĪV̄X";
            int expcetedNumber = 4010;

            RomanToArabicNumber arabicConverter = new RomanToArabicNumber(inputText);
            int outputNumber = arabicConverter.Convert();

            Assert.AreEqual(expcetedNumber, outputNumber);
        }
    }
}
