/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe de Registo
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using GestaoAlojamentos.Exceptions;

namespace GestaoAlojamentos.DA
{
    public class GereDados
    {
        const string FILE_NAME = "dados_hotel.json";

        public static bool GravarDados()
        {
            try
            {
                // Criamos um objeto temporário que guarda as nossas 3 listas
                var todasAsListas = new DadosParaGuardar
                {
                    ListaAlojamentos = Alojamento.Alojamentos,
                    ListaClientes = Pessoas.Clientes,
                    ListaRegistos = Registo.Registos
                };

                // Converte para texto JSON
                string jsonString = JsonSerializer.Serialize(todasAsListas, new JsonSerializerOptions { WriteIndented = true });

                // Grava o texto no ficheiro
                File.WriteAllText(FILE_NAME, jsonString);

                return true;
            }
            catch (Exception ex)
            {
                throw new ErroDerivadoException("gravar", ex.Message);
            }
        }

        public static bool CarregarDados()
        {
            if (!File.Exists(FILE_NAME)) return false;

            try
            {
                string jsonString = File.ReadAllText(FILE_NAME);

                // Lê o texto e converte de volta para o objeto das listas
                var dados = JsonSerializer.Deserialize<DadosParaGuardar>(jsonString);

                if (dados != null)
                {
                    Alojamento.Alojamentos.Clear();
                    Alojamento.Alojamentos.AddRange(dados.ListaAlojamentos);

                    Pessoas.Clientes.Clear();
                    Pessoas.Clientes.AddRange(dados.ListaClientes);

                    Registo.Registos.Clear();
                    Registo.Registos.AddRange(dados.ListaRegistos);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new ErroDerivadoException("carregar", ex.Message);
            }
        }
    }

    // Classe auxiliar para organizar os dados no ficheiro JSON
    public class DadosParaGuardar
    {
        public List<Alojamento> ListaAlojamentos { get; set; }
        public List<Cliente> ListaClientes { get; set; }
        public List<Registo> ListaRegistos { get; set; }
    }
}
