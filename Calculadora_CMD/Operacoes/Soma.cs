namespace Calculadora_CMD.Operacoes
{
    class Soma
    {
        public int A { get; set; }
        public int B { get; set; }

        public int resultado; 

        public Soma(int a, int b)
        {
            A = a;
            B = b;

            resultado = a + b;
        }

       

    }
}
