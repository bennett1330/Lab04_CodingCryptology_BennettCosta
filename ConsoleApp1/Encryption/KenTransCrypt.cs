using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class KenTransCrypt : Encryption
    {
        
        private char[] RotateCharArray(char[] chartext)
        {
            char[] shifted = new char[chartext.Length];
            // % is c# modulo operator used to allow wrap around
            for (int i = 0; i < chartext.Length; i++)
                shifted.SetValue(chartext[(i + 1) % chartext.Length], i);
            return shifted;
        }

        protected override string Encrypt(string plaintext, int key)
        {
            // Subtract 48 to adjust from ascii to correct int value
            int iKey = key.ToString()[0] - 48;
            char[] chartext = plaintext.ToCharArray();
            for (int a = 0; a < iKey; a++)
                chartext = RotateCharArray(chartext);
            return new string(chartext);
        }

        protected override string Decrypt(string ciphertext, int key)
        {
            // Subtract 48 to adjust from ascii to correct int value
            int iKey = key.ToString()[0] - 48;
            char[] chartext = ciphertext.ToCharArray();
            int shift = Math.Abs(ciphertext.Length - iKey);
            for (int a = 0; a < shift; a++)
                chartext = RotateCharArray(chartext);
            return new string(chartext);
        }

    }
}
