using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        [InlineData(9, "IX")]
        [InlineData(40, "XL")]
        [InlineData(90, "XC")]
        [InlineData(400, "CD")]
        [InlineData(900, "CM")]
        public void Convert_SubtractedValues_ToRomanEquivalent(int number, string expected)
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

        [Theory]
        [InlineData(6, "VI")]
        [InlineData(11, "XI")]
        public void ShouldConvert_ToCompositeRomanCharacter_When(int number, string expected)
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
        private SortedList<int, string> _convertionMap = new SortedList<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD" },
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        }; 


        public string Convert(int number)
        {
            StringBuilder sb = new StringBuilder();

            while (number > 0)
            {
                KeyValuePair<int, string> numeralMap = _convertionMap.Last(v => v.Key <= number);
                number = number - numeralMap.Key;
                sb.Append(numeralMap.Value);
            }

            //if (number > 5 && number < 9)
            //{
            //    sb.Append("V").Append(_convertionMap[number - 5]);
            //}
            //else if (number > 1 && number <= 3)
            //{
            //    sb.Append("I").Append(Convert(number - 1));
            //}
            //else
            //{
            //    return _convertionMap[number];
            //}

            return sb.ToString();
        }
    }
}