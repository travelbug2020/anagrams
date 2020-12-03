using System.Collections;
using NUnit.Framework;

namespace AnagramKata.Tests
{
    public class AnagramShould
    {
        private Anagram _anagram;

        [SetUp]
        public void Setup()
        {
            _anagram = new Anagram();
        }

        [Test]
        public void ReturnEmpty_WhenGeneratingAnagrams_GivenEmptyString()
        {
            var result = _anagram.GenerateAllAnagramsFor("");

            Assert.AreEqual(new string[]{},result);
        }

        [TestCase("A")]
        [TestCase("N")]
        public void ReturnSingleLetter_WhenGeneratingAnagrams_GivenSingleLetter(string letter)
        {
            var result = _anagram.GenerateAllAnagramsFor(letter);

            Assert.AreEqual(new string[] {letter},result);
        }

        [TestCase("AB",new string[]{"AB","BA"})]
        [TestCase("CD",new string[]{"CD","DC"})]
        [TestCase("DE",new string[]{"DE","ED"})]
        [TestCase("ABC",new string[]{"ABC","ACB","BAC", "BCA", "CAB", "CBA"})]
        [TestCase("DEF",new string[]{"DEF","DFE","EDF", "EFD", "FDE", "FED"})]

        public void ReturnAnagram_WhenGeneratingAnagrams_GivenManyLetters(string letters, string[] anagrams)
        {
            var result = _anagram.GenerateAllAnagramsFor(letters);

            CollectionAssert.AreEquivalent(anagrams,result);
        }

        
        
    }
}