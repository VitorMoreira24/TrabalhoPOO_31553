/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe de Registo
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAlojamentos.DA
{
    public class Registo
    {
        #region Attributes

        /**
         * Atributos de Registo
         * @param registoId - Identificador do registo
         * @param alojamentoId - Identificador do alojamento
         * @param clienteId - Identificador do cliente
         * @param DateTime? - ? serve para permitir valores nulos
         * @param dataCheckIn - Data de check-in
         * @param dataCheckOut - Data de check-out
         * @param registos - Lista de registos
         * @param nextRegistoId - Identificador do próximo registo
         */

        private int registoId;
        private int alojamentoId;
        private int clienteId;
        private DateTime dataCheckIn;
        private DateTime? dataCheckOut;
        private static List<Registo> registos = new List<Registo>();
        private static int nextRegistoId = 1;
        #endregion

        #region Constructors

        /**
         * Construtor de Registo
         * @param id - Identificador do registo
         * @param alojamentoId - Identificador do alojamento
         * @param clienteId - Identificador do cliente
         * @param dataCheckIn - Define a data de check-in como a data atual
         */

        public Registo(int id, int alojamentoId, int clienteId)
        {
            this.registoId = id;
            this.alojamentoId = alojamentoId;
            this.clienteId = clienteId;
            this.dataCheckIn = DateTime.Now;
        }
        #endregion

        #region Properties
        public int RegistoId { 
            get { return registoId; } 
        }
        public DateTime? DataCheckOut { 
            get { return dataCheckOut; } 
            set { dataCheckOut = value; } 
        }
        public static List<Registo> Registos { get { return registos; } }
        #endregion

        #region Methods
        #region OtherMethods

        /**
         * Métodos de Registo
         * @param InsereRegisto - Insere um novo registo na lista de registos
         * @param FinalizarRegisto - Finaliza um registo existente, definindo a data de check-out
         */
        public static bool InsereRegisto(int alojamentoId, int clienteId)
        {
            var novoRegisto = new Registo(nextRegistoId++, alojamentoId, clienteId);
            registos.Add(novoRegisto);
            return true;
        }
        public static bool FinalizarRegisto(int alojamentoId)
        {
            Registo registoEncontrado = null;

            foreach (Registo r in registos)
            {
                // Procurar o registo que corresponde ao alojamento e que ainda esteja aberto (CheckOut null)
                if (r.alojamentoId == alojamentoId && r.dataCheckOut == null)
                {
                    registoEncontrado = r;
                    break; // Encontramos o que queríamos, podemos parar o ciclo
                }
            }

            if (registoEncontrado == null)
            {
                return false;
            }

            registoEncontrado.dataCheckOut = DateTime.Now;
            return true;
        }
        #endregion
        #endregion
    }
}
