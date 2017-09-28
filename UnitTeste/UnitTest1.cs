using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste.Models;

namespace UnitTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var tarifas = new Tarifas();

            Assert.IsNotNull(tarifas, "Tarifas com Problemas");

            Assert.IsFalse(tarifas.Itens.Any(), "Tarifas com Problemas");


        }
    }
}
