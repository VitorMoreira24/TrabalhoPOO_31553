/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe de Alojamento do DA
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAlojamentos.DA
{
    public class Alojamento
    {
        #region Attributes

        /**
         *´Atributos da Classe Alojamento
         * @param private int alojamentoId Identificador Único do Alojamento
         * @param private string tipo Tipo do Alojamento (Quarto Simples, Quarto Duplo, Suite, etc)
         * @param private string estado Estado do Alojamento (Disponivel, Reservado, Alugado)
         * @param private static List<Alojamento> alojamentos Lista de Alojamentos
         */

        private int alojamentoId;
        private string tipo;
        private string estado; // Disponivel, Reservado, Alugado
        private static List<Alojamento> alojamentos = new List<Alojamento>();
        #endregion

        #region Constructors

        /**
         * Construtor da Classe Alojamento
         * @param int id Identificador Único do Alojamento
         * @param string tipo Tipo do Alojamento
         * @param string estadoInicial Estado Inicial do Alojamento
         */
        public Alojamento(int id, string tipo, string estadoInicial)
        {
            this.alojamentoId = id;
            this.tipo = tipo;
            this.estado = estadoInicial;
        }

        // Inicialização Estática para adicionar alguns alojamentos iniciais
        static Alojamento()
        {
            alojamentos.Add(new Alojamento(101, "Quarto Duplo", "Disponivel"));
            alojamentos.Add(new Alojamento(102, "Suite Executiva", "Reservado"));
        }
        #endregion

        #region Properties
        public int AlojamentoId { 
            get { return alojamentoId; } 
            set { alojamentoId = value; } 
        }
        public string Estado { 
            get { return estado; } 
            set { estado = value; } 
        }
        public string Tipo { 
            get { return tipo; } 
            set { tipo = value; } 
        }

        // Propriedade para acessar a lista de Alojamentos
        public static List<Alojamento> Alojamentos { get { return alojamentos; } }
        #endregion

        #region Methods
        #region OtherMethods

        // Método DA para procurar Alojamento por Id
        public static Alojamento ProcurarPorId(int id)
        {
            return alojamentos.FirstOrDefault(a => a.AlojamentoId == id);
        }

        // Método DA para atualizar o estado do Alojamento
        public static bool AtualizarEstado(int id, string novoEstado)
        {
            var alojamento = ProcurarPorId(id);
            if (alojamento == null) return false;
            alojamento.Estado = novoEstado;
            return true;
        }
        #endregion
        #endregion
    }

}
