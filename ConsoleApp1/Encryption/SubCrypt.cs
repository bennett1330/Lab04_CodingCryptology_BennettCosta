using System;

namespace ConsoleApp1
{
    class SubCrypt : Encryption
    {

        /// <summary>
        /// Encrypts one letter using an atomic number that corresponds to an adjusted ascii value and
        /// the given numeric shift value.
        /// </summary>
        /// <param name="c">the character to encrypt</param>
        /// <param name="shift">the number by which to shift the atomic number</param>
        /// <returns></returns>
        private string EncryptLetter(char c, int shift)
        {
            int aN = (c + shift - 31) % 95 + 1; // 31 is used to adjust from atomic number to ascii
            PeriodicTable.Element e = pt.GetElement(aN);
            return (e.Symbol.Length == 1) ? String.Concat(e.Symbol, " ") : e.Symbol;
        }

        /// <summary>
        /// Decrypts one letter by looking up the atomic number that corresponds to the 2 character
        /// string and the given numeric shift value.
        /// </summary>
        /// <param name="c">the character to encrypt</param>
        /// <param name="shift">the number by which to shift the atomic number</param>
        /// <returns></returns>
        private char DecryptLetter(string s, int shift)
        {
            if (s[1] == ' ')
                s = s[0].ToString().ToUpper(); // handling for single letter elements
            else
                s = s[0].ToString().ToUpper() + s[1];
            int aN = pt.GetElement(s).AtomicNumber;
            int t = (aN - shift + 30); // 30 is used to adjust from atomic number to ascii
            return (char) new IntRange(32, 126).IterativeAdjust(t, 95);
        }

        protected override string Encrypt(string plaintext, int key)
        {
            int[] shifts = GetShifts(key);
            string ciphertext = "";
            for (double i = 0; i < plaintext.Length; i++)
                ciphertext = ciphertext + EncryptLetter(plaintext[(int)i], shifts[(int)Math.Floor(i / 2)]);
            return ciphertext.ToLower();
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
