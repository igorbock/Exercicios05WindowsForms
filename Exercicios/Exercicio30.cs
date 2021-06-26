using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosException;

namespace Exercicios
{
    public class Exercicio30
    {
        private double Numero1;
        private double Numero2;
        private double Numero3;
        public double _numero1
        {
            get { return Numero1; }
            set
            {
                if(value >= double.MinValue && value <= double.MaxValue)
                {
                    Numero1 = value;
                }
                else
                {
                    throw new ExercicioException(11, $"O valor {value} não é válido");
                }
            }
        }
        public double _numero2
        {
            get { return Numero2; }
            set
            {
                if(value >= double.MinValue && value <= double.MaxValue)
                {
                    Numero2 = value;
                }
                else
                {
                    throw new ExercicioException(11, $"O valor {value} não é válido");
                }
            }
        }
        public double _numero3
        {
            get { return Numero3; }
            set
            {
                if(value >= double.MinValue && value <= double.MaxValue)
                {
                    Numero3 = value;
                }
                else
                {
                    throw new ExercicioException(11, $"O valor {value} não é válido");
                }
            }
        }
        public double[] ordemCrescente()
        {
            double[] ordem = new double[3];
            if(_numero1 < _numero2 && _numero1 < _numero3 && _numero2 < _numero3)
            {
                ordem[0] = _numero1;
                ordem[1] = _numero2;
                ordem[2] = _numero3;
                return ordem;
            }
            else if(_numero2 < _numero1 && _numero2 < _numero3 && _numero3 < _numero1)
            {
                ordem[0] = _numero2;
                ordem[1] = _numero3;
                ordem[2] = _numero1;
                return ordem;
            }
            else
            {
                ordem[0] = _numero3;
                ordem[1] = _numero1;
                ordem[2] = _numero3;
                return ordem;
            }
        }
    }
}
