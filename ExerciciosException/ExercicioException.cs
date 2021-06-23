using System;

namespace ExerciciosException
{
    public class ExercicioException : Exception
    {
        public ExercicioException(int codigo, string mensagem) : base($". Código do erro: {codigo}. Mensagem: {mensagem}")
        {

        }
    }
}
