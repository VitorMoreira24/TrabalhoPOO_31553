/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe de Dados de Pessoas
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAlojamentos.DA
{
    public class Pessoas
    {
        #region Attributes

        /**
         * Atributos da classe Pessoas
         * @param id Identificador único da Pessoa
         * @param nome Nome da Pessoa
         * @param clientes Lista estática de Clientes
         * @param nextClienteId Identificador único para o próximo Cliente a ser adicionado 
         */

        private int id;
        private string nome;
        private static List<Cliente> clientes = new List<Cliente>();
        private static int nextClienteId = 1; //(REVER)
        #endregion

        #region Constructors

        /**
         * Construtor da classe Pessoas
         * @param id Identificador único da Pessoa
         * @param nome Nome da Pessoa
         */
        public Pessoas() { }
        public Pessoas(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        /**
         * Construtor estático para inicializar a lista de Clientes com um Cliente padrão
         */
        static Pessoas()
        {
            clientes.Add(new Cliente(nextClienteId++, "Ana Maria", "111222333"));
            clientes.Add(new Cliente(nextClienteId++, "Roberto Andrade", "111222444"));
        }
        #endregion

        #region Properties
        public int Id { 
            get { return id; } 
            set { id = value; } 
        }
        public string Nome { 
            get { return nome; } 
            set { nome = value; } 
        }

        /**
         * Propriedade estática para acessar a lista de Clientes
         */
        public static List<Cliente> Clientes { get { return clientes; } }
        #endregion

        #region Methods
        #region OtherMethods

        /**
         * Verifica se um Cliente existe pelo seu NIF
         * @param nif NIF do Cliente a ser verificado
         * @param Any Indica se o Cliente existe
         * @return bool Indica se o Cliente existe
         */

        public static bool ExisteClientePorNif(string nif)
        {
            foreach (Cliente c in clientes)
            {
                if (c.NIF == nif)
                {
                    return true; // Encontrou, logo existe
                }
            }
            return false; // Percorreu tudo e não encontrou
        }

        /**
         * Procura um Cliente pelo seu NIF
         * @param nif NIF do Cliente a ser procurado
         * @FirstOrDefault Retorna o primeiro Cliente encontrado ou null
         * @return Cliente Retorna o Cliente encontrado ou null se não existir
         */

        public static Cliente ProcurarClientePorNif(string nif)
        {
            foreach (Cliente c in clientes)
            {
                if (c.NIF == nif)
                {
                    // Se encontrou, retorna o objeto Cliente imediatamente
                    return c;
                }
            }

            // Se o ciclo terminar e não encontrar nada, retorna null
            return null;
        }

        /**
         * Insere um novo Cliente na lista de Clientes
         * @param cliente Cliente a ser inserido
         * @return bool Indica se o Cliente foi inserido com sucesso
         */

        public static bool InsereCliente(Cliente cliente)
        {
            if (ExisteClientePorNif(cliente.NIF)) return false;
            cliente.Id = nextClienteId++;
            clientes.Add(cliente);
            return true;
        }
        #endregion
        #endregion
    }
}
