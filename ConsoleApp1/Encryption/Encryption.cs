using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    public abstract class Encryption
    {

        protected PeriodicTable.PeriodicTable pt = new PeriodicTable.PeriodicTable();

        /// <summary>
        /// Every 2 digits of the 8 digit key are used as the atomic number of a periodic 
        /// element to look up and store the integer value corresponding to the atomic 
        /// weight.
        /// </summary>
        /// <param name="key">8 digit integer key</param>
        /// <returns>4 element integer array of integer atomic weights</returns>
        protected int[] GetShifts(int key)
        {
            string strKey = key.ToString();
            int[] wKey = new int[(int)Math.Ceiling((double)strKey.Length / 2)];
            for (double i = 0; i + 1 < strKey.Length; i = i + 2)
            {
                int aN = Convert.ToInt32(String.Concat(strKey[(int)i], strKey[(int)i + 1]));
                wKey[(int)Math.Floor(i / 2)] = (int)Math.Floor(pt.GetElement(aN).AtomicWeight);
            }
            return wKey;
        }

        /// <summary>
        /// Splits the ciphertext into 4 chemical elements that it represents.
        /// </summary>
        /// <param name="ciphertext">text to be decrypted</param>
        /// <returns>string array of 2 character element symbol strings</returns>
        protected string[] GetSplitText(string ciphertext)
        {
            string[] str = new string[ciphertext.Length / 2];
            for (double i = 0; i + 1 < ciphertext.Length; i = i + 2)
                str[(int)Math.Floor(i / 2)] = String.Concat(ciphertext[(int)i], ciphertext[(int)i + 1]);
            return str;
        }

        protected abstract string Encrypt(string plaintext, int key);
        protected abstract string Decrypt(string ciphertext, int key);

        protected string EncryptLoop(string msg, int key, int loopCount)
        {
            if (loopCount == 1)
                return Encrypt(msg, key);
            else
                return EncryptLoop(Encrypt(msg, key), key, loopCount - 1);
        }

        protected string DecryptLoop(string msg, int key, int loopCount)
        {
            if (loopCount == 1)
                return Decrypt(msg, key);
            else
                return DecryptLoop(Decrypt(msg, key), key, loopCount - 1);
        }

        /// <summary>
        /// Used to test the various encryptions in the console in one standard format.
        /// </summary>
        public void EncryptPrompt(bool isPlainIn)
        {
            Console.Write("Type Key: ");
            string keyStr = Console.ReadLine();
            int loopCount = keyStr[7] - 46;
            int key = Convert.ToInt32(keyStr);
            Console.Write("Type {0}text: ", isPlainIn ? "plain" : 
                                                        "cipher"
            );
            string msg = Console.ReadLine();
            Console.WriteLine("{0}text: {1}", isPlainIn ? "Cipher" : 
                                                          "Plain", 
                                              isPlainIn ? EncryptLoop(msg, key, loopCount) : 
                                                          DecryptLoop(msg, key, loopCount)
            );
        }
    }
}
