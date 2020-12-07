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
        [TestCase("ABCD",new string[]{"ABCD", "ABDC", "ACBD", "ACDB", "ADBC", "ADCB", "BACD", "BADC", "BCAD", "BCDA", "BDAC", "BDCA", "CABD", "CADB", "CBAD", "CBDA", "CDAB", "CDBA", "DABC", "DACB", "DBAC", "DBCA", "DCAB", "DCBA"})]
        [TestCase("BIOR",new string[]{ "BIOR", "BIRO", "BOIR", "BORI", "BRIO", "BROI", "IBOR", "IBRO", "IOBR", "IORB", "IRBO", "IROB", "OBIR", "OBRI", "OIBR", "OIRB", "ORBI", "ORIB", "RBIO", "RBOI", "RIBO", "RIOB", "ROBI", "ROIB"})]
        [TestCase("ABCDE",new string[]{ "ABCDE", "ABCED", "ABDCE", "ABDEC", "ABECD", "ABEDC", "ACBDE", "ACBED", "ACDBE", "ACDEB", "ACEBD", "ACEDB", "ADBCE", "ADBEC", "ADCBE", "ADCEB", "ADEBC", "ADECB", "AEBCD", "AEBDC", "AECBD", "AECDB", "AEDBC", "AEDCB", "BACDE", "BACED", "BADCE", "BADEC", "BAECD", "BAEDC", "BCADE", "BCAED", "BCDAE", "BCDEA", "BCEAD", "BCEDA", "BDACE", "BDAEC", "BDCAE", "BDCEA", "BDEAC", "BDECA", "BEACD", "BEADC", "BECAD", "BECDA", "BEDAC", "BEDCA", "CABDE", "CABED", "CADBE", "CADEB", "CAEBD", "CAEDB", "CBADE", "CBAED", "CBDAE", "CBDEA", "CBEAD", "CBEDA", "CDABE", "CDAEB", "CDBAE", "CDBEA", "CDEAB", "CDEBA", "CEABD", "CEADB", "CEBAD", "CEBDA", "CEDAB", "CEDBA", "DABCE", "DABEC", "DACBE", "DACEB", "DAEBC", "DAECB", "DBACE", "DBAEC", "DBCAE", "DBCEA", "DBEAC", "DBECA", "DCABE", "DCAEB", "DCBAE", "DCBEA", "DCEAB", "DCEBA", "DEABC", "DEACB", "DEBAC", "DEBCA", "DECAB", "DECBA", "EABCD", "EABDC", "EACBD", "EACDB", "EADBC", "EADCB", "EBACD", "EBADC", "EBCAD", "EBCDA", "EBDAC", "EBDCA", "ECABD", "ECADB", "ECBAD", "ECBDA", "ECDAB", "ECDBA", "EDABC", "EDACB", "EDBAC", "EDBCA", "EDCAB", "EDCBA" })]
        [TestCase("ANGEL",new string[]{ "ANGEL", "ANGLE", "ANEGL", "ANELG", "ANLGE", "ANLEG", "AGNEL", "AGNLE", "AGENL", "AGELN", "AGLNE", "AGLEN", "AENGL", "AENLG", "AEGNL", "AEGLN", "AELNG", "AELGN", "ALNGE", "ALNEG", "ALGNE", "ALGEN", "ALENG", "ALEGN", "NAGEL", "NAGLE", "NAEGL", "NAELG", "NALGE", "NALEG", "NGAEL", "NGALE", "NGEAL", "NGELA", "NGLAE", "NGLEA", "NEAGL", "NEALG", "NEGAL", "NEGLA", "NELAG", "NELGA", "NLAGE", "NLAEG", "NLGAE", "NLGEA", "NLEAG", "NLEGA", "GANEL", "GANLE", "GAENL", "GAELN", "GALNE", "GALEN", "GNAEL", "GNALE", "GNEAL", "GNELA", "GNLAE", "GNLEA", "GEANL", "GEALN", "GENAL", "GENLA", "GELAN", "GELNA", "GLANE", "GLAEN", "GLNAE", "GLNEA", "GLEAN", "GLENA", "EANGL", "EANLG", "EAGNL", "EAGLN", "EALNG", "EALGN", "ENAGL", "ENALG", "ENGAL", "ENGLA", "ENLAG", "ENLGA", "EGANL", "EGALN", "EGNAL", "EGNLA", "EGLAN", "EGLNA", "ELANG", "ELAGN", "ELNAG", "ELNGA", "ELGAN", "ELGNA", "LANGE", "LANEG", "LAGNE", "LAGEN", "LAENG", "LAEGN", "LNAGE", "LNAEG", "LNGAE", "LNGEA", "LNEAG", "LNEGA", "LGANE", "LGAEN", "LGNAE", "LGNEA", "LGEAN", "LGENA", "LEANG", "LEAGN", "LENAG", "LENGA", "LEGAN", "LEGNA" })]
        public void ReturnAnagram_WhenGeneratingAnagrams_GivenManyLetters(string letters, string[] anagrams)
        {
            var result = _anagram.GenerateAllAnagramsFor(letters);

            CollectionAssert.AreEquivalent(anagrams,result);
        }

        [TestCase("AA")]
        [TestCase("BB")]
        [TestCase("CC")]
        [TestCase("DDDDDDDDDDD")]
        public void ReturnSameLetters_WhenGeneratingAnagrams_GivenSameLetters(string letters)
        {
            var result = _anagram.GenerateAllAnagramsFor(letters);

            CollectionAssert.AreEquivalent(new string[] { letters }, result);
        }

        [TestCase("ABB", new string[] { "ABB", "BAB", "BBA" })]
        [TestCase("BCC", new string[] { "BCC", "CBC", "CCB" })]
        [TestCase("CDD", new string[] { "CDD", "DCD", "DDC" })]
        public void ReturnAnagram_WhenGeneratingAnagrams_GivenDuplicateLetters(string letters, string[] anagrams)
        {
            var result = _anagram.GenerateAllAnagramsFor(letters);

            CollectionAssert.AreEquivalent(anagrams, result);
        }
    }
}