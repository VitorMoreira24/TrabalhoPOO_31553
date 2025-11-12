/**
 * Trabalho de POO
 * @author Vitor Moreira - 31553
 * @version 1.0
 * Classe consultas que herda da classe registos
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO_31553
{
    public class consultas : registos
    {
        #region Atributos

        private string tipoConsulta;
        private string resultadoConsulta;

        #endregion

        #region Methods

        #region Construtores

        /**
         * Construtor da classe consultas
         * @param idRegisto Identificador do registo
         * @param dataRegisto Data do registo
         * @param descricaoRegisto Descricao do registo
         * @param tipoConsulta Tipo da consulta
         * @param resultadoConsulta Resultado da consulta
         * base: Chama o construtor da classe base registos
         * this: Refere-se aos atributos da classe consultas
         */
        public consultas(int idRegisto, DateTime dataRegisto, string descricaoRegisto,
                         string tipoConsulta, string resultadoConsulta)
            : base(idRegisto, dataRegisto, descricaoRegisto)
        {
            this.tipoConsulta = tipoConsulta;
            this.resultadoConsulta = resultadoConsulta;
        }

        #endregion

        #region Propriedades

        /** Propriedade TipoConsulta
         * get: Retorna o tipo da consulta
         * set: Define o tipo da consulta
         */
        public string TipoConsulta
        {
            get { return tipoConsulta; }
            set { tipoConsulta = value; }
        }
        /** Propriedade ResultadoConsulta
         * get: Retorna o resultado da consulta
         * set: Define o resultado da consulta
         */
        public string ResultadoConsulta
        {
            get { return resultadoConsulta; } 
            set { resultadoConsulta = value; }
        }

        #endregion
        #endregion
    }
}
