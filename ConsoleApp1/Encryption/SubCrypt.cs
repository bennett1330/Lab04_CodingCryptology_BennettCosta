using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class SubCrypt : Encryption
    {

        PeriodicTable.PeriodicTable pt = new PeriodicTable.PeriodicTable();
        private int[] GetShifts(int key)
        {
            string strKey = key.ToString();
            int[] wKey = new int[strKey.Length / 2];
            for (double i = 0; i + 1 < strKey.Length; i = i + 2)
            {
                int aN = Convert.ToInt32(String.Concat(strKey[(int)i], strKey[(int)i + 1]));
                wKey[(int)Math.Floor(i / 2)] = (int) Math.Floor(pt.GetElement(aN).AtomicWeight);
            }
            return wKey;
        }

        private string[] GetSplitText(string ciphertext)
        {
            string[] str = new string[ciphertext.Length / 2];
            for (double i = 0; i + 1 < ciphertext.Length; i = i + 2)
                str[(int)Math.Floor(i / 2)] = String.Concat(ciphertext[(int)i], ciphertext[(int)i + 1]);
            return str;
        }

        private string EncryptLetter(char c, int shift)
        {
            int aN = (c + shift - 31) % 95 + 1;
            PeriodicTable.Element e = pt.GetElement(aN);
            return (e.Symbol.Length == 1) ? String.Concat(e.Symbol, " ") : e.Symbol;
        }

        private char DecryptLetter(string s, int shift)
        {
            int aN = pt.GetElement(s).AtomicNumber;
            int t = (aN - shift + 30);
            return (char) new IntRange(32, 126).IterativeAdjust(t, 95);
        }

        protected override string Encrypt(string plaintext, int key)
        {
            int[] shifts = GetShifts(key);
            string ciphertext = "";
            for (double i = 0; i < plaintext.Length; i++)
                ciphertext = ciphertext + EncryptLetter(plaintext[(int)i], shifts[(int)Math.Floor(i / 2)]);
            return ciphertext;
        }

        protected override string Decrypt(string ciphertext, int key)
        {
            int[] shifts = GetShifts(key);
            string[] splittext = GetSplitText(ciphertext);
            string plaintext = "";
            for (double i = 0; i < splittext.Length; i++)
                plaintext = plaintext + DecryptLetter(splittext[(int)i], shifts[(int)Math.Floor(i / 2)]);
            return plaintext;
        }

    }
}
