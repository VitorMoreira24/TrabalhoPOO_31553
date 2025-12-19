/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe de Serviço de Check-In e Check-Out ligado ao GestaoAlojamentos.DA
*/

using GestaoAlojamentos.DA;
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

        // Efetuar Check-in: Reservado/Disponivel -> Alugado: insere em Registos
        public bool EfetuarCheckIn(int alojamentoId, string clienteNif)
        {
            //Procura Alojamento e Cliente
            var alojamento = Alojamento.ProcurarPorId(alojamentoId);
            var cliente = Pessoas.ProcurarClientePorNif(clienteNif);

            // Regras de Negócio
            if (alojamento == null || cliente == null || alojamento.Estado == "Alugado") return false;

            if (alojamento.Estado == "Disponivel" || alojamento.Estado == "Reservado")
            {
                // Atualiza Estado do Alojamento para Alugado
                Alojamento.AtualizarEstado(alojamentoId, "Alugado");
                return Registo.InsereRegisto(alojamentoId, cliente.Id);
            }

            return false;
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
