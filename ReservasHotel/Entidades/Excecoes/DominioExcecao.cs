using System;

//exceção personalizada
namespace ReservasHotel.Entidades.Excecoes
{
    class DominioExcecao : ApplicationException
    {
        public DominioExcecao(string mensagem) : base (mensagem)
        {
        }
    }
}
