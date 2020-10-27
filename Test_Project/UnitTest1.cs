using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClient.Bussiness;

namespace Test_Project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestaBuscaCepVistaVerde()
        {
            Cep buscaCep = Cep.Search("05171500");

            Assert.AreEqual(buscaCep.Address, "Rua Desembargador Joaquim Bandeira de Mello");

        }

        [TestMethod]
        public void TestaBuscaCepRegis()
        {
            Cep buscaCep = Cep.Search("05119000");

            Assert.AreEqual(buscaCep.Address, "Avenida d Anastácio");

        }
    }
}
