using System;
using System.IO;
using Xunit;

namespace HelloWorld.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4, true)]
        [InlineData(100, false)]
        [InlineData(200, false)]
        [InlineData(400, true)]
        [InlineData(1800, false)]
        [InlineData(1600, true)]
        public void LeapYear_check(int year, bool expected)
        {
            Assert.Equal(expected, Program.IsLeapYear(year));
        }

        [Fact]
        public void Main_prints_welcome_message()
        {
            var writter = new StringWriter();
            Console.SetOut(writter);

            Program.Main(new string[0]);

            Assert.Equal("Enter a name to check if it is a leap year :)", writter.GetStringBuilder().ToString().Trim());
        }



    }
}
