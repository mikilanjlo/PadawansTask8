using NUnit.Framework;

namespace PadawansTask8.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [Test]
        public void RemoveDuplicateWordsTest()
        {
            string actual = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";

            string expected = "alpha beta  gamma   delta       ";

            WordsManipulation.RemoveDuplicateWords(ref actual);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            string actual = "That Is Why We Have A Lot Of  Friends. Test1 - Test1";

            string expected = "That Is Why We Have A Lot Of  Friends. Test1 - Test1";

            WordsManipulation.RemoveDuplicateWords(ref actual);

            Assert.AreEqual(expected, actual);
        }
    }
}