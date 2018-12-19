using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metier_Aurian;

namespace Test_Aurian
{
    [TestClass]
    public class TestJoueur
    {
        [TestMethod]
        public void Constructeur()
        {
            Joueur joueur = new Joueur("test");
            Assert.IsNotNull(joueur);
        }
    }
}
