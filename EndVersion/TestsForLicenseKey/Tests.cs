using MainProject;
using NUnit.Framework;
using System;
using System.Management;

namespace TestsForLicenseKey
{
    public class Tests
    {
        Register register = new Register();
        StringOperation operation = new StringOperation();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void WrongKey()
        {
            
            HashAction.Hash hash = new HashAction.Hash();
            string key = hash.GenerateKey("Hello Worl");
            bool result = hash.Verification(key, register.RegisterVerification());

            bool expected = false;

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void NullString()
        {
            HashAction.Hash hash = new HashAction.Hash();
            string result = hash.GenerateKey(null);

            string expected = null;

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void EmptyString()
        {
            HashAction.Hash hash = new HashAction.Hash();
            string result = hash.GenerateKey(string.Empty);

            string expected = null;

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CorrectKey()
        {
            HashAction.Hash hash = new HashAction.Hash();
            string ConcatString = string.Concat(Data.SerialNumberOut, Data.Availability,DateTime.Now.ToString("d"));
            string key = hash.GenerateKey(ConcatString);
            key = operation.AddSplit(key);

            bool result = hash.Verification(key, register.RegisterVerification());

            bool expected = true;

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void DifferentResult()
        {
            HashAction.Hash hash = new HashAction.Hash();
            string ConcatString = string.Concat(Data.SerialNumberOut, DateTime.Now.ToString("d"), Data.Availability);
            string key = hash.GenerateKey(ConcatString);

            string otherResult = hash.GenerateKey("Hello World");

            bool result = hash.Verification(key, otherResult);

            bool expected = false;

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void HashNotEmpty()
        {
            HashAction.Hash hash = new HashAction.Hash();
            string ConcatString = string.Concat(Data.SerialNumberOut, DateTime.Now.ToString("d"), Data.Availability);
            string result = hash.GenerateKey(ConcatString);

            string expected = null;

            Assert.AreNotEqual(expected, result);
        }
        [Test]
        public void SameLenght()
        {
            HashAction.Hash hash = new HashAction.Hash();
            string ConcatString = string.Concat(Data.SerialNumberOut, DateTime.Now.ToString("d"), Data.Availability);
            int key = hash.GenerateKey(ConcatString).Length;

            int otherResult = hash.GenerateKey("Hello World").Length;

            bool result = key==otherResult;

            bool expected = true;

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SameResult()
        {
            HashAction.Hash hash = new HashAction.Hash();
            string ConcatString = string.Concat(Data.SerialNumberOut, DateTime.Now.ToString("d"), Data.Availability);
            string key = hash.GenerateKey(ConcatString);

            string ConcatString1 = string.Concat(Data.SerialNumberOut, DateTime.Now.ToString("d"), Data.Availability);
            string key1 = hash.GenerateKey(ConcatString1);

            bool result = hash.Verification(key, key1);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }
    }
}