using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_CMD
{
    internal class Menu
    {
        public override string ToString()
        {
            return "Bem vindo ao CALC! Selecione uma das opções:\n\n" 
                + "1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair";
        }

    }
}
