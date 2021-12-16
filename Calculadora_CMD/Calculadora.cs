namespace Calculadora_CMD
{
    internal class Calculadora
    {
        public int A;
        public int B;
        public int C;

        public int Soma()
        {
            return A + B;
        }

        public int Subtracao()
        {
            return A - B;
        }

        public double Divisao()
        {
            return (double)A / (double)B;
        }

        public double Multiplicacao()
        {
            return A * B;
        }

        public double Potencia()
        {
            return Math.Pow(A, B);
        }

        public double Raiz()
        {
            return Math.Sqrt(A);
        }

        public double Regra3()
        {
            return B * C / A;
        }




    }
}
