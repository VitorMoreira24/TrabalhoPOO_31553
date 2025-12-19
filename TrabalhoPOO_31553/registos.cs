/**
 * Trabalho de POO
 * @author Vitor Moreira - 31553
 * @version 1.0
 * Classe abstrata registos que serve de base para outras classes filhos de registos
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentos.DA
{
    public abstract class registos
    {
        #region Atributos

        private int idRegisto; 
        private DateTime dataRegisto; 
        private string descricaoRegisto;

        #endregion

        #region Methods

        #region Construtores

        /**
         * Construtor da classe registos
         * @param idRegisto Identificador do registo
         * @param dataRegisto Data do registo
         * @param descricaoRegisto Descricao do registo
         * this: Refere-se aos atributos da classe registos
         */
        protected registos(int idRegisto, DateTime dataRegisto, string descricaoRegisto)
        {
            this.idRegisto = idRegisto;
            this.dataRegisto = dataRegisto;
            this.descricaoRegisto = descricaoRegisto;
        }

        #endregion

        #region Propriedades

        /** Propriedade IdRegisto
         * get: Retorna o identificador do registo
         * set: Define o identificador do registo
         */
        public int IdRegisto
        {
            get { return idRegisto; }
            set { idRegisto = value; }

        }

        /** Propriedade DataRegisto
         * get: Retorna a data do registo
         * set: Define a data do registo
         */
        public DateTime DataRegisto 
        { 
            get { return dataRegisto; } 
            set { dataRegisto = value; }
        }

        /** Propriedade DescricaoRegisto
         * get: Retorna a descricao do registo
         * set: Define a descricao do registoo
         */
        public string DescricaoRegisto
        {
            get { return descricaoRegisto; } 
            set { descricaoRegisto = value; }
        }

        #endregion
        #endregion
    }
}
