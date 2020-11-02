using NUnit.Framework;
using Hash.My;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Management;

namespace NullString
{
    public class NullString
    {
        DateTime DateTimes = DateTime.Now;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Hash.My.Hash hash = new Hash.My.Hash();
            string result = hash.GenerateKey(null);

            ArgumentNullException ex=new ArgumentNullException();
            string expected = ex.Message;

            Assert.AreEqual(expected, result);
        }
    }
}