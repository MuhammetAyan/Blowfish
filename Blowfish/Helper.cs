using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blowfish
{
    public class Helper
    {
        private static Dictionary<char, string> hexbin = new Dictionary<char, string>() {
            { '0',  "0000" },
            { '1',  "0001" },
            { '2',  "0010" },
            { '3',  "0011" },
            { '4',  "0100" },
            { '5',  "0101" },
            { '6',  "0110" },
            { '7',  "0111" },
            { '8',  "1000" },
            { '9',  "1001" },
            { 'A',  "1010" },
            { 'B',  "1011" },
            { 'C',  "1100" },
            { 'D',  "1101" },
            { 'E',  "1110" },
            { 'F',  "1111" },
        };

        private static Dictionary<string, char> binhex = new Dictionary<string, char>() {
            { "0000", '0' },
            { "0001", '1' },
            { "0010", '2' },
            { "0011", '3' },
            { "0100", '4' },
            { "0101", '5' },
            { "0110", '6' },
            { "0111", '7' },
            { "1000", '8' },
            { "1001", '9' },
            { "1010", 'A' },
            { "1011", 'B' },
            { "1100", 'C' },
            { "1101", 'D' },
            { "1110", 'E' },
            { "1111", 'F' },
        };

        public string hexToBin(string hex)
        {
            //return Convert.ToString(Convert.ToInt32(hex, 16), 2);
            string bin = "";
            for (int i = 0; i < hex.Length; i++)
            {
                bin += hexbin[hex[i]];
            }
            return bin;
        }

        public string binToHex(string binary)
        {
            string hex = "";
            for (int i = 0; i < binary.Length; i+=4)
            {
                int length = Math.Min(4, binary.Length - i);
                hex += binhex[binary.Substring(i, length).PadLeft(4, '0')];
            }
            return hex;
        }

        public string xor(string a, string b)
        {
            a = hexToBin(a);
            b = hexToBin(b);
            string ans = "";
            for (int i = 0; i < a.Length; i++)
                ans += (char)(((a[i] - '0') ^ (b[i] - '0')) + '0');
            ans = binToHex(ans);
            return ans;
        }


    }
}
