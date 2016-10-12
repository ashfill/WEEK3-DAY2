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
            //g.NumLegs = 2;
            Assert.AreEqual(2, g.NumLegs);
            //g.HasFur = false;
            Assert.IsFalse(g.HasFur);
            //g.Species = "homosapien";
            Assert.AreEqual("Homosapien", g.Species);
            //g.HasTail = false;
            Assert.IsFalse(g.HasTail);
            //g.HasOpposableThumb = true;
            Assert.IsTrue(g.HasOpposableThumb);
            //g.MaritalStatus = 'S';
            Assert.AreEqual('S', g.MaritalStatus);
        }

        [TestMethod()]
        public void GetMarriedTest()
        {
            Assert.AreEqual(g.MaritalStatus,'S');
            g.GetMarried();
            Assert.AreNotEqual(g.MaritalStatus,"M");
        }

        [TestMethod()]
        public void GetMarriedTest1()
        {
            g.FirstName = "hank";
            Assert.AreEqual("hank",g.FirstName);
            g.LastName = "rubell";
            Assert.AreEqual("rubell",g.LastName);
            g.GetMarried();
            Assert.AreEqual(g.MaritalStatus, 'M');
            
        }

        [TestMethod()]
        public void GetSingleTest()
        {
            g.GetMarried();
            Assert.AreNotEqual(g.MaritalStatus,"M");
            g.GetSingle();
            Assert.AreEqual(g.MaritalStatus, 'S');
        }

        [TestMethod()]
        public void GetSingleTest1()
        {
            g.FirstName = "Dave";
            g.LastName = "Kozminski";
            g.GetMarried();
            Assert.AreEqual("Dave", g.FirstName);
            Assert.AreEqual("Kozminski", g.LastName);
            Assert.AreEqual(g.MaritalStatus, 'M');
            g.GetSingle();
            Assert.IsNotNull(g.GetSingle());
        }
    }
}