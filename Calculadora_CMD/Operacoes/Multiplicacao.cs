namespace Calculadora_CMD.Operacoes
{
    internal class Multiplicacao
    {
        public double A { get; set; }
        public double B { get; set; }

        public double resultado;

        public Multiplicacao(double a, double b)
        {
            A = a;
            B = b;

            resultado = a * b;
        }
    }
}
