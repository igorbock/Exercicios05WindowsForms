using System;
using System.Windows.Forms;
using ExerciciosException;

namespace Exercicios
{
    public class Exercicio28
    {
        private double ValorX;
        private double ValorY;
        private double ValorZ;
        public double _valorX
        {
            get { return ValorX; }
            set
            {
                try
                {
                    if (value >= double.MinValue && value <= double.MaxValue)
                    {
                        ValorX = value;
                    }
                    else
                    {
                        throw new ExercicioException(7, "O valor não está dentro do esperado");
                    }
                }
                catch(ExercicioException erro)
                {
                    MessageBox.Show($"Um erro aconteceu: {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public double _valorY
        {
            get { return ValorY; }
            set
            {
                try
                {
                    if (value >= double.MinValue && value <= double.MaxValue)
                    {
                        ValorY = value;
                    }
                    else
                    {
                        throw new ExercicioException(7, "O valor não está dentro do esperado");
                    }
                }
                catch(ExercicioException erro)
                {
                    MessageBox.Show($"Um erro aconteceu {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public double _valorZ
        {
            get { return ValorZ; }
            set
            {
                try
                {
                    if (value >= double.MinValue && value <= double.MaxValue)
                    {
                        ValorZ = value;
                    }
                    else
                    {
                        throw new ExercicioException(7, "O valor não está dentro do esperado");
                    }
                }
                catch(ExercicioException erro)
                {
                    MessageBox.Show($"Um erro aconteceu {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public double MediaGeometrica()
        {
            return Math.Pow(ValorX * ValorY * ValorZ, 1 / 3);
        }
        public double MediaPonderada()
        {
            return ValorX + (2 * ValorY) + (3 * ValorZ) / 6;
        }
        public double MediaHarmonica()
        {
            return 1 / (1 / ValorX) + (1 / ValorY) + (1 / ValorZ);
        }
        public double MediaAritmetica()
        {
            return (ValorX + ValorY + ValorZ) / 3;
        }
    }
}
