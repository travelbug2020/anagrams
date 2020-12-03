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
                char firstLetter = word[0];
                char secondLetter = word[1];
                anagrams.Add($"{firstLetter}{secondLetter}");
                anagrams.Add($"{secondLetter}{firstLetter}");
            }
            else if ( word.Length == 3 )
            {
                for (int index = 0; index < word.ToCharArray().Length; index++)
                {
                    var anagramLettersArray = word.ToCharArray().Where(letter => letter != word.ToCharArray()[index]).ToArray();
                    string anagramLetters = new string(anagramLettersArray);
                    var innerAnagrams = GenerateAllAnagramsFor(anagramLetters);
                    foreach (var innerAnagram in innerAnagrams)
                    {
                        anagrams.Add($"{word.ToCharArray()[index]}{innerAnagram}");

                    }
                }
            }

            return anagrams.ToArray();
        }
    }
}
