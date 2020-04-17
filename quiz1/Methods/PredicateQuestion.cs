using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace quiz1.Methods
{
    class PredicateQuestion
    {
        //Write a method that has one string parameter.By Using predicate check if that string has vowel sounds and print all the vowel sounds in the output.

        public static bool IsVowel(char character) {

            //list with vowels
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Contains(character))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        Predicate<string> HasVowels = (arg1) =>
        {
            bool hasVowel = false;
            foreach (var chr in arg1)
            {
                if (IsVowel(chr))
                {
                    //print all the vowel sounds in the output.
                    Console.Write(chr);
                    //set true if vowels are found
                    hasVowel = true;
                }
            }
            //return true if vowels are found
            return hasVowel;
        };


    }
}
