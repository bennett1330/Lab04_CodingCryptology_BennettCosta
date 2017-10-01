using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TransCrypt : Encryption
    {

        protected override string Encrypt(string plaintext, int key)
        {
            int[] shifts = GetShifts(key);
            char[] ciphertext = new char[8];
            int[] ordered = new int[8];
            shifts.CopyTo(ordered, 0);
            Array.Sort<int>(ordered);
            foreach (int q in ordered)
                Console.WriteLine("q: {0}", q);

            for (int i = 0; i < shifts.Length; i++)
            {
                int t = Array.IndexOf<int>(ordered, shifts[i]);
                Console.WriteLine("t: {0}", t);
                ciphertext[i] = plaintext[t];
                ciphertext[i + 4] = plaintext[t + 4];
            }

            return ciphertext.ToString();
        }

        protected override string Decrypt(string ciphertext, int key)
        {
            int[] shifts = GetShifts(key);
            string plaintext = "";
            throw new NotImplementedException();
        }

    }
}
