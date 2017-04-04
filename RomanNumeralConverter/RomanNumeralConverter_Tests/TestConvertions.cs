using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralConverter;

namespace RomanNumeralConverter_Tests
{
    [TestClass]
    public class TestConvertions
    {
        [TestMethod]
        public void TestConvertingValidSingleNumerals()
        {
            Converter converter = new Converter();
            // 1
            Assert.AreEqual(1, converter.convert("I"));
            // 5
            Assert.AreEqual(5, converter.convert("V"));
            // 10
            Assert.AreEqual(10, converter.convert("X"));
            // 50
            Assert.AreEqual(50, converter.convert("L"));
            // 100
            Assert.AreEqual(100, converter.convert("C"));
            // 500
            Assert.AreEqual(500, converter.convert("D"));
            // 1000
            Assert.AreEqual(1000, converter.convert("M"));
        }

        [TestMethod]
        public void TestConvertingSubtractedNumerals()
        {
            Converter converter = new Converter();
            // 4
            Assert.AreEqual(4, converter.convert("IV"));
            // 9
            Assert.AreEqual(9, converter.convert("IX"));
            // 40
            Assert.AreEqual(40, converter.convert("XL"));
            // 90
            Assert.AreEqual(90, converter.convert("XC"));
            // 400
            Assert.AreEqual(400, converter.convert("CD"));
            // 900
            Assert.AreEqual(900, converter.convert("CM"));
        }

        [TestMethod]
        public void TestStringingSubtractionAndAdditionTogether()
        {
            Converter converter = new Converter();
            Assert.AreEqual(14, converter.convert("XIV"));
            Assert.AreEqual(19, converter.convert("XIX"));
            Assert.AreEqual(140, converter.convert("CXL"));
            Assert.AreEqual(190, converter.convert("CXC"));
            Assert.AreEqual(1400, converter.convert("MCD"));
            Assert.AreEqual(1900, converter.convert("MCM"));
        }

        [TestMethod]
        public void TestStringingAdditionTogether()
        {
            Converter converter = new Converter();
            Assert.AreEqual(16, converter.convert("XVI"));
            Assert.AreEqual(30, converter.convert("XXX"));
            Assert.AreEqual(160, converter.convert("CLX"));
            Assert.AreEqual(300, converter.convert("CCC"));
            Assert.AreEqual(1600, converter.convert("MDC"));
            Assert.AreEqual(2100, converter.convert("MMC"));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestInvalidNumeral()
        {
            Converter converter = new Converter();
            converter.convert("F");
        }
    }
}
