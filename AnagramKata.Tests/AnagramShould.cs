using NUnit.Framework;

namespace AnagramKata.Tests
{
    public class AnagramShould
    {
        private Anagram anagram;

        [SetUp]
        public void Setup()
        {
            var anagram = new Anagram();
        }

        [Test]
        public void ReturnAnagram_WithAllPotentialAnagrams_WhenGivenDog()
        {
            var result = anagram.GenerateAllAnagramsFor("dog");

            Assert.AreEqual(new[] { "dog","dgo","odg","ogd","gdo","god" }, result);
        }

        [Test]
        public void ReturnAnagram_WithAllPotentialAnagrams_WhenGivenCat()
        {
            var result = anagram.GenerateAllAnagramsFor("cat");
            Assert.AreEqual(new[] { "cat", "cta", "atc", "act", "tac", "tca" },result);
        }
    }
}