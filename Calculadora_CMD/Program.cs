using System;
using System.Collections.Generic;
using Calculadora_CMD.Enums;

namespace Calculadora_CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu opcao = new Menu();

            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Bem vindo ao CALC! Selecione uma das opções: ");
                Console.WriteLine();
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair");

                opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Sair:
                        escolheuSair=true;
                        break;
                }

                Console.Clear();
            }
            
        }
    }


}
