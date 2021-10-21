using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                string userInput = GetInput.ReturnStringInput("Please input a word or sentence to translate to pig Latin: ");

                PigLatin translated1 = new PigLatin();

                Console.WriteLine(translated1.TranslateSentence(userInput));

                repeat = Validator.Validator.Repeat("Continue?");
            }
        }
    }
}
