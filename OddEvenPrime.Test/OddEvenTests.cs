using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OddEvenPrime;

namespace OddEvenPrime.Test
{
    [TestClass]
    public class OddEvenTests
    {
        [TestMethod]
        public void CheckEven()
        {
            Assert.AreEqual(true, Toolbox.IsEven(44));
        }

        [TestMethod]
        public void CheckPrime()
        {
            Assert.AreEqual(true, Toolbox.IsPrime(11));
        }
    }
}
