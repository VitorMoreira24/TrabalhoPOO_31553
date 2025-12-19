/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe de Serviço de Consultas ligado ao GestaoAlojamentos.DA
*/

using GestaoAlojamentos.DA;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAlojamentos.BO
{
    public class ServicoDeConsultas
    {
        #region Attributes
        #endregion

        #region Constructors
        public ServicoDeConsultas()
        {
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        #region OtherMethods

        // Consultar Alojamentos Disponiveis
        public List<Alojamento> ConsultarDisponiveis()
        {
            return Alojamento.Alojamentos.Where(a => a.Estado == "Disponivel").ToList();
        }

        // Consultar Alojamentos Reservados
        public List<Alojamento> ConsultarReservados()
        {
            return Alojamento.Alojamentos.Where(a => a.Estado == "Reservado").ToList();
        }

        // Procurar Cliente por NIF
        public Cliente ProcurarClientePorNif(string nif)
        {
            return Pessoas.ProcurarClientePorNif(nif);
        }

        // Consultar Registos Abertos que ainda nao foram finalizados Alugado -> Disponivel
        public List<Registo> ConsultarRegistosAbertos()
        {
            return Registo.Registos.Where(r => r.DataCheckOut == null).ToList();
        }

        #endregion
        #endregion
    }

}
