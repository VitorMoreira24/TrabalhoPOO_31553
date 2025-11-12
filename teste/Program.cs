using TrabalhoPOO_31553;  // importa o namespace onde estão as tuas classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO_31553
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste de Gestão de Alojamentos ===\n");

            // 1️ Criar um cliente
            clientes cliente = new clientes(1, "João Silva", "joao@gmail.com", "912345678");
            Console.WriteLine($"Cliente criado: {cliente.Nome} ({cliente.Email})");

            // 2️ Criar um alojamento
            alojamentos alojamento = new alojamentos(1, "Casa da Praia", "Albufeira", 120);
            Console.WriteLine($"Alojamento criado: {alojamento.Nome} - {alojamento.Localizacao} - {alojamento.PrecoPorNoite}€/noite");

            // 3️ Criar uma reserva
            reservas reserva = new reservas(
                idRegisto: 1,
                dataRegisto: DateTime.Now,
                descricaoRegisto: "Reserva de 3 noites",
                clienteId: cliente.Id,
                alojamentoId: alojamento.Id,
                dataCheckIn: new DateTime(2025, 11, 15),
                dataCheckOut: new DateTime(2025, 11, 18)
            );

            Console.WriteLine($"\nReserva criada: ID={reserva.IdRegisto}, Cliente={reserva.ClienteId}, Alojamento={reserva.AlojamentoId}");
            Console.WriteLine($"Check-in planeado: {reserva.DataCheckIn:dd/MM/yyyy}");
            Console.WriteLine($"Check-out planeado: {reserva.DataCheckOut:dd/MM/yyyy}");

            // 4️ Fazer um check-in
            checkin checkin = new checkin(
                idRegisto: 10,
                dataRegisto: DateTime.Now,
                descricaoRegisto: "Check-in efetuado",
                reservaId: reserva.IdRegisto,
                horaCheckIn: DateTime.Now
            );

            Console.WriteLine($"\nCheck-in registado para a reserva #{checkin.ReservaId} às {checkin.HoraCheckIn:HH:mm}");

            // 5️ Registar uma consulta
            consultas consulta = new consultas(
                idRegisto: 20,
                dataRegisto: DateTime.Now,
                descricaoRegisto: "Consulta de reservas do cliente João",
                tipoConsulta: "Reservas",
                resultadoConsulta: "1 reserva encontrada"
            );

            Console.WriteLine($"\nConsulta registada:");
            Console.WriteLine($"Tipo: {consulta.TipoConsulta}");
            Console.WriteLine($"Resumo: {consulta.ResultadoConsulta}");

            Console.WriteLine("\n=== Teste concluído ===");
        }
    }
}
