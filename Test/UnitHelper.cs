using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Blowfish;

namespace Test
{
    [TestClass]
    public class UnitHelper
    {
        private Helper hlp;
        public UnitHelper()
        {
            hlp = new Helper();
        }

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
            Assert.AreEqual(hlp.hexToBin(hex), expected);

        }
        [TestMethod]
        [DataRow("01011000", "58")]
        [DataRow("11", "3")]
        [DataRow("0000", "0")]
        [DataRow("1111", "F")]
        [DataRow("11001001", "C9")]
        public void binToHex(string binary, string expected)
        {
            Assert.AreEqual(hlp.binToHex(binary), expected);

        }

        [TestMethod]
        [DataRow("1100", "1010", "0110")]
        [DataRow("1", "1", "0")]
        [DataRow("0", "0", "0")]
        [DataRow("0", "1", "1")]
        [DataRow("1", "0", "1")]
        [DataRow("110", "100", "010")]
        public void xor(string a, string b, string expected)
        {
            Assert.AreEqual(hlp.xor(a, b), expected);
        }

    }
}
