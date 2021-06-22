using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosException
{
    public class ExercicioException : Exception
    {
        public ExercicioException(int codigo, string mensagem) : base($". Código do erro: {codigo}. Mensagem: {mensagem}")
        {

        }
    }
}
