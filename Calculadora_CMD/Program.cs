using System;
using System.Collections.Generic;
using Calculadora_CMD.Enums;
using Calculadora_CMD.Operacoes;
using System.Globalization;

namespace Calculadora_CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu opcao = new Menu();
            Soma soma;
            Subtracao subtracao;
            Divisao divisao;
            Multiplicacao multiplicacao;
            

            

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
                         int som1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o segundo número: ");
                        Console.WriteLine();
                        int som2 = int.Parse(Console.ReadLine());
                        soma = new Soma(som1, som2);
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {soma.resultado}");
                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;

                    case Menu.Subtracao:
                        Console.WriteLine("Subtração de dois números:");
                        Console.WriteLine();
                        Console.WriteLine("Digite o primeiro número: ");
                        Console.WriteLine();
                        int sub1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o segundo número: ");
                        Console.WriteLine();
                        int sub2 = int.Parse(Console.ReadLine());
                        subtracao = new Subtracao(sub1, sub2);
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {subtracao.resultado}");
                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;

                    case Menu.Divisao:
                        Console.WriteLine("Divisão de dois números:");
                        Console.WriteLine();
                        Console.WriteLine("Digite o primeiro número: ");
                        Console.WriteLine();
                        double div1 = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o segundo número: ");
                        Console.WriteLine();
                        double div2 = double.Parse(Console.ReadLine());
                        divisao = new Divisao(div1, div2);
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {divisao.resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;

                    case Menu.Multiplicacao:
                        Console.WriteLine("Multiplicação de dois números:");
                        Console.WriteLine();
                        Console.WriteLine("Digite o primeiro número: ");
                        Console.WriteLine();
                        int mult1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o segundo número: ");
                        Console.WriteLine();
                        int mult2 = int.Parse(Console.ReadLine());
                        multiplicacao = new Multiplicacao(mult1, mult2);
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {multiplicacao.resultado}");
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
