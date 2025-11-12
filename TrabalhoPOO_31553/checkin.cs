/**
 * Trabalho de POO
 * @author Vitor Moreira - 31553
 * @version 1.0
 * Classe checkin que herda da classe registos
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO_31553
{
    public class checkin : registos
    {
        #region Atributos

        private int reservaId;
        private DateTime horaCheckIn;

        #endregion

        #region Methods

        #region Construtores

        /**
         * Construtor da classe checkin
         * @param idRegisto Identificador do registo
         * @param dataRegisto Data do registo
         * @param descricaoRegisto Descricao do registo
         * @param reservaId Identificador da reserva
         * @param horaCheckIn Hora do check-in
         * base: Chama o construtor da classe base registos
         * this: Refere-se aos atributos da classe checkin
         */
        public checkin(int idRegisto, DateTime dataRegisto, string descricaoRegisto,
                       int reservaId, DateTime horaCheckIn)
            : base(idRegisto, dataRegisto, descricaoRegisto)
        {
            this.reservaId = reservaId;
            this.horaCheckIn = horaCheckIn;
        }

        #endregion

        #region Propriedades

        /** Propriedade ReservaId
         * get: Retorna o identificador da reserva
         * set: Define o identificador da reserva
         */
        public int ReservaId
        {
            get { return reservaId; }
            set { reservaId = value; }
        }

        /** Propriedade HoraCheckIn
         * get: Retorna a hora do check-in
         * set: Define a hora do check-in
         */
        public DateTime HoraCheckIn
        {
            get { return horaCheckIn; } 
            set { horaCheckIn = value; }

        }

        #endregion
        #endregion
    }
}
