using System;
using System.Windows.Forms;
using Exercicios;
using ExerciciosException;

namespace ExerciciosCSharp05TryCatchWindowsForms
{
    public partial class Exercicios : Form
    {
        int interacao = 1;
        int acertos = 0;
        int valor = 1;
        Exercicio29 exercicio29 = new Exercicio29();
        Exercicio30 exercicio30 = new Exercicio30();
        public Exercicios()
        {
            InitializeComponent();

            exercicio29.gerarNumeros();
            label9.Text = $"Questão {interacao}";
            textBox8.Text = exercicio29._numero1.ToString();
            textBox9.Text = exercicio29._numero2.ToString();
            label11.Text = $"Valor {valor}";
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

        private void button3_Click(object sender, EventArgs e)
        {
            var exercicio28 = new Exercicio28();
            try
            {
                if(double.TryParse(textBox5.Text, out double result1))
                {
                    exercicio28._valorX = result1;
                }
                else
                {
                    throw new ExercicioException(8, $"Valor \"{textBox5.Text}\" no formato incorreto. São aceitos somente números");
                }
                if (double.TryParse(textBox6.Text, out double result2))
                {
                    exercicio28._valorY = result2;
                }
                else
                {
                    throw new ExercicioException(8, $"Valor \"{textBox6.Text}\" no formato incorreto. São aceitos somente números");
                }
                if (double.TryParse(textBox7.Text, out double result3))
                {
                    exercicio28._valorZ = result3;
                }
                else
                {
                    throw new ExercicioException(8, $"Valor \"{textBox7.Text}\" no formato incorreto. São aceitos somente números");
                }

                if (radioButton1.Checked)
                {
                    MessageBox.Show($"Resultado: {exercicio28.MediaGeometrica().ToString()}", "Média geométrica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioButton2.Checked)
                {
                    MessageBox.Show($"Resultado: {exercicio28.MediaPonderada().ToString()}", "Média ponderada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioButton3.Checked)
                {
                    MessageBox.Show($"Resultado: {exercicio28.MediaHarmonica().ToString()}", "Média harmonica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioButton4.Checked)
                {
                    MessageBox.Show($"Resultado: {exercicio28.MediaAritmetica().ToString()}", "Média aritmética", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha uma média para o cálculo", "Faltou", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (ExercicioException erro)
            {
                MessageBox.Show($"Um erro aconteceu {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox10.Text, out int result))
                {
                    //var exercicio29 = new Exercicio29();
                    
                    textBox10.Text = "";
                    interacao++;

                    if (interacao <= 5)
                    {
                        //textBox8.Text = exercicio29._numero1.ToString();
                        //textBox9.Text = exercicio29._numero2.ToString();                        

                        if (int.Parse(textBox8.Text) + int.Parse(textBox9.Text) == result)
                        //if(exercicio29._numero1 + exercicio29._numero2 == result)
                        {
                            acertos += 1;
                        }
                        exercicio29.gerarNumeros();
                        textBox8.Text = exercicio29._numero1.ToString();
                        textBox9.Text = exercicio29._numero2.ToString();
                        
                        label10.Text = $"Acertos {acertos}";
                        label9.Text = $"Questão {interacao}";
                    }
                    else
                    {
                        if (int.Parse(textBox8.Text) + int.Parse(textBox9.Text) == result)
                        {
                            acertos += 1;
                        }
                        label10.Text = $"Acertos {acertos}";
                        MessageBox.Show($"Voce já respondeu 5 questões. Acertou {acertos}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        interacao = 1;
                        label9.Text = $"Questão {interacao}";
                        acertos = 0;
                        label10.Text = $"Acertos {acertos}";
                        exercicio29.gerarNumeros();
                        textBox8.Text = exercicio29._numero1.ToString();
                        textBox9.Text = exercicio29._numero2.ToString();
                    }
                }
                else
                {
                    throw new ExercicioException(10, $"O campo de respostas só aceita valores numericos e não pode estar vazio. \"{textBox10.Text}\" não é válido");
                }
            }
            catch(ExercicioException erro)
            {
                MessageBox.Show($"Um erro aconteceu {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exercicio30_Click(object sender, EventArgs e)
        {
            try
            {
                switch (valor)
                {
                    case 1:
                        if (double.TryParse(textBox11.Text, out double result1))
                        {
                            exercicio30._numero1 = result1;
                            valor++;
                            label11.Text = $"Valor {valor}";
                        }
                        else
                        {
                            throw new ExercicioException(12, $"O valor deve ser numerico e não pode estar vazio. \"{textBox11.Text}\" não é válido");
                        }
                        break;
                    case 2:
                        if (double.TryParse(textBox11.Text, out double result2) && valor.Equals(2))
                        {
                            exercicio30._numero2 = result2;
                            valor++;
                            label11.Text = $"Valor {valor}";
                        }
                        else
                        {
                            throw new ExercicioException(12, $"O valor deve ser numerico e não pode estar vazio. \"{textBox11.Text}\" não é válido");
                        }
                        break;
                    case 3:
                        if (double.TryParse(textBox11.Text, out double result) && valor.Equals(3))
                        {
                            exercicio30._numero3 = result;
                            label11.Text = $"Valor {valor}";
                            valor = 1;
                            double[] resultado = exercicio30.ordemCrescente();
                            MessageBox.Show($"A ordem crescente dos valores é: \n\n{resultado[0]}\n{resultado[1]}\n{resultado[2]}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new ExercicioException(12, $"O valor deve ser numerico e não pode estar vazio. \"{textBox11.Text}\" não é válido");
                        }
                        break;
                }
            }
            catch(ExercicioException erro)
            {
                MessageBox.Show($"Um erro aconteceu --> {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
