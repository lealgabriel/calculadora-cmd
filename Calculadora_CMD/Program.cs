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
            Menu menu = new Menu();
            EnumMenu opcao = new EnumMenu();
            Soma soma;
            Subtracao subtracao;
            Divisao divisao;
            Multiplicacao multiplicacao;
            Potencia potencia;
            Raiz raiz;




            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine(menu);

                opcao = (EnumMenu)int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case EnumMenu.Soma:
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
                        Console.WriteLine($"O resultado é {soma.Resultado}");
                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;

                    case EnumMenu.Subtracao:
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
                        Console.WriteLine($"O resultado é {subtracao.Resultado}");
                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;

                    case EnumMenu.Divisao:
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
                        Console.WriteLine($"O resultado é {divisao.Resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;

                    case EnumMenu.Multiplicacao:
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
                        Console.WriteLine($"O resultado é {multiplicacao.Resultado}");
                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;

                    case EnumMenu.Potencia:
                        Console.WriteLine("Potencia de um número:");
                        Console.WriteLine();
                        Console.WriteLine("Digite a base: ");
                        Console.WriteLine();
                        int pot1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o expoente: ");
                        Console.WriteLine();
                        int pot2 = int.Parse(Console.ReadLine());
                        potencia = new Potencia(pot1, pot2);
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {potencia.Resultado.ToString(CultureInfo.InvariantCulture)}");
                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;

                    case EnumMenu.Raiz:
                        Console.WriteLine("Raiz de um número:");
                        Console.WriteLine();
                        Console.WriteLine("Digite o número: ");
                        Console.WriteLine();
                        int raiz1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        raiz = new Raiz(raiz1);
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {raiz.Resultado.ToString(CultureInfo.InvariantCulture)}");
                        Console.WriteLine();
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;

                    case EnumMenu.Sair:
                        Console.WriteLine("Tem certeza que deseja sair? (s/n)");
                        char sairMenu = char.Parse(Console.ReadLine());
                        if (sairMenu == 's' || sairMenu == 'S')
                        {
                            escolheuSair = true;
                        }
                        break;
                }

                Console.Clear();
            }

        }
    }


}
