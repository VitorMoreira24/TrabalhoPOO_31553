/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe Cliente que herda de Pessoas
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAlojamentos.DA
{
    public class Cliente : Pessoas
    {
        #region Attributes

        /**
         * Atributo NIF do Cliente
         * @param private string nif NIF do Cliente
         */

        private string nif;
        #endregion

        #region Constructors

        /**
         * Construtor da Classe Cliente
         * @param int id Id do Cliente
         * @param string nome Nome do Cliente
         * @param string nif NIF do Cliente
         */
        public Cliente() { }

        public Cliente(int id, string nome, string nif) : base(id, nome)
        {
            this.nif = nif;
        }
        #endregion

        #region Properties
        public string NIF { 
            get { return nif; } 
            set { nif = value; } 
        }
        #endregion

        #region Methods
        #region OtherMethods
        #endregion
        #endregion
    }

}
