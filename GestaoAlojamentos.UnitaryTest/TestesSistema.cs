using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestaoAlojamentos.BO;
using GestaoAlojamentos.DA;
using GestaoAlojamentos.Exceptions;
using System.Linq;

namespace GestaoAlojamentos.UnitaryTest
{
    [TestClass]
    public class TestesSistemas
    {
        private ServicoDeRegistoCliente servicoCliente;
        private ServicoDeCheckIn servicoCheckIn;

        [TestInitialize]
        public void Setup()
        {
            servicoCliente = new ServicoDeRegistoCliente();
            servicoCheckIn = new ServicoDeCheckIn();

            // Limpeza manual se necessário (como as listas são estáticas)
            Alojamento.Alojamentos.Clear();
            Alojamento.Alojamentos.Add(new Alojamento(1, "Quarto", "Disponivel"));
        }

        [TestMethod]
        public void TestRegistarClienteComSucesso()
        {
            bool result = servicoCliente.RegistarNovoCliente("Vitor", "123456789");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestRegistarClienteNifInvalido()
        {
            // NIF com menos de 9 dígitos deve retornar false no teu BO atual
            bool result = servicoCliente.RegistarNovoCliente("Joao", "123");
            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(AlojamentoOcupadoException))]
        public void TestCheckInAlojamentoJaOcupado()
        {
            // Setup
            servicoCliente.RegistarNovoCliente("Vitor", "999888777");
            servicoCheckIn.EfetuarCheckIn(1, "999888777"); // Primeiro check-in (Sucesso)

            // Ação: Segundo check-in no mesmo ID deve lançar Exception
            servicoCheckIn.EfetuarCheckIn(1, "999888777");
        }

        [TestMethod]
        public void TestConsultarDisponiveis()
        {
            var consulta = new ServicoDeConsultas();
            var lista = consulta.ConsultarDisponiveis();
            Assert.IsNotNull(lista);
            Assert.AreEqual("Disponivel", lista.First().Estado);
        }
    }
}
