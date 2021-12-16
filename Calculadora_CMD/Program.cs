using System;
using Calculadora_CMD.Enums;

namespace Calculadora_CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            EnumMenu opcao = new EnumMenu();
            Calculadora calculadora = new Calculadora();




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
                        calculadora.A = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o segundo número: ");
                        Console.WriteLine();
                        calculadora.B = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {calculadora.Soma()}");
                        break;

                    case EnumMenu.Subtracao:
                        Console.WriteLine("Subtração de dois números:");
                        Console.WriteLine();
                        Console.WriteLine("Digite o primeiro número: ");
                        Console.WriteLine();
                        calculadora.A = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o segundo número: ");
                        Console.WriteLine();
                        calculadora.B = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {calculadora.Subtracao()}");
                        break;

                    case EnumMenu.Divisao:
                        Console.WriteLine("Divisão de dois números:");
                        Console.WriteLine();
                        Console.WriteLine("Digite o primeiro número: ");
                        Console.WriteLine();
                        calculadora.A = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o segundo número: ");
                        Console.WriteLine();
                        calculadora.B = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {calculadora.Divisao()}");
                        break;

                    case EnumMenu.Multiplicacao:
                        Console.WriteLine("Multiplicação de dois números:");
                        Console.WriteLine();
                        Console.WriteLine("Digite o primeiro número: ");
                        Console.WriteLine();
                        calculadora.A = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o segundo número: ");
                        Console.WriteLine();
                        calculadora.B = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {calculadora.Multiplicacao()}");
                        break;

                    case EnumMenu.Potencia:
                        Console.WriteLine("Potencia de um número:");
                        Console.WriteLine();
                        Console.WriteLine("Digite a base: ");
                        Console.WriteLine();
                        calculadora.A = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Digite o expoente: ");
                        Console.WriteLine();
                        calculadora.B = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {calculadora.Potencia()}");
                        break;

                    case EnumMenu.Raiz:
                        Console.WriteLine("Raiz de um número:");
                        Console.WriteLine();
                        Console.WriteLine("Digite o número: ");
                        Console.WriteLine();
                        calculadora.A = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"O resultado é {calculadora.Raiz()}");
                        break;

                    case EnumMenu.Regra3:
                        Console.WriteLine("##### A está para B #####");
                        Console.WriteLine();
                        Console.Write("Digite o número que representa A: ");
                        calculadora.A = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Digite o número que representa B: ");
                        calculadora.B = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("##### C está para X #####");
                        Console.WriteLine();
                        Console.Write("Digite o número que representa C: ");
                        calculadora.C = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"X = {calculadora.Regra3()}");
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
                
                if (escolheuSair == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Aperte ENTER para voltar ao menu");
                    Console.ReadLine();
                }
                
                Console.Clear();
            }

        }
    }


}
