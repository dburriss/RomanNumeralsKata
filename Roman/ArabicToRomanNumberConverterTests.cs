using FluentAssertions;
using Xunit;

namespace Roman
{
    public class ArabicToRomanNumberConverterTests
    {
        private ArabicToRomanNumberConverter CreateSut() => 
            new ArabicToRomanNumberConverter();

        [Theory]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        public void ShouldConvert_ToMultipleRomanCharacters(int number, string expected)
        {
            // arrange
            ArabicToRomanNumberConverter sut = CreateSut();

            // act
            string result = sut.Convert(number);

            // assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(4, "IV")]
        public void Convert_Four_ToRomanEquivalent(int number, string expected)
        {
            // arrange
            ArabicToRomanNumberConverter sut = CreateSut();

            // act
            string result = sut.Convert(number);

            // assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        public void ShouldConvert_ToSingleRomanCharacter_When(int number, string expected)
        {
            // arrange
            ArabicToRomanNumberConverter sut = CreateSut();

            // act
            string result = sut.Convert(number);

            // assert
            result.Should().Be(expected);
        }
    }

    public class ArabicToRomanNumberConverter
    {
        public string Convert(int number)
        {
            switch (number)
            {
                case 1000: return "M";
                case 500: return "D";
                case 100: return "C";
                case 50: return "L";
                case 10: return "X";
                case 5: return "V";
                case 1: return "I";
                case 4:return "IV";
            }

            return new string('I', number);
        }
    }
}