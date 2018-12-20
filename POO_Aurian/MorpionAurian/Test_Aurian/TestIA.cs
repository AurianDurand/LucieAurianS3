using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metier_Aurian;

namespace Test_Aurian
{
    [TestClass]
    public class TestIA
    {
        [TestMethod]
        public void Constructeur()
        {
            Morpion morpion = new Morpion();
            IA ia = new IA("IA",morpion);
            Assert.IsNotNull(ia);
        }

        [TestMethod]
        public void decide()
        {
            Morpion morpion = new Morpion();
            IA ia = new IA("IA",morpion);
            StructCoo coo;
            coo = ia.decide();
            Assert.AreNotEqual(null, coo.x);
            Assert.AreNotEqual(null, coo.y);
        }
    }
}
