/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe de Serviço de Registo de Cliente ligado ao GestaoAlojamentos.DA
*/

using GestaoAlojamentos.DA;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAlojamentos.BO
{
    public class ServicoDeRegistoCliente
    {
        #region Attributes
        #endregion

        #region Constructors
        public ServicoDeRegistoCliente()
        {
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        #region OtherMethods

        /**
         * Registar Novo Cliente
         * @param nome Nome do Cliente
         * @param nif NIF do Cliente
         * @param nif? Length Comprimento do NIF
         * @return bool Indica se o registo foi bem sucedido
         */
        public bool RegistarNovoCliente(string nome, string nif)
        {
            if (nif?.Length != 9 || Pessoas.ExisteClientePorNif(nif)) return false;

            // Criar objeto temporário Cliente apenas para inserção no DA
            var novoCliente = new Cliente(0, nome, nif);

            return Pessoas.InsereCliente(novoCliente);
        }

        #endregion
        #endregion
    }

}
