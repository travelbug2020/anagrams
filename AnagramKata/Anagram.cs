using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AnagramKata
{
    public class Anagram
    {
        public string[] GenerateAllAnagramsFor(string word)
        {
            var anagrams = new List<string>();
            if (word.Length == 1)
            {
                anagrams.Add(word);
            }
            else if (word.Length == 2)
            {
                var firstLetter = word[0];
                var secondLetter = word[1];
                anagrams.Add($"{firstLetter}{secondLetter}");
                anagrams.Add($"{secondLetter}{firstLetter}");
            }
            else if ( word.Length >= 3 )
            {
                for (var letterIndex = 0; letterIndex < word.Length; letterIndex++)
                {
                    var wordsRemainingLetters = word.Remove(letterIndex,1);
                    var innerAnagrams = GenerateAllAnagramsFor(wordsRemainingLetters);
                    foreach (var innerAnagram in innerAnagrams)
                    {
                        anagrams.Add($"{word.ToCharArray()[letterIndex]}{innerAnagram}");
                    }
                }
            }
            return anagrams.Distinct().ToArray();
        }
    }
}
