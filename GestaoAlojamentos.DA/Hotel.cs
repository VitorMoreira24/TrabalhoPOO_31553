/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe Hotel para a Gestão de Alojamentos
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAlojamentos.DA
{
    public class Hotel
    {
        #region Attributes

        /**
         * Atributos da Classe Hotel
         * @param nome Nome do Hotel
         * @param alojamentos Lista de Alojamentos do Hotel (Hotel TEM Alojamentos)
         * @param instancia Instância única do Hotel (Singleton) para apenas um hotel
         */

        private string nome;
        private List<Alojamento> alojamentos; 
        private static Hotel instancia;
        #endregion

        #region Constructors

        /** Construtor da Classe Hotel
         * Privado para implementar o padrão Singleton
         * @param nome Nome do Hotel
         * @param alojamentos Lista de Alojamentos do Hotel
         */

        private Hotel(string nome) 
        {
            this.nome = nome;
            // O Hotel usa a lista estática existente no Alojamento (DAL)
            this.alojamentos = Alojamento.Alojamentos;
        }
        #endregion

        #region Properties
        public string Nome { 
            get { return nome; } 
            set { nome = value; } 
        }

        /** 
         * Propriedade de Acesso à Lista de Alojamentos do Hotel
         * @return List<Alojamento> Lista de Alojamentos
         */

        public List<Alojamento> Alojamentos { get { return alojamentos; } }

        /**
         * Propriedade de Acesso à Instância Única do Hotel (Singleton)
         * @param instancia Instância do Hotel
         * @return Hotel Instância do Hotel
         */
        public static Hotel GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Hotel("Hotel Central POO");
            }
            return instancia;
        }
        #endregion

        #region Methods
        #region OtherMethods
        // ...
        #endregion
        #endregion
    }

}
