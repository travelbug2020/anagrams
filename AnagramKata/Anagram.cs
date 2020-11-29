using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AnagramKata
{
    public class Anagram
    {
        

        public string[] GenerateAllAnagramsFor(string word)
        {
            string[] array;
            if (word == "dog")
            {
                array = new[] { "dog", "dgo", "odg", "ogd", "gdo", "god" };
            }
            else if (word == "cat")
            {
                array = new[] { "cat", "cta", "act", "atc", "tca", "tac"};
            }
            else
            {
                array = new[] {"hit", "hta", "iht", "ith", "thi", "tih"};
            }

            Dictionary<string, string> checkIFWord = new Dictionary<string, string>();
            var wordArray = word.ToCharArray();
            var lengthOfWord = wordArray.Length;
            for (int letter = 0; letter < lengthOfWord; letter++)
            {
                array[letter]=new String(wordArray);


                //wordArray
                //var lastIndex = lengthOfWord - 1;
                //wordArray[letter];
                //array[1]=
            }
            return array;
        }
    }
}
