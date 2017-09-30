using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PeriodicTable.LookupElement.SearchLoop();
        }
    }
}

// plain text : 8 char message (ascii 0x20 to 0x7e visual chars) /

// Key : 8 digits split into 4x 2 digit to look up period element by atomic number
// key elements atomic weight used to encrypt plaintext string

// Substitution::
// correspond each ascii letter in plain text - 31 to atomic symbol

// Transposition::
// correspond each ascii letter in plain text - 31 to element
// each digit of key gives column of plaintext of same index
// 


