﻿namespace Calculadora_CMD.Operacoes
{
    internal class Divisao
    {
        public double A { get; set; }
        public double B { get; set; }

        public double resultado;

        public Divisao(double a, double b)
        {
            A = a;
            B = b;

            resultado = a / b;
        }

    }
}