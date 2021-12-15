﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_CMD.Operacoes
{
    internal class Potencia
    {
        public int A { get; set; }
        public int B { get; set; }

        public float Resultado;

        public Potencia(int a, int b)
        {
            A = a;
            B = b;

            Resultado = (float)Math.Pow(a, b);
        }
    }
}
