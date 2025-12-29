/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe de Serviço de Check-In e Check-Out ligado ao GestaoAlojamentos.DA
*/

using GestaoAlojamentos.DA;
using GestaoAlojamentos.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAlojamentos.BO
{
    public class ServicoDeCheckIn
    {
        #region Attributes
        #endregion

        #region Constructors
        public ServicoDeCheckIn()
        {
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        #region OtherMethods

        // Efetuar Check-in: Reservado/Disponivel -> Alugado: insere em Registoss
        public bool EfetuarCheckIn(int alojamentoId, string clienteNif)
        {
            var alojamento = Alojamento.ProcurarPorId(alojamentoId);
            var cliente = Pessoas.ProcurarClientePorNif(clienteNif);

            if (alojamento == null) throw new AlojamentoNaoEncontradoException(alojamentoId);
            if (cliente == null) throw new Exception("Cliente não encontrado.");
            if (alojamento.Estado == "Alugado") throw new AlojamentoOcupadoException(alojamentoId);

            Alojamento.AtualizarEstado(alojamentoId, "Alugado");
            return Registo.InsereRegisto(alojamentoId, cliente.Id);
        }

        // Efetuar Check-out: Alugado -> Disponivel E finaliza Registo
        public bool EfetuarCheckOut(int alojamentoId)
        {
            //Procura Alojamento
            var alojamento = Alojamento.ProcurarPorId(alojamentoId);

            if (alojamento == null || alojamento.Estado != "Alugado") return false;

            if (!Registo.FinalizarRegisto(alojamentoId)) return false;

            return Alojamento.AtualizarEstado(alojamentoId, "Disponivel");
        }

        #endregion
        #endregion
    }
}
