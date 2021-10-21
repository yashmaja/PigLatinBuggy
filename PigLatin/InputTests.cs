using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class InputTests
    {
        //method to check if a char is a vowel
        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            
            foreach (char vowel in vowels)
            {
                if (c == vowel)
                {
                    return true;
                }
            }
            return false;
        }

        //method to check if a word contains any special characters
        public static bool IsSpecialCharacter(string word)
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        //method to check if a word does not contain any vowels
        public static bool NoVowels(string word)
        {
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
