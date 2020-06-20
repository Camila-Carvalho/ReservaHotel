using System;
using ReservasHotel.Entidades.Excecoes;

namespace ReservasHotel.Entidades
{
    class Reserva
    {
        public int NumQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        public Reserva()
        {
        }

        public Reserva(int numQuarto, DateTime checkIn, DateTime checkOut)
        {
            NumQuarto = numQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        //para calcular a duração de dias, pois as variaveis são em date
        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn); //operação para ter a duração dos dias
            return (int)duracao.TotalDays; //retornar a duração em inteiro usando o TotalDays
        }
       
        public void AtualizaReserva(DateTime checkIn, DateTime checkOut)
        {
            //aplicar exceção no método para tratamento
            DateTime dataAtual = DateTime.Now;
            if (checkOut <= checkIn)
            {
                throw new DominioExcecao("Não foi possível lançar a atualização! Data Check-Out menor que data Check-In."); //lança uma nova exceção informando a mensagem
            }
            else if (checkIn < dataAtual || checkOut < dataAtual)
            {
                throw new DominioExcecao("Não foi possível lançar a atualização! Necessário informar datas futuras.");
            }
            //se não tiver nenhuma exceção, atualiza as datas
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Reserva: Quarto {NumQuarto}, Check-in: {CheckIn:(dd/MM/yyyy)}, Check-out: {CheckOut:(dd/MM/yyyy)}, {Duracao()} noites.";
        }

    }
}
