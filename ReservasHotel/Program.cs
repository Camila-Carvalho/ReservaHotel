using System;
using ReservasHotel.Entidades;
using ReservasHotel.Entidades.Excecoes;

namespace ReservasHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                Console.Write("Data de Check-In: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-Out: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                Reserva reserva = new Reserva(numQuarto, checkIn, checkOut);
                Console.WriteLine("Dados da reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Informe as datas para atualização: ");
                Console.Write("Data de Check-In: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-Out: ");
                checkOut = DateTime.Parse(Console.ReadLine());
                reserva.AtualizaReserva(checkIn, checkOut);
                Console.WriteLine("Dados da reserva atualizada: " + reserva);
            }
            catch(DominioExcecao excecao) //para capturar as exceções que estão na classe
            {
                Console.WriteLine("Erro na reserva! " + excecao.Message);
            }
            catch(FormatException excecao)//para capturar as exceções genericas de formato, ou seja, se a pessoa digitar letras ao invés de dataacusa este erro
            {
                Console.WriteLine("Erro na reserva! " + excecao.Message);
            }
            catch(Exception excecao)//para capturar qualquer tipo de exceção que possa ocorrer, algo não previsto, utilizado para o sistema não "quebrar"
            {
                Console.WriteLine("Erro na resserva! " + excecao.Message);
            }
        }
    }
}
