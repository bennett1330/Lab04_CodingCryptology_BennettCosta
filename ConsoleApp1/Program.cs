using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PeriodicTable.LookupElement.SearchLoop();
            Encryption e = new SubCrypt();
            while (true) { e.EncryptPrompt(); }
        }
    }
}

// Transposition::
// correspond each ascii letter in plain text - 31 to element
// each digit of key gives column of plaintext of same index
// 


