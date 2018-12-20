using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metier_Aurian;

namespace Test_Aurian
{
    [TestClass]
    public class TestMorpion
    {
        [TestMethod]
        public void Constructeur()
        {
            Morpion morpion = new Morpion();
            Assert.IsNotNull(morpion);
        }

        [TestMethod]
        public void SaisieNomJoueurs()
        {
            Morpion morpion = new Morpion();
            morpion.saisieNomsJoueurs("a", "b");
            Assert.AreEqual(morpion.Joueur1.Nom, "a");
            Assert.AreEqual(morpion.Joueur2.Nom, "b");
        }

        [TestMethod]
        public void isJoueurCourantNotNull()
        {
            Morpion morpion = new Morpion();
            Assert.AreEqual(false, morpion.isJoueurCourantNotNull());
            morpion.saisieNomsJoueurs("a", "b");
            Assert.AreEqual(true, morpion.isJoueurCourantNotNull());
        }

        [TestMethod]
        public void getNomJoueurQuiClique()
        {
            Morpion morpion = new Morpion();
            morpion.saisieNomsJoueurs("a", "b");
            morpion.cocherCase(0, 0);
            Assert.AreEqual("a", morpion.getNomJoueurQuiClique());
        }

        [TestMethod]
        public void cocherCase()
        {
            Morpion morpion = new Morpion();
            morpion.saisieNomsJoueurs("a", "b");
            Assert.AreEqual(1, morpion.cocherCase(0,0));
            Assert.AreEqual(0, morpion.cocherCase(0,0));
            Assert.AreEqual(2, morpion.cocherCase(1,0));
        }

        [TestMethod]
        public void gagner()
        {
            Morpion morpion = new Morpion();
            morpion.cocherCase(0, 0);
            morpion.cocherCase(1, 0);
            morpion.cocherCase(0, 1);
            morpion.cocherCase(2, 0);
            morpion.cocherCase(0, 2);
            Assert.AreEqual(1, morpion.gagner());
        }

        [TestMethod]
        public void recommancerPartie()
        {
            Morpion morpion = new Morpion();
            morpion.saisieNomsJoueurs("a", "b");
            morpion.recommancerPartie();
            Assert.IsTrue(morpion.isJoueurCourantNotNull());
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreNotEqual(0, morpion.cocherCase(i, j));
                }
            }
        }
    }
}
