﻿using System;

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


