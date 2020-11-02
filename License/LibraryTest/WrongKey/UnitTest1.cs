using NUnit.Framework;
using System.Management;

namespace WrongKey
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Hash.My.Hash hash = new Hash.My.Hash();
            string key = hash.GenerateKey("Hello Worl");
            string result = hash.Veryfication(key);

            string expected = "Why you stole that code, you are so poor that you can't buy it?";

            Assert.AreEqual(expected, result);
        }
    }
}