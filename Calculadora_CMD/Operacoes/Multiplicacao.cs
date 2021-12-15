namespace Calculadora_CMD.Operacoes
{
    internal class Multiplicacao
    {
        public int A { get; set; }
        public int B { get; set; }

        public int Resultado;

        public Multiplicacao(int a, int b)
        {
            A = a;
            B = b;

            Resultado = a * b;
        }
    }
}
