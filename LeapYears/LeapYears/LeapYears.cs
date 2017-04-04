using Xunit;

namespace LeapYears
{
    public static class LeapYears
    {
        //A leap year is defined as one that is divisible by 4, but is not otherwise divisible by 100 unless it is also divisible by 400.
        public static bool isLeapYear(int year)
        {
            return year < 0 ? false : year % 4 == 0 ? year % 100 == 0 ? year % 400 == 0 ? true : false : true : false;
        }
    }

    public class LeapYearsTests
    {
        [Fact]
        public void testIsLeapYear_4()
        {
            Assert.True(LeapYears.isLeapYear(4));
        }

        [Fact]
        public void testIsLeapYear_400()
        {
            Assert.True(LeapYears.isLeapYear(400));
        }

        [Fact]
        public void testIsLeapYear_1996()
        {
            Assert.True(LeapYears.isLeapYear(1996));
        }

        [Fact]
        public void testIsLeapYear_2000()
        {
            Assert.True(LeapYears.isLeapYear(2000));
        }

        [Fact]
        public void testIsNotLeapYear_100()
        {
            Assert.False(LeapYears.isLeapYear(100));
        }

        [Fact]
        public void testIsNotLeapYear_2001()
        {
            Assert.False(LeapYears.isLeapYear(2001));
        }
    }
}
