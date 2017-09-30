using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    public abstract class Encryption
    {
        protected abstract string Encrypt(string plaintext, int key);
        protected abstract string Decrypt(string ciphertext, int key);

        public void EncryptPrompt()
        {
            Console.Write("Select option: [1: encrypt; 2: decrypt] ");
            string selection = Console.ReadLine();
            Console.Write("Type Key: ");
            string keyStr = Console.ReadLine();
            int key = Convert.ToInt32(keyStr);
            Console.Write("Type message text: ");
            string msg = Console.ReadLine();
             
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Ciphertext: {0}", Encrypt(msg, key));
                    break;
                case "2":
                    Console.WriteLine("Plaintext: {0}", Decrypt(msg, key));
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid selection.");
                    break;
            }
            //string wait = Console.ReadLine();
        }
    }
}
