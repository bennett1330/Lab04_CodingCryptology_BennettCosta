using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab04 - Coding Cryptology");
            Console.WriteLine("-------------------------");
            bool run = true;
            while (run) {
                PrintOptions();
                Console.WriteLine();
                string options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        EncryptDecryptPrompt(new SubCrypt());
                        break;
                    case "2":
                        EncryptDecryptPrompt(new KenTransCrypt());
                        break;
                    case "3":
                        throw new NotImplementedException();
                        break;
                    case "0":
                        Console.Write("Exiting console application...");
                        run = false;
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid option.");
                        continue;
                }
            }
            Console.WriteLine("Goodbye.");
        }

        static void EncryptDecryptPrompt(Encryption en)
        {
            bool runInner = true;
            while (runInner)
            {
                Console.Write("[E: encrypt D: decrypt C: Back]... ");
                string s = Console.ReadLine().ToUpper();
                switch (s)
                {
                    case "E":
                        en.EncryptPrompt(true);
                        break;
                    case "D":
                        en.EncryptPrompt(false);
                        break;
                    case "C":
                        runInner = false;
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid option.");
                        continue;
                }
            }
        }

        static void PrintOptions()
        {
            Console.WriteLine(
                "[1: Substitution Algorithm " +
                "2: Transposition Algorithm " +
                "3: Both Algorithms " +
                "0: exit]"
            );
        }
    }
}


