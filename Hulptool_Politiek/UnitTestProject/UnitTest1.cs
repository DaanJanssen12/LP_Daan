using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hulptool_Politiek.Models;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PartyNotTheSame()
        {
            Party p = new Party("Partij van Daan", "PvD", new Politician("Daan", 1), 1);
            Party p2 = new Party("Partij van Henk", "PvH", new Politician("Henk", 2), 2);
            Assert.AreNotEqual(p.Abbreviation, p2.Abbreviation);
        }
    }
}
