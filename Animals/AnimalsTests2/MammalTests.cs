using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Tests
{
    [TestClass()]
    public class MammalTests
    {
        Mammal j = new Mammal();
        [TestMethod()]
        public void MammalTest()
        {
            
        }

        [TestMethod()]
        public void GiveBirthTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GiveBirthTest1()
        {
            Assert.Fail();
        }
    }
}