using System;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffeTests
{
    [TestClass]
    public class FlateWhite
    {
        [TestMethod]
        public void TestMethod1()
        {
            FlatWhite fw= new FlatWhite();

            int pris = fw.Pris();

            Assert.AreEqual(45,pris);

        }

        [TestMethod]
        public void TestMethod2()
        {
            FlatWhite fw = new FlatWhite();

            int minimælk = fw.MiMælk();

            Assert.AreEqual(160, minimælk);

        }

        [TestMethod]
        public void TestMethod3()
        {
            FlatWhite fw = new FlatWhite();

            string styrke = fw.Styrke();

            Assert.AreEqual("Mild", styrke);

        }
    }
}
