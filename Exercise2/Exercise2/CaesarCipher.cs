using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    /// <summary>
    /// This class receives an alphabet in the constructor and has three methods:
    /// 1. Sets an offset for ciphering
    /// 2. Cyphers a string with the given alphabet and current offset
    /// 3. Deciphers a string with given alphbet and current offset
    /// </summary>
    class CaesarCipher
    {

        #region Properties
        public string alphabet;
        public int offset;
        #endregion

        #region Constructor
        public CaesarCipher(string alphabet)
        {
            this.alphabet = alphabet;
        }
        #endregion

        #region Methods
        // Generates random number for offset
        public void SetOffset()
        {
            Random rand = new Random();
            offset = rand.Next(0, 10);
            Console.WriteLine(offset);
        }

        // Loops through a string of characters and finds the offset letter.
        public string Cypher(string text)
        {
            string ciphered = "";
            for (int i = 0; i < text.Length; i++)
            {
                ciphered += FindOffsetLetterCipher(text[i]);
            }
            return ciphered;
        }

        // Loops through a string of characters and finds the offset letter.
        public string Decipher(string text)
        {
            string decipher = "";
            for (int i = 0; i < text.Length; i++)
            {
                decipher += DecipherFindOffsetLetter(text[i]);
            }

            return decipher;
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Finds letter with offset.
        /// </summary>
        /// <param name="letter">Letter from string to be ciphered</param>
        /// <returns></returns>
        public char FindOffsetLetterCipher(char letter)
        {
            char newLetter = ' ';
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == letter)
                {
                    newLetter = alphabet[(i + offset) % alphabet.Length];
                }
            }
            return newLetter;
        }

        /// <summary>
        /// Finds letter that was offsetted in cipher.
        /// </summary>
        /// <param name="letter">Letter from ciphered string</param>
        /// <returns></returns>
        public char DecipherFindOffsetLetter(char letter)
        {
            char newLetter = ' ';
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == letter)
                {
                    // Checks case where offsetted letter is at the end of the alphabet
                    if ((i - offset) < 0)
                    {
                        newLetter = alphabet[alphabet.Length + i - offset];
                    }
                    else
                    {
                        newLetter = alphabet[(i - offset)];
                    }
                }
            }
            return newLetter;
        }
        #endregion
    }
}