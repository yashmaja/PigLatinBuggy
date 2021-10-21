using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class GetInput
    {
        public static string ReturnStringInput(string prompt)
        { 
            Console.Write(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }
    }
}
