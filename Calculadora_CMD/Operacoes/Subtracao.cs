namespace Calculadora_CMD.Operacoes
{
    internal class Subtracao
    {
        public int A { get; set; }
        public int B { get; set; }

        public int Resultado;

        public Subtracao(int a, int b)
        {
            A = a;
            B = b;

            Resultado = a - b;
        }

    }
}
