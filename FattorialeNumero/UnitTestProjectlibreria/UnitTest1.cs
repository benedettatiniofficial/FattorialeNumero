using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectlibreria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n1 = -1;string risultato = "non puo essere negativo";


            string risultato2 = libreria.Class1.fattoriale(n1);
            Assert.AreEqual(risultato,risultato2);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int n1 = 1; string risultato = "1";


            string risultato2 = libreria.Class1.fattoriale(n1);
            Assert.AreEqual(risultato, risultato2);

        }
        [TestMethod]
        public void TestMethod3()
        {
            int n1 = 0; string risultato = "1";


            string risultato2 = libreria.Class1.fattoriale(n1);
            Assert.AreEqual(risultato, risultato2);

        }
        [TestMethod]
        public void TestMethod4()
        {
            int n1 = 5; string risultato = "120";


            string risultato2 = libreria.Class1.fattoriale(n1);
            Assert.AreEqual(risultato, risultato2);

        }
    }

   
}
