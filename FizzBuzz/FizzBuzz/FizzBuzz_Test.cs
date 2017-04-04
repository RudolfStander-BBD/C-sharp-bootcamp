using System;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class FizzBuzz_Test
    {
        private string result;

        [TestFixtureTearDown]
        public void SetUp()
        {
            result = @"1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 
                    16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 
                    31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 
                    46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 
                    61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz";
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            result = null;
        }

        [Test]
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(60, "FizzBuzz")]
        [TestCase(64, "64")]
        public void testNumber(int num, string aResult)
        {
            var returnedResult = FizzBuzz.getFizzBuzz(num);
            Assert.That(returnedResult == aResult);
        }

        [Test]
        [TestCase(200)]
        [TestCase(-30)]
        [TestCase(71)]
        [TestCase(0)]
        public void canThrowException(int? num)
        {
            var exceptionHandled = Assert.Throws<InvalidOperationException>(() => FizzBuzz.getFizzBuzz(Convert.ToInt32(num)));


        }
    }
}
