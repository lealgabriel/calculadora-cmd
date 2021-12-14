namespace Calculadora_CMD.Operacoes
{
    internal class Subtracao
    {
        public int A { get; set; }
        public int B { get; set; }

        public int resultado;

        public Subtracao(int a, int b)
        {
            A = a;
            B = b;

            resultado = a - b;
        }

    }
}
