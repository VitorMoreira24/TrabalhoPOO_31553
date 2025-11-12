/**
 * Trabalho de POO
 * @author Vitor Moreira - 31553
 * @version 1.0
 * Classe reservas que herda da classe registos
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO_31553
{
    public class reservas : registos
    {
        #region Atributos

        private int clienteId;
        private int alojamentoId;
        private DateTime dataCheckIn;
        private DateTime dataCheckOut;

        #endregion

        #region Methods

        #region Construtores

        /**
         * Construtor da classe reservas
         * @param idRegisto Identificador do registo
         * @param dataRegisto Data do registo
         * @param descricaoRegisto Descricao do registo
         * @param clienteId Identificador do cliente
         * @param alojamentoId Identificador do alojamento
         * @param dataCheckIn Data de check-in
         * @param dataCheckOut Data de check-out
         * base: Chama o construtor da classe base registos
         * this: Refere-se aos atributos da classe reservas
         */
        public reservas(int idRegisto, DateTime dataRegisto, string descricaoRegisto,
                        int clienteId, int alojamentoId, 
                        DateTime dataCheckIn, DateTime dataCheckOut)
            : base(idRegisto, dataRegisto, descricaoRegisto)
        {
            this.clienteId = clienteId;
            this.alojamentoId = alojamentoId;
            this.dataCheckIn = dataCheckIn;
            this.dataCheckOut = dataCheckOut;
        }

        #endregion

        #region Propriedades

        /** Propriedade ClienteId
         * get: Retorna o identificador do cliente
         * set: Define o identificador do cliente
         */
        public int ClienteId
        {
            get { return clienteId; }
            set { clienteId = value; }

        }
        /** Propriedade AlojamentoId
         * get: Retorna o identificador do alojamento
         * set: Define o identificador do alojamento
         */
        public int AlojamentoId
        {
            get { return alojamentoId; }
            set { alojamentoId = value; }
        }
        /** Propriedade DataCheckIn
         * get: Retorna a data de check-in
         * set: Define a data de check-in
         */
        public DateTime DataCheckIn
        {
            get { return dataCheckIn; } 
            set { dataCheckIn = value; }

        }
        /** Propriedade DataCheckOut
         * get: Retorna a data de check-out
         * set: Define a data de check-out
         */
        public DateTime DataCheckOut { 
            get { return dataCheckOut; } 
            set { dataCheckOut = value; }
        }

        #endregion
        #endregion
    }
}
