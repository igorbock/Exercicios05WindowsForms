using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public class Exercicio29
    {
        public Exercicio29()
        {
        }
        private int Numero1;
        private int Numero2;
        public int _numero1
        {
            get { return Numero1; }
            set { Numero1 = value; }
        }
        public int _numero2
        {
            get { return Numero2; }
            set { Numero2 = value; }
        }
        public void gerarNumeros()
        {
            Random random = new Random();
            _numero1 = random.Next(1, 100);
            _numero2 = random.Next(1, 100);
        }
    }
}
