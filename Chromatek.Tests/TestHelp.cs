using NUnit.Framework;
using Chromatek;
using System.Collections.Generic;
using System;

namespace test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void СalculateTransposition_Six()
        {
            IList<String> listString = Help.СalculateTransposition("abc".ToCharArray());
            Assert.AreEqual(listString.Count, 6);
        }

        [Test]
        public void СalculateTransposition_Repeat_Six()
        {
            IList<String> listString = Help.СalculateTransposition("abcca".ToCharArray());
            Assert.AreEqual(listString.Count, 6);
        }

        [Test]
        public void СalculateTransposition_24()
        {
            IList<String> listString = Help.СalculateTransposition("4321".ToCharArray());
            Assert.AreEqual(listString.Count, 24);
        }
    }
}