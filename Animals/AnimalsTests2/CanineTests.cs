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
    public class CanineTests
    {
        Canine c = new Canine();
        [TestMethod()]
        public void CanineTest()
        {
            c.NumLegs = 4;
            Assert.AreEqual(4, c.NumLegs);
            c.HasFur = true;
            Assert.IsTrue(c.HasFur);
            c.Species = "Canis";
            Assert.AreEqual("Canis", c.Species);
            c.HasTail = true;
            Assert.IsTrue(c.HasTail);
            c.HasOpposableThumb = false;
            Assert.IsFalse(c.HasOpposableThumb);
        }

        [TestMethod()]
        public void AdoptedTest()
        {
            Human dave = new Human();
            c.Adopted(dave);
            Assert.AreEqual(dave, c.Owner);
           
        }

        [TestMethod()]
        public void AdoptedTest1()
        {
            Human erik = new Human();
            c.Adopted(erik,"ruff");
            Assert.AreEqual(erik.FirstName,c.Owner.FirstName);
            
        }
    }
}