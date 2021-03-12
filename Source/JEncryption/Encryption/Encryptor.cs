using System;
using System.Collections.Generic;
using System.Text;

namespace JEncryption.Encryption
{
    public class Encrypter
    {
        /**
         * @param stringToEncode The string of which the class should be encoding, functions will have parameters if you wish to modify it, the variable is also public
         * 
         * @returns a new class instance
         */
        public Encrypter(string stringToEncode)
        {
            sToBeEncoded = stringToEncode;
        }

        public string sToBeEncoded 
        { 
            get; 
            set; 
        }

        /**
         * 
         * @returns string An encrypted version of the sToBeEncoded variable.
         * 
         * <summary>
         * Encodes, in 128-bit encryption, the sToBeEncoded variable of this class
         * </summary>
         */
        public string Encode128Bit()
        {
            throw new NotImplementedException("Not added yet");
        }
        /**
         * @param toBeEncoded the string to encode
         * 
         * @returns string An encrypted version of the string passed.
         * 
         * <summary>
         * Encodes, in 128-bit encryption, the string passed as a parameter
         * </summary>
         * 
         */
        public string Encode128Bit(string toBeEncoded)
        {
            throw new NotImplementedException("Not added yet");
        }

        private IEnumerable<string> SplitEveryXChars(string s, int lengthOfSubstring)
        {
            if (s == null)
                throw new ArgumentNullException($"{nameof(s)} is null");
            if (lengthOfSubstring <= 0)
                throw new ArgumentException($"lengthOfSubstring parameter cannot be <= 0. Must be positive. Was {lengthOfSubstring}");
            for (var i = 0; i < s.Length; i += lengthOfSubstring)
                yield return s.Substring(i, Math.Min(lengthOfSubstring, s.Length - 1));
        }

    }
}
