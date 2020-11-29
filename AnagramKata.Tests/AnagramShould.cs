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
        public void ReturnAnagram_WithAllPotentialAnagrams_WhenGivenDog()
        {
            var result = _anagram.GenerateAllAnagramsFor("dog");

            Assert.AreEqual(new[] { "dog","dgo","odg","ogd","gdo","god" }, result);
            // dog gdo ogd dog god dgo odg  d  d o g 
        }

        [Test]
        public void ReturnAnagram_WithAllPotentialAnagrams_WhenGivenCat()
        {
           var result = _anagram.GenerateAllAnagramsFor("cat");

           Assert.AreEqual(new[] { "cat", "cta", "act", "atc", "tca", "tac" },result);
        }
        // cat tca atc 

        [Test]
        public void ReturnAnagram_WithAllPotentialAnagrams_WhenGivenHit()
        {
            var result = _anagram.GenerateAllAnagramsFor("hit");

            Assert.AreEqual(new[] { "hit", "hta", "iht", "ith", "thi", "tih" }, result);
        }
    }
}