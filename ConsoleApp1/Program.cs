using System;

namespace ConsoleApp1
{
    class Program
    {

        // TODO : should probably add some sort of input checking but mehhhhhh
        static void Main(string[] args)
        {
            Console.WriteLine("Lab04 - Coding Cryptology");
            Console.WriteLine("-------------------------");
            bool run = true;
            while (run)
            {
                Console.WriteLine(
                    "[1: Substitution Algorithm " +
                    "2: Transposition Algorithm " +
                    "3: Both Algorithms " +
                    "0: exit]"
                );
                Console.WriteLine();
                string options = Console.ReadLine();
                bool innerLoop = true;
                while (innerLoop)
                {
                    string[] r;
                    Encryption en;
                    switch (options)
                    {
                        case "1":
                            r = Prompt();
                            if (r == null) { innerLoop = false; continue; }
                            en = new SubCrypt();
                            en.EncryptResponse(Convert.ToBoolean(r[0]), r[1], r[2]);
                            break;
                        case "2":
                            r = Prompt();
                            if (r == null) { innerLoop = false; continue; }
                            en = new KenTransCrypt();
                            en.EncryptResponse(Convert.ToBoolean(r[0]), r[1], r[2]);
                            break;
                        case "3":
                            r = Prompt();
                            if (r == null) { innerLoop = false; continue; }
                            en = new SubCrypt();
                            if (Convert.ToBoolean(r[0]) == true)
                            {
                                string res = en.EncryptSilent(Convert.ToBoolean(r[0]), r[1], r[2]);
                                Encryption en2 = new KenTransCrypt();
                                en2.EncryptResponse(Convert.ToBoolean(r[0]), res, r[2]);
                            }
                            else
                            {
                                Encryption en2 = new KenTransCrypt();
                                string res = en2.EncryptSilent(Convert.ToBoolean(r[0]), r[1], r[2]);
                                en.EncryptResponse(Convert.ToBoolean(r[0]), res, r[2]);
                            }
                            break;
                        case "0":
                            Console.Write("Exiting console application...");
                            innerLoop = false;
                            run = false;
                            continue;
                        default:
                            Console.WriteLine("ERROR: Invalid option.");
                            innerLoop = false;
                            continue;
                    }
                }
            }
            Console.WriteLine("Goodbye.");
        }

        public static string[] Prompt()
        {
            Console.Write("[E: encrypt D: decrypt C: Back]... ");
            string s = Console.ReadLine().ToUpper();
            switch (s)
            {
                case "E":
                    return Encryption.EncryptPrompt(true);
                case "D":
                    return Encryption.EncryptPrompt(false);
                case "C":
                    return null;
                default:
                    Console.WriteLine("ERROR: Invalid option.");
                    return null;
            }
        }

    }
}


