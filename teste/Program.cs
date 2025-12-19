/**
* Trabalho de POO
* @author Vitor Moreira - 31553
* @version 1.0
* Classe principal da aplicação
*/

// Importa o namespace do Controller
using GestaoAlojamentos.Controller;
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

            Console.WriteLine($"Bem-vindo ao sistema de gestão do {controller.GereHotel().Nome}!");
            Console.WriteLine("--------------------------------------------");

            // 1. REGISTAR NOVO CLIENTE
            Console.WriteLine("REGISTO DE CLIENTE:");

            // Regista um novo cliente chamando a funcao do Controlador
            if (controller.RegistarCliente("Carlos Santos", "999888777"))
            {
                Console.WriteLine("-> Cliente registado com sucesso.");
            }

            // 2. CONSULTAR DISPONIBILIDADE
            Console.WriteLine("\nCONSULTA DE ALOJAMENTOS DISPONÍVEIS:");

            // Chama a funcao do Controlador para obter a lista de alojamentos disponiveis
            var disponiveis = controller.MostrarDisponiveis();

            // Mostra os alojamentos disponiveis (REVER)
            disponiveis.ForEach(a => Console.WriteLine($"-> ID: {a.AlojamentoId}, Tipo: {a.Tipo}"));

            int idParaCheckIn = disponiveis.First().AlojamentoId; // Usamos o primeiro disponível

            // 3. EFETUAR CHECK-IN
            Console.WriteLine($"\nPROCESSAR CHECK-IN para o Alojamento ID {idParaCheckIn}:");

            // Chama a funcao do Controlador para processar o check-in
            if (controller.ProcessarCheckIn(idParaCheckIn, "999888777"))
            {
                Console.WriteLine($"-> Check-in efetuado com sucesso! Alojamento {idParaCheckIn} está agora Alugado.");
            }
            else
            {
                Console.WriteLine($"-> ERRO ao efetuar Check-in (Verifique o estado ou NIF).");
            }

            // 4. EFETUAR CHECK-OUT
            Console.WriteLine($"\nPROCESSAR CHECK-OUT para o Alojamento ID {idParaCheckIn}:");

            // Chama a funcao do Controlador para processar o check-out
            if (controller.ProcessarCheckOut(idParaCheckIn))
            {
                Console.WriteLine($"-> Check-out efetuado com sucesso! Alojamento {idParaCheckIn} está novamente Disponivel.");
            }

            Console.WriteLine("\nFim da simulação.");
        }
    }
}
