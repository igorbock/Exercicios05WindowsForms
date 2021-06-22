using ExerciciosException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Exercicio26
    {
        public Exercicio26(decimal km, decimal litros)
        {
            KmRodados = km;
            LitrosCombustivel = litros;
        }
        private decimal KmRodados;
        private decimal LitrosCombustivel;
        public decimal _kmRodados
        {
            get { return KmRodados; }
            set
            {
                if(value >= decimal.MinValue && value <= decimal.MaxValue)
                {
                    KmRodados = value;
                }
                else
                {
                    throw new ExercicioException(1, "Erro ");
                }
            }
        }
        public string CalculoConsumo()
        {
            if(KmRodados / LitrosCombustivel < 8)
            {
                return "Venda o carro!";
            }else if(KmRodados / LitrosCombustivel >= 8 && KmRodados / LitrosCombustivel < 14)
            {
                return "Econômico!";
            }else
            {
                return "Super econômico!";
            }
        }
    }
}
