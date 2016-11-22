using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using UnitTestProjectAcademia;
//using Academia;


namespace UnitTestProjectAcademia
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIMC()
        {
            Cliente auxcli = new Cliente();
            Assert.AreEqual(Cliente.IMCcalc(1.75, 67.36), 22);
        }
    }
}