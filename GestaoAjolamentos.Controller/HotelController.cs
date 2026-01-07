/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe Controller que gere as operações do hotel e faz a ponte a APP e BO/DA
*/

using GestaoAlojamentos.BO;
using GestaoAlojamentos.DA;
using System.Collections.Generic;

namespace GestaoAlojamentos.Controller
{
    // A classe GereHotel (Controller) coordena as operações do sistema.
    public class HotelController
    {
        /**
         *  Serviços BO usados pelo Controller 
         *  private readonly - indica que estas variáveis são somente leitura após a inicialização no construtor
         */
        private readonly ServicoDeConsultas servicoConsultas;
        private readonly ServicoDeCheckIn servicoCheckIn;
        private readonly ServicoDeRegistoCliente servicoRegisto;

        // Construtor do Controller
        public HotelController()
        {
            // Inicializa todos os serviços BO que vai usar
            this.servicoConsultas = new ServicoDeConsultas();
            this.servicoCheckIn = new ServicoDeCheckIn();
            this.servicoRegisto = new ServicoDeRegistoCliente();
        }
        public Hotel GereHotel()
        {
            // Retorna a instância única do Hotel (DA)
            return Hotel.GetInstancia();
        }

        // Operações de Consultas
        public List<Alojamento> MostrarDisponiveis()
        {
            return servicoConsultas.ConsultarDisponiveis();
        }

        // Operações de Registos
        public bool RegistarCliente(string nome, string nif)
        {
            return servicoRegisto.RegistarNovoCliente(nome, nif);
        }

        // Operações de Check-in
        public bool ProcessarCheckIn(int alojamentoId, string clienteNif)
        {
            return servicoCheckIn.EfetuarCheckIn(alojamentoId, clienteNif);
        }

        // Operações de Check-out
        public bool ProcessarCheckOut(int alojamentoId)
        {
            return servicoCheckIn.EfetuarCheckOut(alojamentoId);
        }

        //Guardar Dados
        public bool GuardarDados()
        {
            return GereDados.GravarDados();
        }

        //Carregar Dados
        public bool CarregarDados()
        {
            return GereDados.CarregarDados();
        }
    }
}
