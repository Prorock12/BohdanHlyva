using NUnit.Framework;
using System;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace EmptyString
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
            string result = hash.GenerateKey(string.Empty);

            ArgumentNullException ex = new ArgumentNullException();
            string expected = ex.Message;

            Assert.AreEqual(expected, result);
        }
    }
}