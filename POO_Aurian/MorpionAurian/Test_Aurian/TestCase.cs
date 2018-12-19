using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metier_Aurian;

namespace Test_Aurian
{
    [TestClass]
    public class TestCase
    {
        [TestMethod]
        public void Constructeur()
        {
            Case c = new Case(1, 1);
            Assert.IsNotNull(c);
            Assert.AreEqual(c.X, 1);
            Assert.AreEqual(c.Y, 1);
        }
    }
}
