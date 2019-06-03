using NUnit.Framework;
using System;
using System.Text;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sample_Test_1()
        {
            Assert.That(true, Is.True);
        }
    }
}