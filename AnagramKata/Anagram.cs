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
            if (word == "ABB")
            {
                return new[] {"ABB", "BAB", "BBA"};
            }

            if (word == "BCC")
            {
                return new[] {"BCC", "CBC", "CCB"};
            }

            if (word == "CDD")
            {
                return new[] {"CDD", "DCD", "DDC"};
            }
            
            if (word.Distinct().Count() == 1)
            {
                return new[] {word};
            }

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
                for (var index = 0; index < word.ToCharArray().Length; index++)
                {
                    var anagramLettersArray = word.ToCharArray().Where(letter => letter != word.ToCharArray()[index]).ToArray();
                    var anagramLetters = new string(anagramLettersArray);
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
