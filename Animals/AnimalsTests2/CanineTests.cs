﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(4, c.NumLegs);
            Assert.IsTrue(c.HasFur);
            Assert.AreEqual("Canis", c.Species);
            Assert.IsTrue(c.HasTail);
            Assert.IsFalse(c.HasOpposableThumb);
        }

        [TestMethod()]
        public void AdoptedTest()
        {
            Human dave = new Human();
            c.Adopted(dave);
            Assert.AreEqual(dave, c.Owner);
            Assert.IsNotNull(c.Owner);
           
        }

        [TestMethod()]
        public void AdoptedTest1()
        {
            Human erik = new Human();
            c.DogName = "Bruce";
            c.Adopted(erik);
            Assert.AreEqual(erik.FirstName,c.Owner.FirstName);
            
        }
    }
}