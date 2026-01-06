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
            List<Alojamento> disponiveis = new List<Alojamento>();
            foreach (Alojamento a in Hotel.GetInstancia().Alojamentos)
            {
                if (a.Estado == "Disponivel")
                {
                    disponiveis.Add(a);
                }
            }
            return disponiveis;
        }

        // Consultar Alojamentos Reservados
        public List<Alojamento> ConsultarReservados()
        {
            List<Alojamento> reservados = new List<Alojamento>();
            foreach (Alojamento a in Hotel.GetInstancia().Alojamentos)
            {
                if (a.Estado == "Reservado")
                {
                    reservados.Add(a);
                }
            }
            return reservados;
        }

        // Procurar Cliente por NIF
        public Cliente ProcurarClientePorNif(string nif)
        {
            return Pessoas.ProcurarClientePorNif(nif);
        }

        // Consultar Registos Abertos que ainda nao foram finalizados Alugado -> Disponivel
        public List<Registo> ConsultarRegistosAbertos()
        {
            List<Registo> abertos = new List<Registo>();
            foreach (Registo r in Registo.Registos)
            {
                // Verifica se a data de checkout é nula (registo ainda não finalizado)
                if (r.DataCheckOut == null)
                {
                    abertos.Add(r);
                }
            }
            return abertos;
        }

        #endregion
        #endregion
    }

}
