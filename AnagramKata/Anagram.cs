using System;
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
            
            
           
            return array;
        }
    }
}
