using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class PigLatin
    {
        public string TranslateWord(string word)
        {
            //if there is special character in the word, return word
            if (InputTests.IsSpecialCharacter(word))
            {
                return word;
            }

            //if word has no vowels, return word as is?
            if (InputTests.NoVowels(word))
            {
                return word;
            }

            //check if first letter is a vowel, if so, output should be word + 'way'
            char firstLetter = word[0];
            string output = "placeholder";
            
            if (InputTests.IsVowel(firstLetter))
            {
                return word + "way";
            }

            //else loop through rest of the letters and stop at the first vowel
            else
            {
                int vowelIndex = -1;
                //Handle going through all the consonants
                for (int i = 1; i <= word.Length; i++)
                {
                    //if vowel then break
                    if (InputTests.IsVowel(word[i]))
                    {
                        vowelIndex = i;
                        break;
                    }
                }

                //create a word with all consonants before first vowel at the end of the word and add "ay"
                string sub = word.Substring(vowelIndex);
                string postFix = word.Substring(0, vowelIndex);

                output = sub + postFix + "ay";
            }
            return output;
        }

        //method to loop through each word in a sentence
        public string TranslateSentence(string sentence)
        {
            string[] words = sentence.Split(' ');   //create array containing each word in the sentence
            string translatedSentence = "";         //initialize string variable to hold end result

            foreach (string word in words)
            {
                translatedSentence += TranslateWord(word) + " ";
            }

            return translatedSentence;
        }
    }
}
