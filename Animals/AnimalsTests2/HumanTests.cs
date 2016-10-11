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
    public class HumanTests
    {
        Human g = new Human();
        [TestMethod()]
        public void HumanTest()
        {
            g.NumLegs = 2;
            Assert.AreEqual(2, g.NumLegs);
            g.HasFur = false;
            Assert.IsFalse(g.HasFur);
            g.Species = "homosapien";
            Assert.AreEqual("homosapien", g.Species);
            g.HasTail = false;
            Assert.IsFalse(g.HasTail);
            g.HasOpposableThumb = true;
            Assert.IsTrue(g.HasOpposableThumb);
            g.MaritalStatus = 'S';
            Assert.AreEqual('S', g.MaritalStatus);
        }

        [TestMethod()]
        public void GetMarriedTest()
        {
            g.MaritalStatus = 'M';
            Assert.AreNotEqual('M', 'S');
        }

        [TestMethod()]
        public void GetMarriedTest1()
        {
            g.FirstName = "hank";
            Assert.AreEqual("hank", g.FirstName);
            g.LastName = "rubell";
            Assert.AreEqual("rubell", g.LastName);
            g.GetMarried(g.FirstName,g.LastName);

            
        }

        [TestMethod()]
        public void GetSingleTest()
        {
            g.MaritalStatus = 'S';
            Assert.AreNotEqual('S', 'M');
        }

        [TestMethod()]
        public void GetSingleTest1()
        {
            g.FirstName = "Dave";
            Assert.AreEqual("Dave", g.FirstName);
            g.LastName = "Kozminski";
            Assert.AreEqual("Kozminski", g.LastName);
            g.GetSingle(g.FirstName, g.LastName);
            Assert.IsNotNull(g.GetSingle());
        }
    }
}