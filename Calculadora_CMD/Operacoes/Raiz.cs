using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_CMD.Operacoes
{
    internal class Raiz
    {
        public int A { get; set; }

        public float resultado;

        public Raiz(int a)
        {
            A = a;

            resultado = (float)Math.Sqrt(a);
        }
    }
}
