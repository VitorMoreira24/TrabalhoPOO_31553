/**
 * Trabalho de POO
 * @author Vitor Moreira - 31553
 * @version 1.0
 * Classe clientes que representa os clientes do sistema
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentos.DA
{
    public class clientes
    {
        #region Atributos

        private int id;
        private string nome;
        private string email;
        private string telefone;

        #endregion

        #region Methods

        #region Construtores

        /**
         * Construtor da classe clientes
         * @param id Identificador do cliente
         * @param nome Nome do cliente
         * @param email Email do cliente
         * @param telefone Telefone do cliente
         * this: Refere-se aos atributos da classe clientes
         */
        public clientes(int id, string nome, string email, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

        #endregion

        #region Propriedades

        /** Propriedade Id
         * get: Retorna o identificador do cliente
         * set: Define o identificador do cliente
         */
        public int Id {             
            get { return id; }
            set { id = value; }
        }

        /** Propriedade Nome
         * get: Retorna o nome do cliente
         * set: Define o nome do cliente
         */
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /** Propriedade Email
         * get: Retorna o email do cliente
         * set: Define o email do cliente
         */
        public string Email
        {
            get{ return email; }
            set { email = value; }
        }

        /** Propriedade Telefone
         * get: Retorna o telefone do cliente
         * set: Define o telefone do cliente
         */
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        #endregion
        #endregion
    }
}
