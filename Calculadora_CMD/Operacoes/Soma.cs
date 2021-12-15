namespace Calculadora_CMD.Operacoes
{
    class Soma
    {
        public int A { get; set; }
        public int B { get; set; }

        public int Resultado; 

        public Soma(int a, int b)
        {
            A = a;
            B = b;

            Resultado = a + b;
        }

        



    }
}
