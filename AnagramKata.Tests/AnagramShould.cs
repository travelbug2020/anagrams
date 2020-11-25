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

            var result = anagram.LeaveFirstLetter("dog");

            Assert.AreEqual("dog dgo", result);
        }
    }
}