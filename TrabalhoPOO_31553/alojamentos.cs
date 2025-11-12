/**
 * Trabalho de POO
 * @author Vitor Moreira - 31553
 * @version 1.0
 * Classe alojamentos que representa os alojamentos do sistema
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO_31553
{
    public class alojamentos
    {
        #region Atributos

        private int id;
        private string nome;
        private string localizacao;
        private int precoPorNoite;

        #endregion

        #region Methods

        #region Construtores


        /**
         * Construtor da classe alojamentos
         * @param id Identificador do alojamento
         * @param nome Nome do alojamento
         * @param localizacao Localizacao do alojamento
         * @param precoPorNoite Preco por noite do alojamento
         * this: Refere-se aos atributos da classe alojamentos
         */
        public alojamentos(int id, string nome, string localizacao, int precoPorNoite)
        {
            this.id = id;
            this.nome = nome;
            this.localizacao = localizacao;
            this.precoPorNoite = precoPorNoite;
        }

        #endregion

        #region Propriedades

        /** Propriedade Id
         * get: Retorna o identificador do alojamento
         * set: Define o identificador do alojamento
         */
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /** Propriedade Nome
         * get: Retorna o nome do alojamento
         * set: Define o nome do alojamento
         */
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /** Propriedade Localizacao
         * get: Retorna a localizacao do alojamento
         * set: Define a localizacao do alojamento
         */
        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        /** Propriedade PrecoPorNoite
         * get: Retorna o preco por noite do alojamento
         * set: Define o preco por noite do alojamento
         */
        public int PrecoPorNoite
        {
            get { return precoPorNoite; }
            set { precoPorNoite = value; }
        }
        #endregion
        #endregion
    }
}
