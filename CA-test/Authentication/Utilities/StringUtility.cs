using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Utilities
{
    public class StringUtility
    {
        //implicitly private access modifier

        public char[] UppercaseLetters { get;  } = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                    'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public char[] Numbers { get; } = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        #region Utility

        public bool IsStartsWith(string text, string startText)
        {
            if (text == null)
                throw new Exception("Text can't be null");

            if (startText == null)
                throw new Exception("start text can't be null");


            if (startText.Length > text.Length)
            {
                return false;
            }

            for (int i = 0; i < startText.Length; i++)
            {
                if (text[i] != startText[i])
                {
                    return false;
                }
            }

            return true;
        }
        public string Substring(string text, int startIdx, int endIdx)
        {
            string subString = "";

            for (int i = startIdx; i <= endIdx; i++)
            {
                subString += text[i];
            }

            return subString;
        }
        public string SubstringFromEnd(string text, int length)
        {
            if (text.Length <= length || length < 0)
            {
                return default;
            }

            string subString = "";

            for (int i = text.Length - 1; i >= text.Length - length; i--)
            {
                subString += text[i];
            }

            return Reverse(subString);
        }

        public string Reverse(string text)
        {
            string reversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            return reversed;
        }

        public bool IsLengthBetween(string text, int min, int max)
        {
            return text.Length > min && text.Length < max;
        }

        public bool IsUpperLetter(char letter)
        {
            foreach (char uppercaseLetter in UppercaseLetters) //while LOOP
            {
                if (uppercaseLetter == letter)
                {
                    return true;
                }
            }

            //for (int i = 0; i < uppercaseLetters.Length; i++)
            //{
            //    if (uppercaseLetters[i] == lette)
            //    {
            //        return true;
            //    }
            //}

            return false;
        }


        public bool IsDigit(string text)
        {
            foreach (char characted in text)
            {
                if (!IsDigit(characted))
                {
                    return false;
                }
            }

            return true;
        }
        public bool IsDigit(char digit)
        {
            foreach (char number in Numbers) //Compiled to while LOOP in IL
            {
                if (digit == number)
                {
                    return true;
                }
            }

            return false;
        }
        public bool IsExactLength(string text, int length)
        {
            return text.Length == length;
        }
        public bool Contains(string text, char character)
        {
            foreach (char chr in text)
            {
                if (chr == character)
                    return true;
            }

            return false;
        }


        #endregion
    }
}
