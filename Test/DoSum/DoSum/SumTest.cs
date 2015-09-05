using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DoSum
{
    [TestFixture]
    class SumTest
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine(@"Setup Called");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine(@"TearDown Called");
        }

        [Test]
        public void SimpleSumTest()
        {
            Console.WriteLine(@"SimpleSumTest Called");
            Calculator calculator=new Calculator();
            Assert.AreEqual(10, calculator.Sum(0, 10));
        }

    }
}
