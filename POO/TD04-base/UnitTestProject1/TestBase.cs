using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD04;

namespace UnitTestProject1
{
    [TestClass]
    public class TestBase
    {
        [TestMethod]
        public void TestCrepe()
        {
            IDessert d = new Crepe();
            Assert.AreEqual("Crêpe", d.Libelle);
            Assert.AreEqual(2, d.Prix);
        }
        [TestMethod]
        public void TestGaufre()
        {
            IDessert d = new Gaufre();
            Assert.AreEqual("Gaufre", d.Libelle);
            Assert.AreEqual(3, d.Prix);
        }
    }
}
