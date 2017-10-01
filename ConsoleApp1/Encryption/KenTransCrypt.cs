using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class KenTransCrypt : Encryption
    {
        
        protected override string Encrypt(string plaintext, int key)
        {
            int wrapChar;
            char[] chartext = plaintext.ToCharArray();
            for (int a = 0; a < key.ToString().Length; a++)
            {
                wrapChar = plaintext[0];
                for (int b = 0; b < chartext.Length; b++)
                {
                    if (b + 1 == chartext.Length)
                        chartext.SetValue((char)wrapChar, b);
                    else
                        chartext.SetValue((char)plaintext[b + 1], b);
                }
            }
            return chartext.ToString();
        }

        protected override string Decrypt(string ciphertext, int key)
        {
            throw new NotImplementedException();
        }

    }
}
