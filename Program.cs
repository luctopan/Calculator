using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1. SOMA");
            Console.WriteLine("2. SUBTRAÇÃO");
            Console.WriteLine("3. DIVISÃO");
            Console.WriteLine("4. MULTIPLICAÇÃO");
            Console.WriteLine("0. SAIR");

            Console.WriteLine("---------------------------");
            Console.Write("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Calcular("soma"); break;
                case 2: Calcular("subtracao"); break;
                case 3: Calcular("divisao"); break;
                case 4: Calcular("multiplicacao"); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Calcular(string operacao)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado;

            switch (operacao)
            {
                case "soma":
                    Console.WriteLine("");
                    resultado = v1 + v2;
                    Console.Write($"O resultado da soma é {resultado}");
                    Console.ReadKey();
                    Menu();
                    break;
                case "subtracao":
                    Console.WriteLine("");
                    resultado = v1 - v2;
                    Console.Write($"O resultado da subtração é {resultado}");
                    Console.ReadKey();
                    Menu();
                    break;
                case "divisao":
                    Console.WriteLine("");
                    resultado = v1 / v2;
                    Console.Write($"O resultado da divisão é {resultado}");
                    Console.ReadKey();
                    Menu();
                    break;
                case "multiplicacao":
                    Console.WriteLine("");
                    resultado = v1 * v2;
                    Console.Write($"O resultado da multiplicação é {resultado}");
                    Console.ReadKey();
                    Menu();
                    break;
                default:
                    Menu();
                    break;
            }

        }
    }
}