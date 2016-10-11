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
            Assert.IsTrue(j.GivesLiveBirth);
            Assert.AreEqual(0, j.NumChildren);

        }

        [TestMethod()]
        public void GiveBirthTest()
        {
            j.HasOffspring = true;
            Assert.IsTrue(j.HasOffspring);
            j.GiveBirth(1);
        }

        [TestMethod()]
        public void GiveBirthTest1()
        {
            j.HasOffspring = true;
            Assert.IsTrue(j.HasOffspring);
            Assert.IsNotNull(j.NumChildren);
            j.GiveBirth(j.NumChildren += 9);
        }
    }
}