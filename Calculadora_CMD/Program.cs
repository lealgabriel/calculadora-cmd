using System;
using System.Collections.Generic;
using Calculadora_CMD.Enums;
using Calculadora_CMD.Operacoes;

namespace Calculadora_CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu opcao = new Menu();
            Soma soma;
            

            

            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Bem vindo ao CALC! Selecione uma das opções: ");
                Console.WriteLine();
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair");

                opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Console.WriteLine("Soma de dois números:");
                        Console.WriteLine();
                        Console.WriteLine("Digite o primeiro número: ");
                        Console.WriteLine();
                         int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o segundo número: ");
                        Console.WriteLine();
                        int n2 = int.Parse(Console.ReadLine());

                        soma = new Soma(n1, n2);
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {soma.resultado}");
                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        
                        break;

                    case Menu.Sair:
                        escolheuSair=true;
                        break;
                }

                Console.Clear();
            }
            
        }
    }


}
