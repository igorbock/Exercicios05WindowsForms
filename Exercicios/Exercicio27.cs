using ExerciciosException;

namespace Exercicios
{
    public class Exercicio27
    {
        private int Idade;
        public int _idade
        {
            get { return Idade; }
            set
            {
                if(value >= int.MinValue && value <= int.MaxValue)
                {
                    Idade = value;
                }
                else
                {
                    throw new ExercicioException(4, "Erro no valor digitado");
                }
            }
        }
        public string CalcularIdade()
        {
            if(Idade >= 5 && Idade <= 7)
            {
                return "Infantil A --- 5 a 7 anos";
            }
            else if(Idade >= 8 && Idade <= 10)
            {
                return "Infantil B --- 8 a 10 anos";
            }
            else if(Idade >= 11 && Idade <= 13)
            {
                return "Juvenil A --- 11 a 13 anos";
            }
            else if(Idade >= 14 && Idade <= 17)
            {
                return "Juvenil B --- 14 a 17 anos";
            }
            else if(Idade >= 18)
            {
                return "Senior";
            }
            else
            {
                return "O atleta ainda não tem idade.";
            }
        }
    }
}
