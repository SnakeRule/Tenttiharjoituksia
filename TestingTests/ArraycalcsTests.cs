using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Tests
{
    [TestClass()]
    public class ArraycalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            array.Sum();
            Assert.Fail();
        }

        [TestMethod()]
        public void AverageTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MinTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MaxTest()
        {
            Assert.Fail();
        }
    }
}