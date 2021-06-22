using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercicios;

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
            var kms = decimal.Parse(textBox1.Text);
            var litrosCombustivel = decimal.Parse(textBox2.Text);
            Exercicio26 exercicio = new Exercicio26(kms,litrosCombustivel);
            textBox3.Text = exercicio.CalculoConsumo();
        }
    }
}
