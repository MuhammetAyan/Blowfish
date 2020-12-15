using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Blowfish;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("FF", "11111111")]
        [DataRow("F", "1111")]
        [DataRow("8", "1000")]
        [DataRow("0", "0000")]
        [DataRow("F0", "11110000")]
        [DataRow("58", "01011000")]
        [DataRow("B4", "10110100")]
        [DataRow("C9", "11001001")]
        public void hexToBin(string hex, string expected)
        {
            var b = new Blowfish.Class1();
            Assert.AreEqual(b.hexToBin(hex), expected);

        }
        [TestMethod]
        [DataRow("01011000", "58")]
        [DataRow("11", "3")]
        [DataRow("0000", "0")]
        [DataRow("1111", "F")]
        [DataRow("11001001", "C9")]
        public void binToHex(string binary, string expected)
        {
            var b = new Blowfish.Class1();
            Assert.AreEqual(b.binToHex(binary), expected);

        }

        //[TestMethod]
        //[DataRow("data", 0, 4, "data")]
        //[DataRow("data", 0, 5, "data")]
        //public void substring(string source, int start, int length, string expected)
        //{
        //    Assert.AreEqual(source.Substring(start, length), expected);
        //}
    }
}
