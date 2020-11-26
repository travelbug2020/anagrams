using NUnit.Framework;

namespace AnagramKata.Tests
{
    public class AnagramShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnAnagram_WithFirstLetterInSamePosition_WhenGivenDog()
        {
            var anagram = new Anagram();

            var result = anagram.GenerateAllAnagramsFor("dog");

            Assert.AreEqual(new string[] { "dog","dgo","gdo","god","odg","ogd" }, result);
        }
    }
}