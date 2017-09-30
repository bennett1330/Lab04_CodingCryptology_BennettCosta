using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Encryption
    {
        protected abstract string Encrypt(string plaintext, int key);
        protected abstract string Decrypt(string ciphertext, int key);
    }
}
