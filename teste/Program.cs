/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe principal da aplicação
*/

// Importa o namespace do Controller
using GestaoAlojamentos.Controller;
using GestaoAlojamentos.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentos.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia o controlador do hotel
            var controller = new HotelController();


            //carregar dados com json pois a .net 8 removeu o binaryformatter
            // Tentar carregar os dados do ficheiro JSON
            try
            {
                if (controller.CarregarDados())
                {
                    Console.WriteLine("-> Dados carregados com sucesso.");
                }
            }
            catch (FicheiroNaoEncontradoException)
            {
                // Não é um erro crítico, apenas significa que é a primeira vez que corre
                Console.WriteLine("-> Ficheiro não encontrado. A iniciar sistema vazio.");
            }
            catch (ErroDerivadoException ex)
            {
                // Erro real (ex: ficheiro corrompido)
                Console.WriteLine($"-> Erro ao carregar dados: {ex.Message}");
            }

            //Inicia o procedimento normal

            Console.WriteLine($"Bem-vindo ao sistema de gestão do {controller.GereHotel().Nome}!");
            Console.WriteLine("--------------------------------------------");

            // 1. REGISTAR NOVO CLIENTE
            Console.WriteLine("REGISTO DE CLIENTE:");

            // Regista um novo cliente chamando a funcao do Controlador
            if (controller.RegistarCliente("Carlos Santos", "999888777"))
            {
                Console.WriteLine("-> Cliente registado com sucesso.");
                try
                {
                    controller.GuardarDados(); // Grava após alteração
                }
                catch (ErroDerivadoException ex)
                {
                    Console.WriteLine($"-> Erro ao guardar: {ex.Message}");
                }
            }

            // 2. CONSULTAR DISPONIBILIDADE
            Console.WriteLine("\nCONSULTA DE ALOJAMENTOS DISPONÍVEIS:");

            // Chama a funcao do Controlador para obter a lista de alojamentos disponiveis
            var disponiveis = controller.MostrarDisponiveis();

            // Mostra os alojamentos disponiveis
            foreach (var a in disponiveis)
            {
                Console.WriteLine($"-> ID: {a.AlojamentoId}, Tipo: {a.Tipo}");
            }

            if (disponiveis.Count > 0)
            {
                int idParaCheckIn = disponiveis[0].AlojamentoId;

                // 3. EFETUAR CHECK-IN
                Console.WriteLine($"\nPROCESSAR CHECK-IN para o Alojamento ID {idParaCheckIn}:");

                if (controller.ProcessarCheckIn(idParaCheckIn, "999888777"))
                {
                    Console.WriteLine($"-> Check-in efetuado com sucesso! Alojamento {idParaCheckIn} está agora Alugado.");
                    try
                    {
                        controller.GuardarDados(); // Grava após alteração
                    }
                    catch (ErroDerivadoException ex)
                    {
                        Console.WriteLine($"-> Erro ao guardar: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"-> ERRO ao efetuar Check-in (Verifique o estado ou NIF).");
                }

                // 4. EFETUAR CHECK-OUT
                Console.WriteLine($"\nPROCESSAR CHECK-OUT para o Alojamento ID {idParaCheckIn}:");

                if (controller.ProcessarCheckOut(idParaCheckIn))
                {
                    Console.WriteLine($"-> Check-out efetuado com sucesso! Alojamento {idParaCheckIn} está novamente Disponivel.");
                    try
                    {
                        controller.GuardarDados(); // Grava após alteração
                    }
                    catch (ErroDerivadoException ex)
                    {
                        Console.WriteLine($"-> Erro ao guardar: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNão existem alojamentos disponíveis para Check-in.");
            }

            Console.WriteLine("\nEncerrando...");
            Console.ReadKey(); 
        }
    }
}
