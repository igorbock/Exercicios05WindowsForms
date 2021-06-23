using System;
using System.Windows.Forms;
using Exercicios;
using ExerciciosException;

namespace ExerciciosCSharp05TryCatchWindowsForms
{
    public partial class Exercicios : Form
    {
        public Exercicios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var exercicio = new Exercicio26();

            try
            {
                if (decimal.TryParse(textBox1.Text, out decimal resultado1))
                {
                    exercicio._kmRodados = resultado1;
                }
                else
                {
                    throw new ExercicioException(2, $"O campo requer um valor decimal. \"{textBox1.Text}\" não é decimal.");
                }

                if (decimal.TryParse(textBox2.Text, out decimal resultado2))
                {
                    if (!resultado2.Equals(0))
                    {
                        exercicio._litrosCombustivel = resultado2;
                    }
                    else
                    {
                        throw new ExercicioException(3, "Não é possível dividir por zero.");
                    }
                }
                else
                {
                    throw new ExercicioException(2, $"O campo requer um valor decimal. \"{textBox2.Text}\" não é decimal.");
                }

                textBox3.Text = exercicio.CalculoConsumo();
                MessageBox.Show($"Seu carro é {exercicio.CalculoConsumo()}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ExercicioException er)
            {
                MessageBox.Show($"Um erro aconteceu: {er.Message}\n\n\n {er.StackTrace}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exercicio27_Click(object sender, EventArgs e)
        {
            var exercicio27 = new Exercicio27();

            try
            {
                if(int.TryParse(textBox4.Text, out int result))
                {
                    exercicio27._idade = result;
                    MessageBox.Show($"Categoria: {exercicio27.CalcularIdade()}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new ExercicioException(5, $"O campo requer um valor inteiro. \"{textBox4.Text}\" não é inteiro");
                }
            }
            catch(ExercicioException erro)
            {
                MessageBox.Show($"Um erro aconteceu: {erro.Message} \n\n\n{erro.StackTrace}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
